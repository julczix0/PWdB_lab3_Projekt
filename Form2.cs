using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PWdB_lab3_Projekt
{
    public partial class Form2 : Form
    {
        private DataGridView dataGridView;
        private BindingList<Book> books;

        public Form2(DataGridView dataGridView, BindingList<Book> books)
        {
            this.dataGridView = dataGridView;
            this.books = books;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //tytuł
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(length.Text, "[^0-9]"))
            {
                MessageBox.Show("Wprowadź liczby!");
                length.Text = length.Text.Remove(length.Text.Length - 1);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //autor
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //typ okładki
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(title.Text.ToString()) || string.IsNullOrEmpty(author.Text.ToString())
                || string.IsNullOrEmpty(length.Text.ToString())
                || string.IsNullOrEmpty(price.Text.ToString()))
            {
                MessageBox.Show("Należy wypelnic wszystkie pola tekstowe!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            CoverType coverType;
            if (this.type.SelectedIndex == 0)
            {
                coverType = CoverType.Twarda;
            }
            else
            {
                coverType = CoverType.Miekka;
            }

            books.Add(new Book(author.Text.ToString(), title.Text.ToString(), price.Text.ToString(), length.Text.ToString(), coverType)); ;

            this.title.Text = "";
            this.author.Text = "";
            this.length.Text = "";
            this.price.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void type_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        public void setIndex()
        {
            type.SelectedIndex = 0;
        }
    }
}
