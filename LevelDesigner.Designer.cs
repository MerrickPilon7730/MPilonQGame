namespace MPilonQGame
{
    partial class LevelDesigner
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GreenBoxButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RedBoxButton = new System.Windows.Forms.Button();
            this.GreenDoorButton = new System.Windows.Forms.Button();
            this.RedDoorButton = new System.Windows.Forms.Button();
            this.WallButton = new System.Windows.Forms.Button();
            this.NoneButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ColumnsTextBox = new System.Windows.Forms.TextBox();
            this.RowsTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(830, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GreenBoxButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.RedBoxButton);
            this.groupBox1.Controls.Add(this.GreenDoorButton);
            this.groupBox1.Controls.Add(this.RedDoorButton);
            this.groupBox1.Controls.Add(this.WallButton);
            this.groupBox1.Controls.Add(this.NoneButton);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(175, 65535);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // GreenBoxButton
            // 
            this.GreenBoxButton.Image = global::MPilonQGame.Properties.Resources.GreenBox;
            this.GreenBoxButton.Location = new System.Drawing.Point(12, 380);
            this.GreenBoxButton.Name = "GreenBoxButton";
            this.GreenBoxButton.Size = new System.Drawing.Size(116, 58);
            this.GreenBoxButton.TabIndex = 6;
            this.GreenBoxButton.UseVisualStyleBackColor = true;
            this.GreenBoxButton.Click += new System.EventHandler(this.GreenBoxButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Toolbox";
            // 
            // RedBoxButton
            // 
            this.RedBoxButton.Image = global::MPilonQGame.Properties.Resources.RedBox;
            this.RedBoxButton.Location = new System.Drawing.Point(12, 320);
            this.RedBoxButton.Name = "RedBoxButton";
            this.RedBoxButton.Size = new System.Drawing.Size(116, 58);
            this.RedBoxButton.TabIndex = 5;
            this.RedBoxButton.UseVisualStyleBackColor = true;
            this.RedBoxButton.Click += new System.EventHandler(this.RedBoxButton_Click);
            // 
            // GreenDoorButton
            // 
            this.GreenDoorButton.Image = global::MPilonQGame.Properties.Resources.GreenDoor;
            this.GreenDoorButton.Location = new System.Drawing.Point(12, 260);
            this.GreenDoorButton.Name = "GreenDoorButton";
            this.GreenDoorButton.Size = new System.Drawing.Size(116, 58);
            this.GreenDoorButton.TabIndex = 4;
            this.GreenDoorButton.UseVisualStyleBackColor = true;
            this.GreenDoorButton.Click += new System.EventHandler(this.GreenDoorButton_Click);
            // 
            // RedDoorButton
            // 
            this.RedDoorButton.Image = global::MPilonQGame.Properties.Resources.RedDoor;
            this.RedDoorButton.Location = new System.Drawing.Point(12, 200);
            this.RedDoorButton.Name = "RedDoorButton";
            this.RedDoorButton.Size = new System.Drawing.Size(116, 58);
            this.RedDoorButton.TabIndex = 3;
            this.RedDoorButton.UseVisualStyleBackColor = true;
            this.RedDoorButton.Click += new System.EventHandler(this.RedDoorButton_Click);
            // 
            // WallButton
            // 
            this.WallButton.Image = global::MPilonQGame.Properties.Resources.Wall;
            this.WallButton.Location = new System.Drawing.Point(12, 140);
            this.WallButton.Name = "WallButton";
            this.WallButton.Size = new System.Drawing.Size(116, 58);
            this.WallButton.TabIndex = 2;
            this.WallButton.UseVisualStyleBackColor = true;
            this.WallButton.Click += new System.EventHandler(this.WallButton_Click);
            // 
            // NoneButton
            // 
            this.NoneButton.Image = global::MPilonQGame.Properties.Resources.None;
            this.NoneButton.Location = new System.Drawing.Point(12, 80);
            this.NoneButton.Name = "NoneButton";
            this.NoneButton.Size = new System.Drawing.Size(116, 58);
            this.NoneButton.TabIndex = 1;
            this.NoneButton.UseVisualStyleBackColor = true;
            this.NoneButton.Click += new System.EventHandler(this.NoneButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GenerateButton);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.ColumnsTextBox);
            this.groupBox2.Controls.Add(this.RowsTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(0, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(65535, 59);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // GenerateButton
            // 
            this.GenerateButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.GenerateButton.Location = new System.Drawing.Point(400, 19);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(102, 31);
            this.GenerateButton.TabIndex = 4;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = false;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Columns:";
            // 
            // ColumnsTextBox
            // 
            this.ColumnsTextBox.Location = new System.Drawing.Point(270, 25);
            this.ColumnsTextBox.Name = "ColumnsTextBox";
            this.ColumnsTextBox.Size = new System.Drawing.Size(100, 20);
            this.ColumnsTextBox.TabIndex = 2;
            // 
            // RowsTextBox
            // 
            this.RowsTextBox.Location = new System.Drawing.Point(85, 25);
            this.RowsTextBox.Name = "RowsTextBox";
            this.RowsTextBox.Size = new System.Drawing.Size(100, 20);
            this.RowsTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Rows:";
            // 
            // LevelDesigner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 512);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LevelDesigner";
            this.Text = "Level Designer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LevelDesigner_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Button NoneButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button WallButton;
        private System.Windows.Forms.Button RedDoorButton;
        private System.Windows.Forms.Button GreenDoorButton;
        private System.Windows.Forms.Button RedBoxButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ColumnsTextBox;
        private System.Windows.Forms.TextBox RowsTextBox;
        private System.Windows.Forms.Button GreenBoxButton;
    }
}