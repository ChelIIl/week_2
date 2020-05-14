namespace Zadanie_5_F
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.A = new System.Windows.Forms.TextBox();
            this.B = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.H = new System.Windows.Forms.TextBox();
            this.aasd = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.res_t = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(33, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Таблица значений \r\n       функции";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "А =";
            // 
            // A
            // 
            this.A.Location = new System.Drawing.Point(55, 113);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(100, 20);
            this.A.TabIndex = 2;
            // 
            // B
            // 
            this.B.Location = new System.Drawing.Point(213, 113);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(100, 20);
            this.B.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(170, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "B =";
            // 
            // H
            // 
            this.H.Location = new System.Drawing.Point(118, 161);
            this.H.Name = "H";
            this.H.Size = new System.Drawing.Size(100, 20);
            this.H.TabIndex = 6;
            // 
            // aasd
            // 
            this.aasd.AutoSize = true;
            this.aasd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aasd.Location = new System.Drawing.Point(75, 161);
            this.aasd.Name = "aasd";
            this.aasd.Size = new System.Drawing.Size(50, 29);
            this.aasd.TabIndex = 5;
            this.aasd.Text = "H =";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 31);
            this.button1.TabIndex = 7;
            this.button1.Text = "Вычислить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // res_t
            // 
            this.res_t.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.res_t.Location = new System.Drawing.Point(12, 247);
            this.res_t.Multiline = true;
            this.res_t.Name = "res_t";
            this.res_t.ReadOnly = true;
            this.res_t.Size = new System.Drawing.Size(304, 153);
            this.res_t.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 412);
            this.Controls.Add(this.res_t);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.H);
            this.Controls.Add(this.aasd);
            this.Controls.Add(this.B);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.A);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox A;
        private System.Windows.Forms.TextBox B;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox H;
        private System.Windows.Forms.Label aasd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox res_t;
    }
}

