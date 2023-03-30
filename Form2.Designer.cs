namespace PWdB_lab3_Projekt
{
    partial class Form2
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
            openFileDialog1 = new OpenFileDialog();
            groupBox1 = new GroupBox();
            type = new ComboBox();
            price = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            length = new TextBox();
            author = new TextBox();
            label2 = new Label();
            title = new TextBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(type);
            groupBox1.Controls.Add(price);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(length);
            groupBox1.Controls.Add(author);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(title);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(15, 8);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(363, 328);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dodaj element do listy";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // type
            // 
            type.FormattingEnabled = true;
            type.Items.AddRange(new object[] { "Twarda", "Miękka" });
            type.Location = new Point(104, 276);
            type.Name = "type";
            type.Size = new Size(151, 36);
            type.TabIndex = 11;
            type.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // price
            // 
            price.Location = new Point(174, 186);
            price.Margin = new Padding(2);
            price.Name = "price";
            price.Size = new Size(125, 34);
            price.TabIndex = 9;
            price.TextChanged += textBox1_TextChanged_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(174, 144);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(49, 23);
            label5.TabIndex = 8;
            label5.Text = "Cena";
            // 
            // label4
            // 
            label4.AllowDrop = true;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(68, 241);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(222, 23);
            label4.TabIndex = 6;
            label4.Text = "Typ okładki (twarda/miękka)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(174, 44);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(174, 23);
            label3.TabIndex = 5;
            label3.Text = "Długość (liczba stron)";
            // 
            // length
            // 
            length.Location = new Point(174, 84);
            length.Margin = new Padding(2);
            length.Name = "length";
            length.Size = new Size(125, 34);
            length.TabIndex = 4;
            length.TextChanged += textBox3_TextChanged;
            // 
            // author
            // 
            author.Location = new Point(18, 186);
            author.Margin = new Padding(2);
            author.Name = "author";
            author.Size = new Size(125, 34);
            author.TabIndex = 3;
            author.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(18, 144);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(53, 23);
            label2.TabIndex = 2;
            label2.Text = "Autor";
            // 
            // title
            // 
            title.Location = new Point(18, 84);
            title.Margin = new Padding(2);
            title.Name = "title";
            title.Size = new Size(125, 34);
            title.TabIndex = 1;
            title.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(18, 36);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(47, 23);
            label1.TabIndex = 0;
            label1.Text = "Tytuł";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(393, 100);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(92, 34);
            button1.TabIndex = 8;
            button1.Text = "Zapisz";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(393, 151);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(92, 33);
            button2.TabIndex = 9;
            button2.Text = "Wyjdź";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 356);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Margin = new Padding(2);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private GroupBox groupBox1;
        private Label label3;
        private TextBox length;
        private TextBox author;
        private Label label2;
        private TextBox title;
        private Label label1;
        private Label label4;
        private Button button1;
        private Button button2;
        private TextBox price;
        private Label label5;
        private ComboBox type;
    }
}