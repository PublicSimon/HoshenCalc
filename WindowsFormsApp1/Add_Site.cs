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
    public partial class Add_Site : Form
    {
        public Add_Site()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

         private void Add_Button_Click(object sender, EventArgs e)
        {
            string path = "C:\\Users\\Cell_Idf\\Desktop\\Calc\\sitedb.txt";
            using (StreamWriter sw = new StreamWriter(File.Open(path, System.IO.FileMode.Append)))
            {
                sw.WriteLine(siteNameTextbox.Text + "," + cellIdTextbox.Text);
                sw.Close();
            }
            MessageBox.Show("Your Site is adding");
            

        }

        private void Add_Site_Load(object sender, EventArgs e)
        {

        }
    }
}
