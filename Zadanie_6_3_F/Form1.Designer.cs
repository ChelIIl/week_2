namespace Zadanie_6_3_F
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
            this.res = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.elem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.n_t = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.stepen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // res
            // 
            this.res.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.res.Location = new System.Drawing.Point(0, 437);
            this.res.Multiline = true;
            this.res.Name = "res";
            this.res.ReadOnly = true;
            this.res.Size = new System.Drawing.Size(379, 134);
            this.res.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(118, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "Результат";
            // 
            // elem
            // 
            this.elem.Location = new System.Drawing.Point(84, 245);
            this.elem.Name = "elem";
            this.elem.Size = new System.Drawing.Size(232, 20);
            this.elem.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(79, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 58);
            this.label3.TabIndex = 9;
            this.label3.Text = "Элементы массива\r\n          (через \',\')";
            // 
            // n_t
            // 
            this.n_t.Location = new System.Drawing.Point(217, 120);
            this.n_t.Name = "n_t";
            this.n_t.Size = new System.Drawing.Size(150, 20);
            this.n_t.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Размер массива:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 62);
            this.label1.TabIndex = 13;
            this.label1.Text = "Возведение матрицы \r\n          в степень";
            // 
            // stepen
            // 
            this.stepen.Location = new System.Drawing.Point(166, 298);
            this.stepen.Name = "stepen";
            this.stepen.Size = new System.Drawing.Size(150, 20);
            this.stepen.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(53, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 29);
            this.label5.TabIndex = 15;
            this.label5.Text = "Степень:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(133, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 38);
            this.button1.TabIndex = 17;
            this.button1.Text = "Найти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 571);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.stepen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.res);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.elem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.n_t);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox res;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox elem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox n_t;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox stepen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}

