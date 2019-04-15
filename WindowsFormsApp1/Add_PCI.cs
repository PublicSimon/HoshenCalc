using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Add_PCI : Form
    {
        public Add_PCI()
        {
            InitializeComponent();
        }

        private void Add_PCI_Load(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_PCI_Button_Click(object sender, EventArgs e)
        {
            string path = "C:\\Users\\Cell_Idf\\Desktop\\Calc\\PCI_db.txt";
            using (StreamWriter sw = new StreamWriter (File.Open(path, System.IO.FileMode.Append)))
            {
                sw.WriteLine(Name_Site_INT.Text + "," + cell_id_INT.Text + "," + PCI_S1_INT.Text + "," + PCI_S2_INT.Text + "," + PCI_S3_INT.Text);
                sw.Close();
            }
            MessageBox.Show("Your PCI is adding");
        }
    }
}
