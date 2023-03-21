namespace PWdB_lab3_Projekt

{
    public partial class Form1 : Form
    {
        string workingDirectory = Environment.CurrentDirectory;
        private string path; 
        public Form1()
        {
            InitializeComponent();
            form2 = new Form2(dataGridView1);
            dataGridView1.AllowUserToAddRows = false;
            path = Directory.GetParent(workingDirectory).Parent.Parent.FullName + "\\test.csv";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("title", "Tytu³");
            dataGridView1.Columns.Add("author", "Autor");
            dataGridView1.Columns.Add("length", "Liczba stron");
            dataGridView1.Columns.Add("type", "Typ ok³adki");
            dataGridView1.Columns.Add("price", "Cena");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Add
            form2.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Remove
            if (dataGridView1 != null && dataGridView1.Rows.Count != 0) {
                int currentRow = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows.RemoveAt(currentRow);
            }
            else
            {
                MessageBox.Show("Brak wierszy do usuniecia!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Load
            try
            {
                var lines = File.ReadAllLines(path);
                foreach (string line in lines)
                {
                    var parts = line.Split(',');
                    if (parts.Length == 5)
                    {
                        int rowNumber = dataGridView1.Rows.Add();
                        dataGridView1.Rows[rowNumber].Cells[0].Value = parts[0];
                        dataGridView1.Rows[rowNumber].Cells[1].Value = parts[1];
                        dataGridView1.Rows[rowNumber].Cells[2].Value = parts[2];
                        dataGridView1.Rows[rowNumber].Cells[3].Value = parts[3];
                        dataGridView1.Rows[rowNumber].Cells[4].Value = parts[4];
                    }
                }
            }
            catch(Exception ex1)
            {
                throw new ApplicationException("Blad odczytu!", ex1);
            }
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Save
            if(dataGridView1.Rows.Count > 0)
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
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            file.WriteLine(row.Cells[0].Value.ToString() + "," + row.Cells[1].Value.ToString() + "," + row.Cells[2].Value.ToString() + "," + row.Cells[3].Value.ToString() + "," + row.Cells[4].Value.ToString());
                        }
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
    }
}