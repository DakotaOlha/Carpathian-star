﻿namespace Carpathian_star
{
    partial class EnterWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnterWindow));
            Start = new Button();
            Profile = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Start
            // 
            Start.AutoEllipsis = true;
            Start.BackColor = Color.Transparent;
            Start.BackgroundImage = (Image)resources.GetObject("Start.BackgroundImage");
            Start.BackgroundImageLayout = ImageLayout.Stretch;
            Start.FlatStyle = FlatStyle.Popup;
            Start.Font = new Font("Pixeled", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Start.ForeColor = Color.LightGoldenrodYellow;
            Start.Location = new Point(729, 497);
            Start.Name = "Start";
            Start.Size = new Size(270, 115);
            Start.TabIndex = 0;
            Start.UseVisualStyleBackColor = false;
            // 
            // Profile
            // 
            Profile.BackColor = Color.OliveDrab;
            Profile.BackgroundImage = (Image)resources.GetObject("Profile.BackgroundImage");
            Profile.BackgroundImageLayout = ImageLayout.Stretch;
            Profile.Font = new Font("Pixeled", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Profile.Location = new Point(961, 12);
            Profile.Name = "Profile";
            Profile.Size = new Size(55, 50);
            Profile.TabIndex = 3;
            Profile.TextAlign = ContentAlignment.TopRight;
            Profile.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(33, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(741, 251);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // EnterWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1041, 643);
            Controls.Add(pictureBox1);
            Controls.Add(Profile);
            Controls.Add(Start);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EnterWindow";
            Text = "EnterWindow";
            Load += EnterWindow_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Start;
        private Button Profile;
        private PictureBox pictureBox1;
    }
}