﻿namespace Carpathian_star
{
    partial class AccForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Login_textBox = new TextBox();
            Password_textBox = new TextBox();
            Enter = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Pixeled", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.OliveDrab;
            label1.Location = new Point(190, -6);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(335, 112);
            label1.TabIndex = 0;
            label1.Text = "Вітання!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Pixeled", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.Olive;
            label2.Location = new Point(281, 126);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(174, 79);
            label2.TabIndex = 1;
            label2.Text = "Логін:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Pixeled", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.Olive;
            label3.Location = new Point(259, 315);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(219, 79);
            label3.TabIndex = 2;
            label3.Text = "Пароль:";
            // 
            // Login_textBox
            // 
            Login_textBox.Font = new Font("Pixeled", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Login_textBox.ForeColor = Color.OliveDrab;
            Login_textBox.Location = new Point(190, 215);
            Login_textBox.Margin = new Padding(4);
            Login_textBox.Name = "Login_textBox";
            Login_textBox.Size = new Size(358, 68);
            Login_textBox.TabIndex = 3;
            // 
            // Password_textBox
            // 
            Password_textBox.Font = new Font("Pixeled", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Password_textBox.ForeColor = Color.OliveDrab;
            Password_textBox.Location = new Point(190, 405);
            Password_textBox.Margin = new Padding(4);
            Password_textBox.Name = "Password_textBox";
            Password_textBox.Size = new Size(358, 68);
            Password_textBox.TabIndex = 4;
            // 
            // Enter
            // 
            Enter.BackColor = Color.OliveDrab;
            Enter.Font = new Font("Pixeled", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Enter.ForeColor = SystemColors.ButtonHighlight;
            Enter.Location = new Point(228, 536);
            Enter.Margin = new Padding(4);
            Enter.Name = "Enter";
            Enter.Size = new Size(268, 110);
            Enter.TabIndex = 5;
            Enter.Text = "Увійти";
            Enter.UseVisualStyleBackColor = false;
            Enter.Click += Enter_Click;
            // 
            // AccForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(759, 661);
            Controls.Add(Enter);
            Controls.Add(Password_textBox);
            Controls.Add(Login_textBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "AccForm";
            Text = "AccForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox Login_textBox;
        private TextBox Password_textBox;
        private Button Enter;
    }
}