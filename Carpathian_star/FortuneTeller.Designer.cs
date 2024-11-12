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
            MessagePictureBox = new PictureBox();
            FortuneTallerLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MessagePictureBox).BeginInit();
            SuspendLayout();
            // 
            // BalanceLabel
            // 
            BalanceLabel.AutoSize = true;
            BalanceLabel.Font = new Font("Pixeled", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BalanceLabel.ForeColor = Color.LightYellow;
            BalanceLabel.Image = (Image)resources.GetObject("BalanceLabel.Image");
            BalanceLabel.Location = new Point(744, 20);
            BalanceLabel.Margin = new Padding(4, 0, 4, 0);
            BalanceLabel.Name = "BalanceLabel";
            BalanceLabel.Size = new Size(164, 45);
            BalanceLabel.TabIndex = 49;
            BalanceLabel.Text = "999999999";
            BalanceLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(680, 20);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(58, 54);
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
            back_button.Location = new Point(14, 724);
            back_button.Margin = new Padding(2);
            back_button.Name = "back_button";
            back_button.Size = new Size(78, 56);
            back_button.TabIndex = 50;
            back_button.UseVisualStyleBackColor = false;
            back_button.Click += back_button_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Location = new Point(429, 504);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(80, 66);
            pictureBox2.TabIndex = 51;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // MessagePictureBox
            // 
            MessagePictureBox.BackColor = Color.Transparent;
            MessagePictureBox.Image = (Image)resources.GetObject("MessagePictureBox.Image");
            MessagePictureBox.Location = new Point(478, 94);
            MessagePictureBox.Margin = new Padding(4);
            MessagePictureBox.Name = "MessagePictureBox";
            MessagePictureBox.Size = new Size(454, 371);
            MessagePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            MessagePictureBox.TabIndex = 53;
            MessagePictureBox.TabStop = false;
            MessagePictureBox.Visible = false;
            // 
            // FortuneTallerLabel
            // 
            FortuneTallerLabel.AutoSize = true;
            FortuneTallerLabel.BackColor = Color.White;
            FortuneTallerLabel.Font = new Font("Pixeled", 6F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FortuneTallerLabel.Location = new Point(509, 223);
            FortuneTallerLabel.Name = "FortuneTallerLabel";
            FortuneTallerLabel.Size = new Size(0, 33);
            FortuneTallerLabel.TabIndex = 54;
            FortuneTallerLabel.Visible = false;
            // 
            // FortuneTeller
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(946, 805);
            Controls.Add(FortuneTallerLabel);
            Controls.Add(MessagePictureBox);
            Controls.Add(pictureBox2);
            Controls.Add(back_button);
            Controls.Add(BalanceLabel);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FortuneTeller";
            Text = "FortuneTeller";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)MessagePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label BalanceLabel;
        private PictureBox pictureBox1;
        private Button back_button;
        private PictureBox pictureBox2;
        private PictureBox MessagePictureBox;
        private Label FortuneTallerLabel;
    }
}