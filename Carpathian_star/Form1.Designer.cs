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
            Exit = new Button();
            SuspendLayout();
            // 
            // Store1
            // 
            Store1.BackColor = Color.SeaGreen;
            Store1.ForeColor = SystemColors.ControlLight;
            Store1.Location = new Point(475, 245);
            Store1.Margin = new Padding(4);
            Store1.Name = "Store1";
            Store1.Size = new Size(25, 22);
            Store1.TabIndex = 0;
            Store1.UseVisualStyleBackColor = false;
            Store1.Click += Store1_Click;
            Store1.MouseEnter += button1_MouseEnter;
            Store1.MouseLeave += button1_MouseLeave;
            // 
            // Store2
            // 
            Store2.BackColor = Color.SeaGreen;
            Store2.Location = new Point(202, 439);
            Store2.Margin = new Padding(4);
            Store2.Name = "Store2";
            Store2.Size = new Size(25, 22);
            Store2.TabIndex = 1;
            Store2.UseVisualStyleBackColor = false;
            Store2.Click += Store2_Click;
            Store2.MouseEnter += Store2_MouseEnter;
            Store2.MouseLeave += Store2_MouseLeave;
            // 
            // Store3
            // 
            Store3.BackColor = Color.SeaGreen;
            Store3.Location = new Point(439, 444);
            Store3.Margin = new Padding(4);
            Store3.Name = "Store3";
            Store3.Size = new Size(25, 22);
            Store3.TabIndex = 2;
            Store3.UseVisualStyleBackColor = false;
            Store3.Click += Store3_Click;
            Store3.MouseEnter += Store3_MouseEnter;
            Store3.MouseLeave += Store3_MouseLeave;
            // 
            // Store4
            // 
            Store4.BackColor = Color.SeaGreen;
            Store4.Location = new Point(455, 705);
            Store4.Margin = new Padding(4);
            Store4.Name = "Store4";
            Store4.Size = new Size(25, 22);
            Store4.TabIndex = 3;
            Store4.UseVisualStyleBackColor = false;
            Store4.Click += Store4_Click;
            Store4.MouseEnter += Store4_MouseEnter;
            Store4.MouseLeave += Store4_MouseLeave;
            // 
            // Store5
            // 
            Store5.BackColor = Color.SeaGreen;
            Store5.Location = new Point(802, 715);
            Store5.Margin = new Padding(4);
            Store5.Name = "Store5";
            Store5.Size = new Size(25, 22);
            Store5.TabIndex = 4;
            Store5.UseVisualStyleBackColor = false;
            Store5.Click += Store5_Click;
            Store5.MouseEnter += Store5_MouseEnter;
            Store5.MouseLeave += Store5_MouseLeave;
            // 
            // Store6
            // 
            Store6.BackColor = Color.SeaGreen;
            Store6.Location = new Point(875, 559);
            Store6.Margin = new Padding(4);
            Store6.Name = "Store6";
            Store6.Size = new Size(25, 22);
            Store6.TabIndex = 5;
            Store6.UseVisualStyleBackColor = false;
            Store6.Click += Store6_Click;
            Store6.MouseEnter += Store6_MouseEnter;
            Store6.MouseLeave += Store6_MouseLeave;
            // 
            // Store7
            // 
            Store7.BackColor = Color.SeaGreen;
            Store7.Location = new Point(1009, 462);
            Store7.Margin = new Padding(4);
            Store7.Name = "Store7";
            Store7.Size = new Size(25, 22);
            Store7.TabIndex = 6;
            Store7.UseVisualStyleBackColor = false;
            Store7.Click += Store7_Click;
            Store7.MouseEnter += Store7_MouseEnter;
            Store7.MouseLeave += Store7_MouseLeave;
            // 
            // Store8
            // 
            Store8.BackColor = Color.SeaGreen;
            Store8.Location = new Point(875, 265);
            Store8.Margin = new Padding(4);
            Store8.Name = "Store8";
            Store8.Size = new Size(25, 22);
            Store8.TabIndex = 7;
            Store8.UseVisualStyleBackColor = false;
            Store8.Click += Store8_Click;
            Store8.MouseEnter += Store8_MouseEnter;
            Store8.MouseLeave += Store8_MouseLeave;
            // 
            // Exit
            // 
            Exit.BackColor = Color.Transparent;
            Exit.BackgroundImage = (Image)resources.GetObject("Exit.BackgroundImage");
            Exit.BackgroundImageLayout = ImageLayout.Stretch;
            Exit.FlatStyle = FlatStyle.Flat;
            Exit.Font = new Font("Pixeled", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Exit.Location = new Point(1209, 2);
            Exit.Margin = new Padding(4);
            Exit.Name = "Exit";
            Exit.Size = new Size(44, 41);
            Exit.TabIndex = 8;
            Exit.TextAlign = ContentAlignment.TopRight;
            Exit.UseVisualStyleBackColor = false;
            Exit.Click += Exit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1255, 970);
            Controls.Add(Exit);
            Controls.Add(Store8);
            Controls.Add(Store7);
            Controls.Add(Store6);
            Controls.Add(Store5);
            Controls.Add(Store4);
            Controls.Add(Store3);
            Controls.Add(Store2);
            Controls.Add(Store1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
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
        private Button Exit;
    }
}
