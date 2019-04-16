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
    public partial class Zira_Calc : Form
    {
        string path = "C:\\Users\\Cell_Idf\\Desktop\\Calc\\sitedb.txt";
        public string getSiteName(int cellID)
            
        {
            string line;
            StreamReader file = new StreamReader(path);
            while ((line = file.ReadLine()) != null)
            {
                string[] tokens = line.Split(',');
                if (cellID == int.Parse(tokens[1]))
                {
                    return tokens[0];
                }
            }
            file.Close();
            return "NONE";
        }
        public Zira_Calc()
        {
            InitializeComponent();
        }


        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Mibas_Calc_Click(object sender, EventArgs e)
        {

        }

  

        private void Calc_Button_Click(object sender, EventArgs e)
        {
            int value = int.Parse(Mibas_Cellid_INT.Text);
            Sector_OUT.Text = (value % 256).ToString();
            int Sector = int.Parse(Sector_OUT.Text);
            Cell_id_OUT.Text = ((value - Sector) / 256).ToString();
            // compare whit cellid and DB
            Site_Name.Text = getSiteName(int.Parse(Cell_id_OUT.Text));
        }

        private void PCIClac(object sender, EventArgs e)
        {
            SubCellid.ForeColor = Color.Black;
            PciOutput.ForeColor = Color.Black;
            CellidGrop.ForeColor = Color.Black;
            if (PciOutput.Text == "" && CellidGrop.Text != "" && SubCellid.Text != "")
            {
                int value_cellid = int.Parse(CellidGrop.Text);
                int value_subcell = int.Parse(SubCellid.Text);
                PciOutput.Text = ((3 * value_cellid) + value_subcell).ToString();
                PciOutput.ForeColor = Color.Red;
            }
            else if (CellidGrop.Text == "" && PciOutput.Text != "" && SubCellid.Text != "")
            {
                int value1 = int.Parse(PciOutput.Text);
                int value2 = int.Parse(SubCellid.Text);
                if ((value1 - value2) % 3 != 0)
                {
                    MessageBox.Show("Invalid Parameter - PCI/Subcell");
                }
                else
                {
                    CellidGrop.Text = ((value1 - value2) / 3).ToString();
                    CellidGrop.ForeColor = Color.Red;
                }
            }
            else if (SubCellid.Text == "" && PciOutput.Text != "" && CellidGrop.Text != "")
            {
                int value1 = int.Parse(PciOutput.Text);
                int value2 = int.Parse(CellidGrop.Text);
                SubCellid.Text = (value1 - (value2 * 3)).ToString();
                SubCellid.ForeColor = Color.Red;
            }
            else
            {
                MessageBox.Show("Invalid Parameter Count");
            }
        }

        private void Add_New_Site(object sender, EventArgs e)
        {
            var addsitefrm = new Add_Site(); // connect to add win 
            addsitefrm.Show();
            

        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void PCI_Add_Click(object sender, EventArgs e)
        {
            var addsitefrm = new Add_PCI(); // connect to ADD PCI win 
            addsitefrm.Show();
        }

        private void PCI_button_Click(object sender, EventArgs e)
        {
            var addsitefrm = new PCI_TAB(); // connect to PCI TAB win 
            addsitefrm.Show();
        }
    }
}
