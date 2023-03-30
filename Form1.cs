using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace PWdB_lab3_Projekt

{
    public partial class Form1 : Form
    {
        string workingDirectory = Environment.CurrentDirectory;
        private string path;
        private BindingList<Book> books = new BindingList<Book>();
        private BindingList<Book> searchedBooks = new BindingList<Book>();
        public Form1()
        {
            InitializeComponent();
            form2 = new Form2(dataGridView1, books);
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = books;
            authorBox.Checked = true;
            path = Directory.GetParent(workingDirectory).Parent.Parent.FullName + "\\test.xml";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Add
            form2.setIndex();
            form2.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Remove
            if (dataGridView1 != null && dataGridView1.Rows.Count != 0)
            {
                deleteFromLists();
            }
            else
            {
                MessageBox.Show("Brak wierszy do usuniecia!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void deleteFromLists()
        {
            int indexToDelete = 0;
            int indexToDeleteFromSeach = 0;
            Boolean found1 = false;
            Boolean found2 = false; 
            int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];
            string IdToDelete = Convert.ToString(selectedRow.Cells["Id"].Value);
           
            foreach (Book cBook in books)
            {
                if (cBook.Id == IdToDelete)
                {
                    found1 = true;
                    break;
                }
                indexToDelete++;
            }
            foreach (Book cBook in searchedBooks)
            {
                if (cBook.Id == IdToDelete)
                {
                    found2 = true;
                    break;
                }
                indexToDeleteFromSeach++;
            }
            if (found1 )
            {
                books.RemoveAt(indexToDelete);
            }
            if(found2 )
            {
                searchedBooks.RemoveAt(indexToDeleteFromSeach);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var bookSerializer = new XmlSerializer(typeof(BindingList<Book>));
            //Load
            try
            {
                using (var reader = new StreamReader(path))
                {
                    BindingList<Book> deserializedBooks = (BindingList<Book>)bookSerializer.Deserialize(reader);
                    foreach (Book currentBook in deserializedBooks)
                    {
                        books.Add(currentBook);
                    }
                }
            }
            catch (Exception ex1)
            {
                throw new ApplicationException("Blad odczytu!", ex1);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var bookSerializer = new XmlSerializer(typeof(BindingList<Book>));

            //Save
            if (dataGridView1.Rows.Count > 0)
            {
                try
                {
                    using (FileStream fs = File.Open(path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                    {
                        lock (fs)
                        {
                            fs.SetLength(0);
                        }
                    }

                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(path, true))
                    {
                        bookSerializer.Serialize(file, books);
                    }
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Blad zapisu!", ex);
                }
            }
            else
            {
                MessageBox.Show("Brak danych do zapisu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            searchedBooks.Clear();
            if(String.IsNullOrEmpty(searchBar.Text.ToString()))
            {
                searchedBooks.Clear();
                dataGridView1.DataSource = books;
                return;
            }

            if (titleBox.Checked)
            {
                foreach(Book currentBook in books)
                {
                    if(currentBook.Tytu³.ToLower().Contains(searchBar.Text.ToString().ToLower()))
                    {
                        searchedBooks.Add(currentBook);
                    }
                }
            }
            else if (priceBox.Checked)
            {
                foreach (Book currentBook in books)
                {
                    if (currentBook.Cena.Contains(searchBar.Text.ToString()))
                    {
                        searchedBooks.Add(currentBook);
                    }
                }
            }
            else if (authorBox.Checked)
            {
                foreach (Book currentBook in books)
                {
                    if (currentBook.Autor.ToLower().Contains(searchBar.Text.ToString().ToLower()))
                    {
                        searchedBooks.Add(currentBook);
                    }
                }
            }
            dataGridView1.DataSource = searchedBooks;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            searchedBooks.Clear();
            dataGridView1.DataSource = books;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}