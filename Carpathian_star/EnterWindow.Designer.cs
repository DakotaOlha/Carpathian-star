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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.AutoEllipsis = true;
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Pixeled", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.ForeColor = Color.LightGoldenrodYellow;
            button1.Location = new Point(729, 497);
            button1.Name = "button1";
            button1.Size = new Size(270, 115);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Pixeled", 30F);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(21, 21);
            label1.Name = "label1";
            label1.Size = new Size(529, 140);
            label1.TabIndex = 1;
            label1.Text = "Carpathian";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Pixeled", 30F);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(381, 115);
            label2.Name = "label2";
            label2.Size = new Size(259, 140);
            label2.TabIndex = 2;
            label2.Text = "star";
            // 
            // button2
            // 
            button2.Font = new Font("Pixeled", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button2.Location = new Point(965, 12);
            button2.Name = "button2";
            button2.Size = new Size(51, 52);
            button2.TabIndex = 3;
            button2.Text = "P";
            button2.TextAlign = ContentAlignment.TopRight;
            button2.UseVisualStyleBackColor = true;
            // 
            // EnterWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1041, 643);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EnterWindow";
            Text = "EnterWindow";
            Load += EnterWindow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Button button2;
    }
}