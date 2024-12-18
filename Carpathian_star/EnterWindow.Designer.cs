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
            Exit = new Button();
            SoundButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Start
            // 
            Start.AutoEllipsis = true;
            Start.BackColor = Color.Transparent;
            Start.BackgroundImage = (Image)resources.GetObject("Start.BackgroundImage");
            Start.BackgroundImageLayout = ImageLayout.Stretch;
            Start.Enabled = false;
            Start.FlatStyle = FlatStyle.Popup;
            Start.Font = new Font("Pixeled", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Start.ForeColor = Color.LightGoldenrodYellow;
            Start.Location = new Point(695, 614);
            Start.Name = "Start";
            Start.Size = new Size(270, 115);
            Start.TabIndex = 0;
            Start.UseVisualStyleBackColor = false;
            Start.Click += Start_Click_1;
            // 
            // Profile
            // 
            Profile.BackColor = Color.DarkOliveGreen;
            Profile.BackgroundImage = (Image)resources.GetObject("Profile.BackgroundImage");
            Profile.BackgroundImageLayout = ImageLayout.Stretch;
            Profile.FlatStyle = FlatStyle.Flat;
            Profile.Font = new Font("Pixeled", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Profile.Location = new Point(897, 24);
            Profile.Name = "Profile";
            Profile.Size = new Size(50, 42);
            Profile.TabIndex = 3;
            Profile.TextAlign = ContentAlignment.TopRight;
            Profile.UseVisualStyleBackColor = false;
            Profile.Click += Profile_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(29, 110);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(741, 251);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Exit
            // 
            Exit.BackColor = Color.Transparent;
            Exit.BackgroundImage = (Image)resources.GetObject("Exit.BackgroundImage");
            Exit.BackgroundImageLayout = ImageLayout.Stretch;
            Exit.FlatStyle = FlatStyle.Flat;
            Exit.Font = new Font("Pixeled", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Exit.Location = new Point(965, 1);
            Exit.Name = "Exit";
            Exit.Size = new Size(35, 33);
            Exit.TabIndex = 5;
            Exit.TextAlign = ContentAlignment.TopRight;
            Exit.UseVisualStyleBackColor = false;
            Exit.Click += Exit_Click;
            // 
            // SoundButton
            // 
            SoundButton.BackColor = Color.Transparent;
            SoundButton.BackgroundImage = (Image)resources.GetObject("SoundButton.BackgroundImage");
            SoundButton.BackgroundImageLayout = ImageLayout.Stretch;
            SoundButton.FlatStyle = FlatStyle.Flat;
            SoundButton.Location = new Point(12, 681);
            SoundButton.Name = "SoundButton";
            SoundButton.Size = new Size(81, 81);
            SoundButton.TabIndex = 6;
            SoundButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            SoundButton.UseVisualStyleBackColor = false;
            SoundButton.Click += SoundButton_Click;
            // 
            // EnterWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1004, 776);
            Controls.Add(SoundButton);
            Controls.Add(Exit);
            Controls.Add(pictureBox1);
            Controls.Add(Profile);
            Controls.Add(Start);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EnterWindow";
            Text = "EnterWindow";
            Load += EnterWindow_Load;
            KeyDown += EnterWindow_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button Profile;
        private PictureBox pictureBox1;
        public Button Start;
        private Button Exit;
        private Button SoundButton;
    }
}