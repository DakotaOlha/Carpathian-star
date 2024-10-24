namespace Carpathian_star
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Pixeled", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.OldLace;
            label1.Location = new Point(152, -5);
            label1.Name = "label1";
            label1.Size = new Size(287, 95);
            label1.TabIndex = 0;
            label1.Text = "Вітання!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Pixeled", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.Linen;
            label2.Location = new Point(225, 101);
            label2.Name = "label2";
            label2.Size = new Size(143, 65);
            label2.TabIndex = 1;
            label2.Text = "Логін:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Pixeled", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.Linen;
            label3.Location = new Point(207, 252);
            label3.Name = "label3";
            label3.Size = new Size(180, 65);
            label3.TabIndex = 2;
            label3.Text = "Пароль:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Pixeled", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.ForeColor = Color.OliveDrab;
            textBox1.Location = new Point(152, 172);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(287, 58);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Pixeled", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox2.ForeColor = Color.OliveDrab;
            textBox2.Location = new Point(152, 324);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(287, 58);
            textBox2.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.Linen;
            button1.Font = new Font("Pixeled", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.OliveDrab;
            button1.Location = new Point(182, 429);
            button1.Name = "button1";
            button1.Size = new Size(214, 88);
            button1.TabIndex = 5;
            button1.Text = "Увійти";
            button1.UseVisualStyleBackColor = false;
            // 
            // AccForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OliveDrab;
            ClientSize = new Size(607, 529);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AccForm";
            Text = "AccForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
    }
}