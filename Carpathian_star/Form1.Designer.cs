namespace Carpathian_star
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Store1 = new Button();
            Store2 = new Button();
            Store3 = new Button();
            Store4 = new Button();
            Store5 = new Button();
            Store6 = new Button();
            Store7 = new Button();
            Store8 = new Button();
            SuspendLayout();
            // 
            // Store1
            // 
            Store1.BackColor = Color.SeaGreen;
            Store1.ForeColor = SystemColors.ControlLight;
            Store1.Location = new Point(380, 196);
            Store1.Name = "Store1";
            Store1.Size = new Size(20, 18);
            Store1.TabIndex = 0;
            Store1.UseVisualStyleBackColor = false;
            Store1.MouseEnter += button1_MouseEnter;
            Store1.MouseLeave += button1_MouseLeave;
            // 
            // Store2
            // 
            Store2.BackColor = Color.SeaGreen;
            Store2.Location = new Point(162, 351);
            Store2.Name = "Store2";
            Store2.Size = new Size(20, 18);
            Store2.TabIndex = 1;
            Store2.UseVisualStyleBackColor = false;
            // 
            // Store3
            // 
            Store3.BackColor = Color.SeaGreen;
            Store3.Location = new Point(351, 355);
            Store3.Name = "Store3";
            Store3.Size = new Size(20, 18);
            Store3.TabIndex = 2;
            Store3.UseVisualStyleBackColor = false;
            // 
            // Store4
            // 
            Store4.BackColor = Color.SeaGreen;
            Store4.Location = new Point(364, 564);
            Store4.Name = "Store4";
            Store4.Size = new Size(20, 18);
            Store4.TabIndex = 3;
            Store4.UseVisualStyleBackColor = false;
            // 
            // Store5
            // 
            Store5.BackColor = Color.SeaGreen;
            Store5.Location = new Point(642, 572);
            Store5.Name = "Store5";
            Store5.Size = new Size(20, 18);
            Store5.TabIndex = 4;
            Store5.UseVisualStyleBackColor = false;
            // 
            // Store6
            // 
            Store6.BackColor = Color.SeaGreen;
            Store6.Location = new Point(700, 447);
            Store6.Name = "Store6";
            Store6.Size = new Size(20, 18);
            Store6.TabIndex = 5;
            Store6.UseVisualStyleBackColor = false;
            // 
            // Store7
            // 
            Store7.BackColor = Color.SeaGreen;
            Store7.Location = new Point(807, 370);
            Store7.Name = "Store7";
            Store7.Size = new Size(20, 18);
            Store7.TabIndex = 6;
            Store7.UseVisualStyleBackColor = false;
            // 
            // Store8
            // 
            Store8.BackColor = Color.SeaGreen;
            Store8.Location = new Point(700, 212);
            Store8.Name = "Store8";
            Store8.Size = new Size(20, 18);
            Store8.TabIndex = 7;
            Store8.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1004, 776);
            Controls.Add(Store8);
            Controls.Add(Store7);
            Controls.Add(Store6);
            Controls.Add(Store5);
            Controls.Add(Store4);
            Controls.Add(Store3);
            Controls.Add(Store2);
            Controls.Add(Store1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button Store1;
        private Button Store2;
        private Button Store3;
        private Button Store4;
        private Button Store5;
        private Button Store6;
        private Button Store7;
        private Button Store8;
    }
}
