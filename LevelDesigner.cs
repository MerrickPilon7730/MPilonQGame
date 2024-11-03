using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MPilonQGame
{
    public partial class LevelDesigner : Form
    {
        #region Global Variables
        /// <summary>
        /// Declare the QGame logic class, an Image, and a list of images
        /// </summary>
        public QGameLogic logic;
        public Image selectedImage;
        public List<Image> pictureBoxesImages = new List<Image>();
        #endregion

        #region Constructors
        /// <summary>
        /// Added a minimum screen size and initalized the QGame logic class that passes an image to the class.
        /// </summary>
        public LevelDesigner()
        {
            InitializeComponent();
            this.MinimumSize = new Size(846, 551);
            logic = new QGameLogic(selectedImage);
        }
        #endregion

        #region Methods
        /// <summary>
        /// When saving a level this method will parse the rows and columns from the form and remove any images in the pictureBoxesImages 
        /// list. Then it adds all current Images from the form to the Image list. If there are no pictureboxes (no grid generated) 
        /// a FormatException is thrown, else it sends the rows, columns and the list of Images to the QGameLogic class to save the level.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int rows = int.Parse(RowsTextBox.Text);
                int columns = int.Parse(ColumnsTextBox.Text);

                pictureBoxesImages.Clear();

                foreach (PictureBox pictureBox in Controls.OfType<PictureBox>())
                {
                    pictureBoxesImages.Add(pictureBox.Image);
                }

                logic.SaveLevel(rows, columns, pictureBoxesImages);

            }
            catch (FormatException)
            {
                MessageBox.Show("You have not created a level yet", "QGame Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Closes the current form on click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// When closing the level designer form it will ask for a confirmation 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LevelDesigner_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult choice = MessageBox.Show("Are you sure you want to exit, any unsaved data will be deleted", "QGame Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (choice == DialogResult.No)
            {
                e.Cancel = true;
            }
            
        }

        /// <summary>
        /// When generating a grid it first checks to make sure there isn't another grid already generated with images on it.
        /// If there is a grid already present with pictures it checks to make sure the rows and columns are correct then
        /// confirms if you want to create a new grid and discard the current one. If you are creating the first grid or a new 
        /// with no pictures it will validate the rows and columns then generate the new grid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateButton_Click(object sender, EventArgs e)
        {
            bool hasImage = false;

            if (this.Controls.OfType<PictureBox>().Any())
            {
                foreach (PictureBox picturebox in Controls.OfType<PictureBox>())
                {
                    if(picturebox.Image != null)
                    {
                        hasImage = true;
                        break;
                    }
                }
            }
            

            if (!hasImage)
            {

                (bool rows, bool cols) = logic.IsValidNumber(RowsTextBox.Text, ColumnsTextBox.Text);

                if (rows && cols)
                {
                    logic.RemoveAllPictureBoxes(this);

                    int numRows = int.Parse(RowsTextBox.Text);
                    int numCols = int.Parse(ColumnsTextBox.Text);

                    logic.GeneratePictureBoxes(numRows, numCols, this);
                }
                else
                {
                    if (!rows || !cols)
                    {
                        MessageBox.Show("Please provide valid data for rows and columns (Both must be positive integers)", "QGame Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                (bool rows, bool cols) = logic.IsValidNumber(RowsTextBox.Text, ColumnsTextBox.Text);

                if (!rows || !cols)
                {
                    MessageBox.Show("Please provide valid data for rows and columns (Both must be positive integers)", "QGame Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult choice = MessageBox.Show("Do you want to create a new level? If you do, any unsaved data will be lost", "QGame Caution", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (choice == DialogResult.Yes)
                    {
                        if (rows && cols)
                        {
                            logic.RemoveAllPictureBoxes(this);

                            int numRows = int.Parse(RowsTextBox.Text);
                            int numCols = int.Parse(ColumnsTextBox.Text);

                            logic.GeneratePictureBoxes(numRows, numCols, this);
                        }
                    }
                }
            }
        }
        /// <summary>
        /// These methods set the tag of an image and set the Image to be passed to QGame logic so it knows which block you want 
        /// to place in the grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NoneButton_Click(object sender, EventArgs e)
        {
            logic.SelectedImage.Tag = "";
            logic.SelectedImage = null;  
        }

        private void WallButton_Click(object sender, EventArgs e)
        {
            logic.SelectedImage = Properties.Resources.WallBlock;
            logic.SelectedImage.Tag = "Wall";
        }

        private void RedDoorButton_Click(object sender, EventArgs e)
        {
            logic.SelectedImage = Properties.Resources.RedDoorBlock;
            logic.SelectedImage.Tag = "Red Door";
        }

        private void GreenDoorButton_Click(object sender, EventArgs e)
        {
            logic.SelectedImage = Properties.Resources.GreenDoorBlock;
            logic.SelectedImage.Tag = "Green Door";
        }

        private void RedBoxButton_Click(object sender, EventArgs e)
        {
            logic.SelectedImage = Properties.Resources.RedBoxBlock;
            logic.SelectedImage.Tag = "Red Box";
        }

        private void GreenBoxButton_Click(object sender, EventArgs e)
        {
            logic.SelectedImage = Properties.Resources.GreenBoxBlock;
            logic.SelectedImage.Tag = "Green Box";
        }
        #endregion
    }


}
