namespace Prakt6_Kunin
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
            this.Letter1_Label = new System.Windows.Forms.Label();
            this.Letter2_Label = new System.Windows.Forms.Label();
            this.Letter3_Label = new System.Windows.Forms.Label();
            this.Letter1 = new System.Windows.Forms.TextBox();
            this.Letter2 = new System.Windows.Forms.TextBox();
            this.Letter3 = new System.Windows.Forms.TextBox();
            this.Box_For_p = new System.Windows.Forms.TextBox();
            this.Box_For_q = new System.Windows.Forms.TextBox();
            this.Type_p_Here = new System.Windows.Forms.Label();
            this.Type_q_Here = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Person1_textBox = new System.Windows.Forms.TextBox();
            this.Person2_textBox = new System.Windows.Forms.TextBox();
            this.Person3_textBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Letter1_Label
            // 
            this.Letter1_Label.AutoSize = true;
            this.Letter1_Label.Location = new System.Drawing.Point(46, 64);
            this.Letter1_Label.Name = "Letter1_Label";
            this.Letter1_Label.Size = new System.Drawing.Size(35, 13);
            this.Letter1_Label.TabIndex = 0;
            this.Letter1_Label.Text = "label1";
            // 
            // Letter2_Label
            // 
            this.Letter2_Label.AutoSize = true;
            this.Letter2_Label.Location = new System.Drawing.Point(200, 64);
            this.Letter2_Label.Name = "Letter2_Label";
            this.Letter2_Label.Size = new System.Drawing.Size(35, 13);
            this.Letter2_Label.TabIndex = 1;
            this.Letter2_Label.Text = "label2";
            // 
            // Letter3_Label
            // 
            this.Letter3_Label.AutoSize = true;
            this.Letter3_Label.Location = new System.Drawing.Point(339, 64);
            this.Letter3_Label.Name = "Letter3_Label";
            this.Letter3_Label.Size = new System.Drawing.Size(35, 13);
            this.Letter3_Label.TabIndex = 2;
            this.Letter3_Label.Text = "label3";
            // 
            // Letter1
            // 
            this.Letter1.Location = new System.Drawing.Point(17, 34);
            this.Letter1.MaxLength = 1;
            this.Letter1.Name = "Letter1";
            this.Letter1.Size = new System.Drawing.Size(100, 20);
            this.Letter1.TabIndex = 3;
            this.Letter1.TextChanged += new System.EventHandler(this.Letter1_TextChanged);
            // 
            // Letter2
            // 
            this.Letter2.Location = new System.Drawing.Point(168, 34);
            this.Letter2.MaxLength = 1;
            this.Letter2.Name = "Letter2";
            this.Letter2.Size = new System.Drawing.Size(100, 20);
            this.Letter2.TabIndex = 4;
            this.Letter2.TextChanged += new System.EventHandler(this.Letter2_TextChanged);
            // 
            // Letter3
            // 
            this.Letter3.Location = new System.Drawing.Point(307, 34);
            this.Letter3.MaxLength = 1;
            this.Letter3.Name = "Letter3";
            this.Letter3.Size = new System.Drawing.Size(100, 20);
            this.Letter3.TabIndex = 5;
            this.Letter3.TextChanged += new System.EventHandler(this.Letter3_TextChanged);
            // 
            // Box_For_p
            // 
            this.Box_For_p.Location = new System.Drawing.Point(156, 130);
            this.Box_For_p.MaxLength = 4;
            this.Box_For_p.Name = "Box_For_p";
            this.Box_For_p.Size = new System.Drawing.Size(100, 20);
            this.Box_For_p.TabIndex = 6;
            // 
            // Box_For_q
            // 
            this.Box_For_q.Location = new System.Drawing.Point(156, 157);
            this.Box_For_q.MaxLength = 4;
            this.Box_For_q.Name = "Box_For_q";
            this.Box_For_q.Size = new System.Drawing.Size(100, 20);
            this.Box_For_q.TabIndex = 7;
            // 
            // Type_p_Here
            // 
            this.Type_p_Here.AutoSize = true;
            this.Type_p_Here.Location = new System.Drawing.Point(36, 130);
            this.Type_p_Here.Name = "Type_p_Here";
            this.Type_p_Here.Size = new System.Drawing.Size(114, 13);
            this.Type_p_Here.TabIndex = 8;
            this.Type_p_Here.Text = "Введите значение p: ";
            // 
            // Type_q_Here
            // 
            this.Type_q_Here.AutoSize = true;
            this.Type_q_Here.Location = new System.Drawing.Point(36, 160);
            this.Type_q_Here.Name = "Type_q_Here";
            this.Type_q_Here.Size = new System.Drawing.Size(114, 13);
            this.Type_q_Here.TabIndex = 9;
            this.Type_q_Here.Text = "Введите значение q: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(390, 32);
            this.button1.TabIndex = 10;
            this.button1.Text = "Начать работу алгоритма";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Person1_textBox
            // 
            this.Person1_textBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Person1_textBox.Location = new System.Drawing.Point(3, 3);
            this.Person1_textBox.Multiline = true;
            this.Person1_textBox.Name = "Person1_textBox";
            this.Person1_textBox.ReadOnly = true;
            this.Person1_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Person1_textBox.Size = new System.Drawing.Size(127, 186);
            this.Person1_textBox.TabIndex = 11;
            // 
            // Person2_textBox
            // 
            this.Person2_textBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Person2_textBox.Location = new System.Drawing.Point(137, 3);
            this.Person2_textBox.Multiline = true;
            this.Person2_textBox.Name = "Person2_textBox";
            this.Person2_textBox.ReadOnly = true;
            this.Person2_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Person2_textBox.Size = new System.Drawing.Size(128, 185);
            this.Person2_textBox.TabIndex = 12;
            // 
            // Person3_textBox
            // 
            this.Person3_textBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Person3_textBox.Location = new System.Drawing.Point(271, 3);
            this.Person3_textBox.MaximumSize = new System.Drawing.Size(127, 200);
            this.Person3_textBox.Multiline = true;
            this.Person3_textBox.Name = "Person3_textBox";
            this.Person3_textBox.ReadOnly = true;
            this.Person3_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Person3_textBox.Size = new System.Drawing.Size(119, 186);
            this.Person3_textBox.TabIndex = 13;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel1.Controls.Add(this.Person1_textBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Person3_textBox, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Person2_textBox, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(17, 228);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(393, 192);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 472);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 536);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 630);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Type_q_Here);
            this.Controls.Add(this.Type_p_Here);
            this.Controls.Add(this.Box_For_q);
            this.Controls.Add(this.Box_For_p);
            this.Controls.Add(this.Letter3);
            this.Controls.Add(this.Letter2);
            this.Controls.Add(this.Letter1);
            this.Controls.Add(this.Letter3_Label);
            this.Controls.Add(this.Letter2_Label);
            this.Controls.Add(this.Letter1_Label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Letter1_Label;
        private System.Windows.Forms.Label Letter2_Label;
        private System.Windows.Forms.Label Letter3_Label;
        private System.Windows.Forms.TextBox Letter1;
        private System.Windows.Forms.TextBox Letter2;
        private System.Windows.Forms.TextBox Letter3;
        private System.Windows.Forms.TextBox Box_For_p;
        private System.Windows.Forms.TextBox Box_For_q;
        private System.Windows.Forms.Label Type_p_Here;
        private System.Windows.Forms.Label Type_q_Here;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Person1_textBox;
        private System.Windows.Forms.TextBox Person2_textBox;
        private System.Windows.Forms.TextBox Person3_textBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

