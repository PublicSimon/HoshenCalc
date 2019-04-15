using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class PCI_TAB : Form
    {
        string path = "C:\\Users\\Cell_Idf\\Desktop\\Calc\\PCI_db.txt";
        DataTable table = new DataTable();
        public void PopulateTable()
        {
            
            table.Clear();
            table.Columns.Add("Site Name");
            table.Columns.Add("CELL ID");
            table.Columns.Add("PCI Sector 1");
            table.Columns.Add("PCI Sector 2");
            table.Columns.Add("PCI Sector 3");
            string line;
            StreamReader file = new StreamReader(path);
            while ((line = file.ReadLine()) != null)
            {
                string[] tokens = line.Split(',');
                table.Rows.Add(tokens);
            }
            file.Close();
        }



        public PCI_TAB()
        {
            InitializeComponent();
            PopulateTable();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = table;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
        
}
