namespace ThaiThanhNhat_buoi
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtjava = new TextBox();
            txtcss = new TextBox();
            txtketoan = new TextBox();
            txtmaketting = new TextBox();
            txtbanhang = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 123);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 0;
            label1.Text = "JAVA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 187);
            label2.Name = "label2";
            label2.Size = new Size(34, 20);
            label2.TabIndex = 1;
            label2.Text = "CSS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(447, 105);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 2;
            label3.Text = "KẾ TOÁN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(447, 163);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 3;
            label4.Text = "MAKETTING";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(447, 227);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 4;
            label5.Text = "BÁN HÀNG";
            // 
            // txtjava
            // 
            txtjava.Location = new Point(144, 116);
            txtjava.Name = "txtjava";
            txtjava.Size = new Size(133, 27);
            txtjava.TabIndex = 5;
            // 
            // txtcss
            // 
            txtcss.Location = new Point(144, 180);
            txtcss.Name = "txtcss";
            txtcss.Size = new Size(133, 27);
            txtcss.TabIndex = 6;
            // 
            // txtketoan
            // 
            txtketoan.Location = new Point(557, 98);
            txtketoan.Name = "txtketoan";
            txtketoan.Size = new Size(133, 27);
            txtketoan.TabIndex = 7;
            // 
            // txtmaketting
            // 
            txtmaketting.Location = new Point(557, 156);
            txtmaketting.Name = "txtmaketting";
            txtmaketting.Size = new Size(133, 27);
            txtmaketting.TabIndex = 8;
            // 
            // txtbanhang
            // 
            txtbanhang.Location = new Point(557, 220);
            txtbanhang.Name = "txtbanhang";
            txtbanhang.Size = new Size(133, 27);
            txtbanhang.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(161, 227);
            button1.Name = "button1";
            button1.Size = new Size(95, 29);
            button1.TabIndex = 10;
            button1.Text = "SINHVIENIT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(569, 271);
            button2.Name = "button2";
            button2.Size = new Size(110, 29);
            button2.TabIndex = 11;
            button2.Text = "SINHVIENBIZ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtbanhang);
            Controls.Add(txtmaketting);
            Controls.Add(txtketoan);
            Controls.Add(txtcss);
            Controls.Add(txtjava);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtjava;
        private TextBox txtcss;
        private TextBox txtketoan;
        private TextBox txtmaketting;
        private TextBox txtbanhang;
        private Button button1;
        private Button button2;
    }
}
