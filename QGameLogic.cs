using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MPilonQGame
{
    public class QGameLogic : Form
    {
        #region Global Variables
        //Declares an Image which will be used to change the pictureboxes Image
        public Image SelectedImage { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Created my own constructor that sets the Image
        /// </summary>
        /// <param name="selectedImage">This Image comes from the level designer form</param>
        public QGameLogic(Image selectedImage)
        {
            SelectedImage = selectedImage;
        }
        #endregion

        #region Methods
        /// <summary>
        /// This method does three things. The first is it generates the grid to display on the level designer form. The second is
        /// it resizes the screen so you don't have to do it manually. The third is it gets the current size of your monitor's resolution
        /// and determins the max size of your grid. 
        /// </summary>
        /// <param name="row">Number of rows for the grid</param>
        /// <param name="col">Number of columns for the grid</param>
        /// <param name="levelDesigner">The reference to the form we are changing</param>
        public void GeneratePictureBoxes(int row, int col, Form levelDesigner)
        {
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;
            bool largerThanScreen = false;

            int maxPictureBoxWidth = (screenWidth - 175) / 50;
            int maxPictureBoxHeight = ((screenHeight - 85) / 50) -1;

            int switchToFullScreenWidth = (int)(maxPictureBoxWidth * (6.0 / 10));
            int switchToFullScreenHeight = (int)(maxPictureBoxHeight * (6.0 / 10));

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {

                    PictureBox pictureBox = new PictureBox
                    {
                        Size = new Size(50, 50),
                        BorderStyle = BorderStyle.FixedSingle,
                        Location = new Point((200 + (50 * j)), (110 + (50 * i))),
                        BackColor = Color.White,
                        SizeMode = PictureBoxSizeMode.StretchImage,
                    };

                    if (pictureBox.Right > screenWidth || pictureBox.Bottom > screenHeight)
                    {
                        largerThanScreen = true;
                        RemoveAllPictureBoxes(levelDesigner);
                        MessageBox.Show($"The grid is larger than your screen, your max grid is rows: {maxPictureBoxHeight} and columns: {maxPictureBoxWidth}", "QGame Error", MessageBoxButtons.OK);
                        break;
                    }

                    pictureBox.Click += PictureBox_Click;

                    levelDesigner.Controls.Add(pictureBox);
                }

                if (largerThanScreen)
                {
                    levelDesigner.Size = new Size(816, 489);
                    break;
                }
                else
                {
                    if (row > switchToFullScreenHeight || col > switchToFullScreenWidth)
                    {
                        levelDesigner.WindowState = FormWindowState.Maximized;
                    }
                    else
                    {
                        int switchScreenSizeWidth = (300 + (50 * col));
                        int switchScreenSizeHeight = (210 + (50 * row));

                        levelDesigner.Size = new Size(switchScreenSizeWidth, switchScreenSizeHeight);
                    }
                }
            }

            levelDesigner.Refresh();
        }

        /// <summary>
        /// When a picturebox is clicked it sets the picturebox image as the image sent through the constructor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox clickedPictureBox = sender as PictureBox;

            clickedPictureBox.Image = SelectedImage;
        }

        /// <summary>
        /// This method gets all the controls from a form (pictureboxes from leveldesigner) and removes them
        /// </summary>
        /// <param name="levelDesigner">The form to remove the pictureboxes from</param>
        public void RemoveAllPictureBoxes(Form levelDesigner)
        {
            foreach (Control control in levelDesigner.Controls.OfType<PictureBox>().ToList())
            {
                levelDesigner.Controls.Remove(control);
                control.Dispose();
            }
        }

        /// <summary>
        /// A simple method that check if both the row and column values are positive integers and returns a tuple(bool, bool)
        /// </summary>
        /// <param name="rows">Number of rows from the grid</param>
        /// <param name="col">Number of columns from the grid</param>
        /// <returns></returns>
        public (bool rows, bool col) IsValidNumber(string rows, string col)
        {
            Regex validNumber = new Regex(@"^\d+");

            bool isValidRow = validNumber.IsMatch(rows);
            bool isValidCol = validNumber.IsMatch(col);

            return (isValidRow, isValidCol);
        }

        /// <summary>
        /// This method that writes data to an external file does a few things. First it sets the save directory to a folder called 
        /// Saved Levels in the game environment and sets the default file format as a .txt file. then it confirms that the number of 
        /// pictureboxes in the grid is the same as the grid dimensions (necessary for the way I write the data in the file). If the 
        /// validation passes it will allow you to save the level to the saved levels directory and writes the dimension of the grid
        /// (rows: 5 columns: 4), counts the number of walls, doors boxes and writes each one to the file as a series of numbers from 
        /// 0-5 (0 = no image, 1 = wall etc). Finally it will give you a confirmation message with the count of each box, door and wall.
        /// </summary>
        /// <param name="rows"></param>
        /// <param name="col"></param>
        /// <param name="imageList"></param>
        public void SaveLevel(int rows, int col, List<Image> imageList)
        {
            int numberOfWalls = 0;
            int numberOfDoors = 0;
            int numberOfBoxes = 0;
            int numberOfPictureBoxes = 0;
            int grid = rows * col;

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                string currentDirectory = Environment.CurrentDirectory;
                DirectoryInfo directory = new DirectoryInfo(currentDirectory);
                DirectoryInfo parentDirectory = directory.Parent.Parent;

                saveFileDialog.InitialDirectory = Path.Combine(parentDirectory.FullName, "Saved Levels");
                saveFileDialog.Filter = "Text files (*.txt)|*.txt";

                foreach(Image image in imageList)
                {
                    numberOfPictureBoxes++;
                }

                if (numberOfPictureBoxes != grid)
                {
                    MessageBox.Show("Unable to save file due to inconsistency with rows and columns. Please check to ensure they are correct", "QGame Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    
                    string filePath = saveFileDialog.FileName;

                    
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        writer.WriteLine($"Rows: {rows}, Col: {col}");

                        foreach (Image image in imageList)
                        {
                            if (image == null)
                            {
                                writer.Write("0");
                            }
                            else if (image.Tag.ToString() == "Wall") 
                            {
                                writer.Write("1");
                                numberOfWalls++;
                            }
                            else if (image.Tag.ToString() == "Red Door")
                            {
                                writer.Write("2");
                                numberOfDoors++;
                            }
                            else if(image.Tag.ToString() == "Green Door")
                            { 
                                writer.Write("3");
                                numberOfDoors++;
                            }
                            else if (image.Tag.ToString() == "Red Box")
                            {
                                writer.Write("4");
                                numberOfBoxes++;
                            }
                            else if (image.Tag.ToString() == "Green Box")
                            {
                                writer.Write("5");
                                numberOfBoxes++;
                            }
                            else
                            {
                                MessageBox.Show("Something went wrong and could not save level", "QGame Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                    }
                    MessageBox.Show($"File saved successfully \nTotal number of walls: {numberOfWalls}\nTotal number of doors: {numberOfDoors}\nTotal number of boxes: {numberOfBoxes}", "QGame Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        #endregion
    }
}
