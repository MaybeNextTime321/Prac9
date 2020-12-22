namespace prac
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
            this.button1 = new System.Windows.Forms.Button();
            this.CountMork = new System.Windows.Forms.TextBox();
            this.CountKart = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddID = new System.Windows.Forms.ComboBox();
            this.InfoID = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 79);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавление новой записи";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CountMork
            // 
            this.CountMork.Location = new System.Drawing.Point(91, 115);
            this.CountMork.Name = "CountMork";
            this.CountMork.Size = new System.Drawing.Size(135, 20);
            this.CountMork.TabIndex = 2;
            // 
            // CountKart
            // 
            this.CountKart.Location = new System.Drawing.Point(92, 161);
            this.CountKart.Name = "CountKart";
            this.CountKart.Size = new System.Drawing.Size(135, 20);
            this.CountKart.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(301, 217);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 79);
            this.button2.TabIndex = 4;
            this.button2.Text = "Вывод инфо об указанном складе";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "id склада";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Морковь (кг)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Картофель (кг)";
            // 
            // AddID
            // 
            this.AddID.FormattingEnabled = true;
            this.AddID.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.AddID.Location = new System.Drawing.Point(92, 75);
            this.AddID.Name = "AddID";
            this.AddID.Size = new System.Drawing.Size(134, 21);
            this.AddID.TabIndex = 8;
            // 
            // InfoID
            // 
            this.InfoID.FormattingEnabled = true;
            this.InfoID.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.InfoID.Location = new System.Drawing.Point(301, 159);
            this.InfoID.Name = "InfoID";
            this.InfoID.Size = new System.Drawing.Size(186, 21);
            this.InfoID.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(530, 217);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 79);
            this.button3.TabIndex = 10;
            this.button3.Text = "Склады с меньшим количеством товара";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(530, 159);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 20);
            this.textBox1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 311);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.InfoID);
            this.Controls.Add(this.AddID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CountKart);
            this.Controls.Add(this.CountMork);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Овощной склад";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox CountMork;
        private System.Windows.Forms.TextBox CountKart;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox AddID;
        private System.Windows.Forms.ComboBox InfoID;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
    }
}

