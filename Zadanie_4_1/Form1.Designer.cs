namespace Zadanie_4_1
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
            this.x_t = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.n_t = new System.Windows.Forms.TextBox();
            this.res_t = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(45, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вычисление цепной \r\n           дроби";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "X=";
            // 
            // x_t
            // 
            this.x_t.Location = new System.Drawing.Point(51, 98);
            this.x_t.Name = "x_t";
            this.x_t.Size = new System.Drawing.Size(100, 20);
            this.x_t.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(219, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "n=";
            // 
            // n_t
            // 
            this.n_t.Location = new System.Drawing.Point(256, 98);
            this.n_t.Name = "n_t";
            this.n_t.Size = new System.Drawing.Size(100, 20);
            this.n_t.TabIndex = 4;
            // 
            // res_t
            // 
            this.res_t.Location = new System.Drawing.Point(1, 179);
            this.res_t.Multiline = true;
            this.res_t.Name = "res_t";
            this.res_t.Size = new System.Drawing.Size(368, 36);
            this.res_t.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 26);
            this.button1.TabIndex = 6;
            this.button1.Text = "Вычислить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 215);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.res_t);
            this.Controls.Add(this.n_t);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.x_t);
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
        private System.Windows.Forms.TextBox x_t;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox n_t;
        private System.Windows.Forms.TextBox res_t;
        private System.Windows.Forms.Button button1;
    }
}

