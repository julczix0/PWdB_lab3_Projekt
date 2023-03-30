namespace PWdB_lab3_Projekt
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bookBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.priceBox = new System.Windows.Forms.RadioButton();
            this.authorBox = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.titleBox = new System.Windows.Forms.RadioButton();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 41;
            this.dataGridView1.Size = new System.Drawing.Size(2267, 563);
            this.dataGridView1.TabIndex = 0;
            // 
            // bookBindingSource1
            // 
            this.bookBindingSource1.DataSource = typeof(Book);
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataSource = typeof(Book);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(34, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 61);
            this.button1.TabIndex = 1;
            this.button1.Text = "Dodaj element";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(314, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(244, 61);
            this.button2.TabIndex = 2;
            this.button2.Text = "Usuń element";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(588, 42);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(244, 61);
            this.button3.TabIndex = 3;
            this.button3.Text = "Otworz z pliku";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(868, 42);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(250, 61);
            this.button4.TabIndex = 4;
            this.button4.Text = "Zapisz do pliku";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // search
            // 
            this.search.AutoSize = true;
            this.search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.search.Location = new System.Drawing.Point(1167, 3);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(250, 61);
            this.search.TabIndex = 6;
            this.search.Text = "Szukaj";
            this.search.UseVisualStyleBackColor = true;
            // 
            // searchBar
            // 
            this.searchBar.Location = new System.Drawing.Point(1441, 40);
            this.searchBar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(444, 39);
            this.searchBar.TabIndex = 14;
            // 
            // priceBox
            // 
            this.priceBox.AutoSize = true;
            this.priceBox.Location = new System.Drawing.Point(2051, 93);
            this.priceBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(99, 36);
            this.priceBox.TabIndex = 11;
            this.priceBox.TabStop = true;
            this.priceBox.Text = "Cena";
            this.priceBox.UseVisualStyleBackColor = true;
            // 
            // authorBox
            // 
            this.authorBox.AutoSize = true;
            this.authorBox.Location = new System.Drawing.Point(2051, 19);
            this.authorBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.authorBox.Name = "authorBox";
            this.authorBox.Size = new System.Drawing.Size(104, 36);
            this.authorBox.TabIndex = 10;
            this.authorBox.TabStop = true;
            this.authorBox.Text = "Autor";
            this.authorBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1898, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Szukaj po:";
            // 
            // titleBox
            // 
            this.titleBox.AutoSize = true;
            this.titleBox.Location = new System.Drawing.Point(2051, 58);
            this.titleBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(98, 36);
            this.titleBox.TabIndex = 15;
            this.titleBox.TabStop = true;
            this.titleBox.Text = "Tytuł";
            this.titleBox.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(1167, 70);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(250, 61);
            this.button5.TabIndex = 16;
            this.button5.Text = "Wyczyść wyszukiwanie";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2267, 702);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.authorBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Form2 form2;
        private BindingSource bookBindingSource;
        private BindingSource bookBindingSource1;
        private Button search;
        private TextBox searchBar;
        private RadioButton priceBox;
        private RadioButton authorBox;
        private Label label1;
        private RadioButton titleBox;
        private Button button5;
    }
}