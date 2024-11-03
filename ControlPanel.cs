/*
 * Created by Merrick Pilon, 8947730, on November 1st, 2024
 * Purpose: To create a level designer for QGame
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MPilonQGame
{
    public partial class ControlPanel : Form
    {
        #region Constructors
        public ControlPanel()
        {
            InitializeComponent();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Closes the form on click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Opens the level designer form on click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DesignButton_Click(object sender, EventArgs e)
        {
            LevelDesigner levelDesigner = new LevelDesigner();
            levelDesigner.ShowDialog();
        }
        #endregion


    }
}
