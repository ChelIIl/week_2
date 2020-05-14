namespace Zadanie_6_1_F
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
            this.a = new System.Windows.Forms.TextBox();
            this.b = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.n_t = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.elem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.res = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.mas1 = new System.Windows.Forms.CheckBox();
            this.mas2 = new System.Windows.Forms.CheckBox();
            this.n_t2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(493, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "  Подсчитать количество элементов \r\nне попадающих в заданный интервал.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(39, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "От:";
            // 
            // a
            // 
            this.a.Location = new System.Drawing.Point(81, 105);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(100, 20);
            this.a.TabIndex = 2;
            // 
            // b
            // 
            this.b.Location = new System.Drawing.Point(370, 105);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(100, 20);
            this.b.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(328, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "До:";
            // 
            // n_t
            // 
            this.n_t.Location = new System.Drawing.Point(81, 210);
            this.n_t.Name = "n_t";
            this.n_t.Size = new System.Drawing.Size(100, 20);
            this.n_t.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(30, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 50);
            this.label4.TabIndex = 5;
            this.label4.Text = "Кол-во элементов \r\n       в массиве";
            // 
            // elem
            // 
            this.elem.Location = new System.Drawing.Point(370, 210);
            this.elem.Name = "elem";
            this.elem.Size = new System.Drawing.Size(100, 20);
            this.elem.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(318, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 50);
            this.label5.TabIndex = 7;
            this.label5.Text = "Элементы массива\r\n        (через \',\' )";
            // 
            // res
            // 
            this.res.Location = new System.Drawing.Point(298, 293);
            this.res.Name = "res";
            this.res.ReadOnly = true;
            this.res.Size = new System.Drawing.Size(114, 20);
            this.res.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(166, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 29);
            this.label6.TabIndex = 9;
            this.label6.Text = "Результат:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(228, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 33);
            this.button1.TabIndex = 11;
            this.button1.Text = "Посчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mas1
            // 
            this.mas1.AutoSize = true;
            this.mas1.Location = new System.Drawing.Point(131, 257);
            this.mas1.Name = "mas1";
            this.mas1.Size = new System.Drawing.Size(133, 17);
            this.mas1.TabIndex = 12;
            this.mas1.Text = "Одномерный массив";
            this.mas1.UseVisualStyleBackColor = true;
            this.mas1.CheckedChanged += new System.EventHandler(this.mas1_CheckedChanged);
            // 
            // mas2
            // 
            this.mas2.AutoSize = true;
            this.mas2.Location = new System.Drawing.Point(333, 257);
            this.mas2.Name = "mas2";
            this.mas2.Size = new System.Drawing.Size(127, 17);
            this.mas2.TabIndex = 13;
            this.mas2.Text = "Двумерный массив";
            this.mas2.UseVisualStyleBackColor = true;
            this.mas2.CheckedChanged += new System.EventHandler(this.mas2_CheckedChanged);
            // 
            // n_t2
            // 
            this.n_t2.Location = new System.Drawing.Point(187, 210);
            this.n_t2.Name = "n_t2";
            this.n_t2.Size = new System.Drawing.Size(100, 20);
            this.n_t2.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 376);
            this.Controls.Add(this.n_t2);
            this.Controls.Add(this.mas2);
            this.Controls.Add(this.mas1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.res);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.elem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.n_t);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.b);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.a);
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
        private System.Windows.Forms.TextBox a;
        private System.Windows.Forms.TextBox b;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox n_t;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox elem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox res;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox mas1;
        private System.Windows.Forms.CheckBox mas2;
        private System.Windows.Forms.TextBox n_t2;
    }
}

