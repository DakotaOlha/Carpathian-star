namespace Carpathian_star
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
            Carpathian = new Label();
            star = new Label();
            Profile = new Button();
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
            Start.Location = new Point(911, 621);
            Start.Margin = new Padding(4);
            Start.Name = "Start";
            Start.Size = new Size(338, 144);
            Start.TabIndex = 0;
            Start.UseVisualStyleBackColor = false;
            Start.Click += Start_Click;
            // 
            // Carpathian
            // 
            Carpathian.AutoSize = true;
            Carpathian.BackColor = Color.Transparent;
            Carpathian.Font = new Font("Pixeled", 30F);
            Carpathian.ForeColor = SystemColors.ButtonFace;
            Carpathian.Location = new Point(26, 26);
            Carpathian.Margin = new Padding(4, 0, 4, 0);
            Carpathian.Name = "Carpathian";
            Carpathian.Size = new Size(634, 168);
            Carpathian.TabIndex = 1;
            Carpathian.Text = "Carpathian";
            // 
            // star
            // 
            star.AutoSize = true;
            star.BackColor = Color.Transparent;
            star.Font = new Font("Pixeled", 30F);
            star.ForeColor = SystemColors.ButtonFace;
            star.Location = new Point(476, 144);
            star.Margin = new Padding(4, 0, 4, 0);
            star.Name = "star";
            star.Size = new Size(310, 168);
            star.TabIndex = 2;
            star.Text = "star";
            // 
            // Profile
            // 
            Profile.Font = new Font("Pixeled", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Profile.Location = new Point(1206, 15);
            Profile.Margin = new Padding(4);
            Profile.Name = "Profile";
            Profile.Size = new Size(64, 65);
            Profile.TabIndex = 3;
            Profile.Text = "P";
            Profile.TextAlign = ContentAlignment.TopRight;
            Profile.UseVisualStyleBackColor = true;
            Profile.Click += Profile_Click;
            // 
            // EnterWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1301, 804);
            Controls.Add(Profile);
            Controls.Add(Carpathian);
            Controls.Add(star);
            Controls.Add(Start);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "EnterWindow";
            Text = "EnterWindow";
            Load += EnterWindow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Carpathian;
        private Label star;
        private Button Profile;
        public Button Start;
    }
}