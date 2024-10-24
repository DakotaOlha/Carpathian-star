namespace Carpathian_star
{
    partial class StoreInfo
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
            Owner = new Label();
            label3 = new Label();
            Product = new Label();
            label4 = new Label();
            WokHours = new Label();
            label5 = new Label();
            Reputaion = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Pixeled", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(52, 18);
            label1.Name = "label1";
            label1.Size = new Size(530, 65);
            label1.TabIndex = 0;
            label1.Text = "Інформація про магазин:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Pixeled", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 118);
            label2.Name = "label2";
            label2.Size = new Size(159, 51);
            label2.TabIndex = 1;
            label2.Text = "Власник:";
            // 
            // Owner
            // 
            Owner.AutoSize = true;
            Owner.Font = new Font("Pixeled", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Owner.Location = new Point(177, 118);
            Owner.Name = "Owner";
            Owner.Size = new Size(36, 51);
            Owner.TabIndex = 2;
            Owner.Text = "-";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Pixeled", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(12, 211);
            label3.Name = "label3";
            label3.Size = new Size(213, 51);
            label3.TabIndex = 3;
            label3.Text = "Тип товарів:";
            // 
            // Product
            // 
            Product.AutoSize = true;
            Product.Font = new Font("Pixeled", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Product.Location = new Point(231, 211);
            Product.Name = "Product";
            Product.Size = new Size(36, 51);
            Product.TabIndex = 4;
            Product.Text = "-";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Pixeled", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(12, 295);
            label4.Name = "label4";
            label4.Size = new Size(180, 51);
            label4.TabIndex = 5;
            label4.Text = "Робочі дні:";
            // 
            // WokHours
            // 
            WokHours.AutoSize = true;
            WokHours.Font = new Font("Pixeled", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            WokHours.Location = new Point(189, 295);
            WokHours.Name = "WokHours";
            WokHours.Size = new Size(36, 51);
            WokHours.TabIndex = 6;
            WokHours.Text = "-";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Pixeled", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(12, 387);
            label5.Name = "label5";
            label5.Size = new Size(188, 51);
            label5.TabIndex = 7;
            label5.Text = "Репутація:";
            // 
            // Reputaion
            // 
            Reputaion.AutoSize = true;
            Reputaion.Font = new Font("Pixeled", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Reputaion.Location = new Point(206, 387);
            Reputaion.Name = "Reputaion";
            Reputaion.Size = new Size(36, 51);
            Reputaion.TabIndex = 8;
            Reputaion.Text = "-";
            // 
            // StoreInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(687, 509);
            Controls.Add(Reputaion);
            Controls.Add(label5);
            Controls.Add(WokHours);
            Controls.Add(label4);
            Controls.Add(Product);
            Controls.Add(label3);
            Controls.Add(Owner);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StoreInfo";
            Text = "StoreInfo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label Owner;
        private Label label3;
        private Label Product;
        private Label label4;
        private Label WokHours;
        private Label label5;
        private Label Reputaion;
    }
}