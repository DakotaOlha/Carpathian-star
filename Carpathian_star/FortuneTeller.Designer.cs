namespace Carpathian_star
{
    partial class FortuneTeller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FortuneTeller));
            BalanceLabel = new Label();
            pictureBox1 = new PictureBox();
            back_button = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // BalanceLabel
            // 
            BalanceLabel.AutoSize = true;
            BalanceLabel.Font = new Font("Pixeled", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BalanceLabel.ForeColor = Color.LightYellow;
            BalanceLabel.Image = (Image)resources.GetObject("BalanceLabel.Image");
            BalanceLabel.Location = new Point(595, 19);
            BalanceLabel.Name = "BalanceLabel";
            BalanceLabel.Size = new Size(134, 37);
            BalanceLabel.TabIndex = 49;
            BalanceLabel.Text = "_________";
            BalanceLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(544, 16);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 48;
            pictureBox1.TabStop = false;
            // 
            // back_button
            // 
            back_button.BackColor = Color.White;
            back_button.BackgroundImage = (Image)resources.GetObject("back_button.BackgroundImage");
            back_button.BackgroundImageLayout = ImageLayout.Stretch;
            back_button.FlatStyle = FlatStyle.Flat;
            back_button.Font = new Font("Pixeled", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            back_button.ForeColor = SystemColors.ButtonFace;
            back_button.Location = new Point(11, 579);
            back_button.Margin = new Padding(2);
            back_button.Name = "back_button";
            back_button.Size = new Size(62, 45);
            back_button.TabIndex = 50;
            back_button.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Location = new Point(343, 403);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 53);
            pictureBox2.TabIndex = 51;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(382, 75);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(363, 297);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 53;
            pictureBox3.TabStop = false;
            // 
            // FortuneTeller
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(757, 644);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(back_button);
            Controls.Add(BalanceLabel);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FortuneTeller";
            Text = "FortuneTeller";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label BalanceLabel;
        private PictureBox pictureBox1;
        private Button back_button;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}