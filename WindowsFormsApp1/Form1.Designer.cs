namespace WindowsFormsApp1
{
    partial class Zira_Calc
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.menu = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.PciOutput = new System.Windows.Forms.RichTextBox();
            this.SubCellid = new System.Windows.Forms.RichTextBox();
            this.CellidGrop = new System.Windows.Forms.RichTextBox();
            this.PCI = new System.Windows.Forms.Label();
            this.Sub_Cell_ID = new System.Windows.Forms.Label();
            this.Cell_ID_Grop = new System.Windows.Forms.Label();
            this.Mibas_Calc = new MetroFramework.Controls.MetroTabPage();
            this.richTextBox7 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.richTextBox6 = new System.Windows.Forms.RichTextBox();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.menu.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.Mibas_Calc.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(892, 55);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hoshen Calculator";
            // 
            // Exit
            // 
            this.Exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(817, 0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 55);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "X";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // menu
            // 
            this.menu.Controls.Add(this.metroTabPage1);
            this.menu.Controls.Add(this.Mibas_Calc);
            this.menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu.Location = new System.Drawing.Point(0, 55);
            this.menu.Name = "menu";
            this.menu.SelectedIndex = 0;
            this.menu.Size = new System.Drawing.Size(892, 552);
            this.menu.TabIndex = 1;
            this.menu.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.button2);
            this.metroTabPage1.Controls.Add(this.PciOutput);
            this.metroTabPage1.Controls.Add(this.SubCellid);
            this.metroTabPage1.Controls.Add(this.CellidGrop);
            this.metroTabPage1.Controls.Add(this.PCI);
            this.metroTabPage1.Controls.Add(this.Sub_Cell_ID);
            this.metroTabPage1.Controls.Add(this.Cell_ID_Grop);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(884, 510);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "PCI Calculator";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(384, 360);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 45);
            this.button2.TabIndex = 10;
            this.button2.Text = "חשב";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // PciOutput
            // 
            this.PciOutput.Location = new System.Drawing.Point(198, 221);
            this.PciOutput.Name = "PciOutput";
            this.PciOutput.Size = new System.Drawing.Size(157, 32);
            this.PciOutput.TabIndex = 7;
            this.PciOutput.Text = "";
            // 
            // SubCellid
            // 
            this.SubCellid.Location = new System.Drawing.Point(198, 157);
            this.SubCellid.Name = "SubCellid";
            this.SubCellid.Size = new System.Drawing.Size(157, 32);
            this.SubCellid.TabIndex = 6;
            this.SubCellid.Text = "";
            // 
            // CellidGrop
            // 
            this.CellidGrop.Location = new System.Drawing.Point(198, 103);
            this.CellidGrop.Name = "CellidGrop";
            this.CellidGrop.Size = new System.Drawing.Size(157, 32);
            this.CellidGrop.TabIndex = 5;
            this.CellidGrop.Text = "";
            this.CellidGrop.TextChanged += new System.EventHandler(this.CellidGrop_TextChanged);
            // 
            // PCI
            // 
            this.PCI.AutoSize = true;
            this.PCI.BackColor = System.Drawing.Color.Transparent;
            this.PCI.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PCI.Location = new System.Drawing.Point(46, 228);
            this.PCI.Name = "PCI";
            this.PCI.Size = new System.Drawing.Size(51, 25);
            this.PCI.TabIndex = 4;
            this.PCI.Text = "PCI ";
            // 
            // Sub_Cell_ID
            // 
            this.Sub_Cell_ID.AutoSize = true;
            this.Sub_Cell_ID.BackColor = System.Drawing.Color.Transparent;
            this.Sub_Cell_ID.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sub_Cell_ID.Location = new System.Drawing.Point(46, 166);
            this.Sub_Cell_ID.Name = "Sub_Cell_ID";
            this.Sub_Cell_ID.Size = new System.Drawing.Size(122, 25);
            this.Sub_Cell_ID.TabIndex = 3;
            this.Sub_Cell_ID.Text = "Sub Cell  ID";
            // 
            // Cell_ID_Grop
            // 
            this.Cell_ID_Grop.AutoSize = true;
            this.Cell_ID_Grop.BackColor = System.Drawing.Color.White;
            this.Cell_ID_Grop.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cell_ID_Grop.Location = new System.Drawing.Point(46, 110);
            this.Cell_ID_Grop.Name = "Cell_ID_Grop";
            this.Cell_ID_Grop.Size = new System.Drawing.Size(128, 25);
            this.Cell_ID_Grop.TabIndex = 2;
            this.Cell_ID_Grop.Text = "Cell ID Grop";
            this.Cell_ID_Grop.UseWaitCursor = true;
            this.Cell_ID_Grop.Click += new System.EventHandler(this.label2_Click);
            // 
            // Mibas_Calc
            // 
            this.Mibas_Calc.Controls.Add(this.richTextBox7);
            this.Mibas_Calc.Controls.Add(this.label2);
            this.Mibas_Calc.Controls.Add(this.button3);
            this.Mibas_Calc.Controls.Add(this.richTextBox6);
            this.Mibas_Calc.Controls.Add(this.richTextBox5);
            this.Mibas_Calc.Controls.Add(this.richTextBox4);
            this.Mibas_Calc.Controls.Add(this.label5);
            this.Mibas_Calc.Controls.Add(this.label4);
            this.Mibas_Calc.Controls.Add(this.label3);
            this.Mibas_Calc.HorizontalScrollbarBarColor = true;
            this.Mibas_Calc.HorizontalScrollbarHighlightOnWheel = false;
            this.Mibas_Calc.HorizontalScrollbarSize = 10;
            this.Mibas_Calc.Location = new System.Drawing.Point(4, 38);
            this.Mibas_Calc.Name = "Mibas_Calc";
            this.Mibas_Calc.Size = new System.Drawing.Size(884, 510);
            this.Mibas_Calc.TabIndex = 1;
            this.Mibas_Calc.Text = "Mibas Calculator";
            this.Mibas_Calc.VerticalScrollbarBarColor = true;
            this.Mibas_Calc.VerticalScrollbarHighlightOnWheel = false;
            this.Mibas_Calc.VerticalScrollbarSize = 10;
            this.Mibas_Calc.Click += new System.EventHandler(this.Mibas_Calc_Click);
            // 
            // richTextBox7
            // 
            this.richTextBox7.Location = new System.Drawing.Point(222, 282);
            this.richTextBox7.Name = "richTextBox7";
            this.richTextBox7.Size = new System.Drawing.Size(163, 32);
            this.richTextBox7.TabIndex = 13;
            this.richTextBox7.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Site Name";
            this.label2.UseWaitCursor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Teal;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(408, 387);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 45);
            this.button3.TabIndex = 11;
            this.button3.Text = "חשב";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // richTextBox6
            // 
            this.richTextBox6.Location = new System.Drawing.Point(222, 222);
            this.richTextBox6.Name = "richTextBox6";
            this.richTextBox6.Size = new System.Drawing.Size(163, 32);
            this.richTextBox6.TabIndex = 8;
            this.richTextBox6.Text = "";
            // 
            // richTextBox5
            // 
            this.richTextBox5.Location = new System.Drawing.Point(222, 164);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.Size = new System.Drawing.Size(163, 32);
            this.richTextBox5.TabIndex = 7;
            this.richTextBox5.Text = "";
            // 
            // richTextBox4
            // 
            this.richTextBox4.Location = new System.Drawing.Point(222, 102);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(163, 32);
            this.richTextBox4.TabIndex = 6;
            this.richTextBox4.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(69, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Site";
            this.label5.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sector";
            this.label4.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mibas Cell ID";
            this.label3.UseWaitCursor = true;
            // 
            // Zira_Calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 607);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Zira_Calc";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menu.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.Mibas_Calc.ResumeLayout(false);
            this.Mibas_Calc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Exit;
        private MetroFramework.Controls.MetroTabControl menu;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.Label Cell_ID_Grop;
        private MetroFramework.Controls.MetroTabPage Mibas_Calc;
        private System.Windows.Forms.Label PCI;
        private System.Windows.Forms.Label Sub_Cell_ID;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox PciOutput;
        private System.Windows.Forms.RichTextBox SubCellid;
        private System.Windows.Forms.RichTextBox CellidGrop;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox richTextBox6;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox7;
        private System.Windows.Forms.Label label2;
    }
}

