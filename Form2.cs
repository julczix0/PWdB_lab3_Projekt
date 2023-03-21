using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PWdB_lab3_Projekt
{
    public partial class Form2 : Form
    {
        private DataGridView dataGridView;

        public Form2(DataGridView dataGridView)
        {
            this.dataGridView = dataGridView;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

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
            //liczba stron
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
            int rowNumber = dataGridView.Rows.Add();
            if (this.title.Text.ToString().Equals("") && this.author.Text.ToString().Equals("") 
                && this.length.Text.ToString().Equals("") && this.type.Text.ToString().Equals("") 
                && this.price.Text.ToString().Equals(""))
            {
                MessageBox.Show("Należy wypelnic wszystkie pola tekstowe!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dataGridView.Rows[rowNumber].Cells[0].Value = this.title.Text.ToString(); 
            dataGridView.Rows[rowNumber].Cells[1].Value = this.author.Text.ToString(); 
            dataGridView.Rows[rowNumber].Cells[2].Value = this.length.Text.ToString();
            dataGridView.Rows[rowNumber].Cells[3].Value = this.type.Text.ToString();
            dataGridView.Rows[rowNumber].Cells[4].Value = this.price.Text.ToString();
            this.title.Text = ""; 
            this.author.Text = ""; 
            this.length.Text = "";
            this.type.Text = ""; 
            this.price.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
