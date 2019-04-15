namespace WindowsFormsApp1
{
    partial class Add_PCI
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
            this.Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Name_Site = new System.Windows.Forms.Label();
            this.cell_id = new System.Windows.Forms.Label();
            this.LABEL = new System.Windows.Forms.Label();
            this.LABEL3 = new System.Windows.Forms.Label();
            this.LABEL4 = new System.Windows.Forms.Label();
            this.Name_Site_INT = new System.Windows.Forms.RichTextBox();
            this.cell_id_INT = new System.Windows.Forms.RichTextBox();
            this.PCI_S1_INT = new System.Windows.Forms.RichTextBox();
            this.PCI_S2_INT = new System.Windows.Forms.RichTextBox();
            this.PCI_S3_INT = new System.Windows.Forms.RichTextBox();
            this.Add_PCI_Button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 51);
            this.panel1.TabIndex = 0;
            // 
            // Exit
            // 
            this.Exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(545, 0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 49);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "X";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hoshen Calculator";
            // 
            // Name_Site
            // 
            this.Name_Site.AutoSize = true;
            this.Name_Site.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_Site.Location = new System.Drawing.Point(52, 136);
            this.Name_Site.Name = "Name_Site";
            this.Name_Site.Size = new System.Drawing.Size(80, 25);
            this.Name_Site.TabIndex = 1;
            this.Name_Site.Text = "שם אתר ";
            // 
            // cell_id
            // 
            this.cell_id.AutoSize = true;
            this.cell_id.Font = new System.Drawing.Font("Georgia", 15.75F);
            this.cell_id.Location = new System.Drawing.Point(49, 185);
            this.cell_id.Name = "cell_id";
            this.cell_id.Size = new System.Drawing.Size(67, 25);
            this.cell_id.TabIndex = 2;
            this.cell_id.Text = "cell id";
            // 
            // LABEL
            // 
            this.LABEL.AutoSize = true;
            this.LABEL.Font = new System.Drawing.Font("Georgia", 15.75F);
            this.LABEL.Location = new System.Drawing.Point(52, 237);
            this.LABEL.Name = "LABEL";
            this.LABEL.Size = new System.Drawing.Size(81, 25);
            this.LABEL.TabIndex = 3;
            this.LABEL.Text = "PCI_S1";
            // 
            // LABEL3
            // 
            this.LABEL3.AutoSize = true;
            this.LABEL3.Font = new System.Drawing.Font("Georgia", 15.75F);
            this.LABEL3.Location = new System.Drawing.Point(49, 284);
            this.LABEL3.Name = "LABEL3";
            this.LABEL3.Size = new System.Drawing.Size(84, 25);
            this.LABEL3.TabIndex = 7;
            this.LABEL3.Text = "PCI_S2";
            // 
            // LABEL4
            // 
            this.LABEL4.AutoSize = true;
            this.LABEL4.Font = new System.Drawing.Font("Georgia", 15.75F);
            this.LABEL4.Location = new System.Drawing.Point(48, 336);
            this.LABEL4.Name = "LABEL4";
            this.LABEL4.Size = new System.Drawing.Size(84, 25);
            this.LABEL4.TabIndex = 9;
            this.LABEL4.Text = "PCI_S3";
            // 
            // Name_Site_INT
            // 
            this.Name_Site_INT.Location = new System.Drawing.Point(162, 136);
            this.Name_Site_INT.Name = "Name_Site_INT";
            this.Name_Site_INT.Size = new System.Drawing.Size(152, 30);
            this.Name_Site_INT.TabIndex = 10;
            this.Name_Site_INT.Text = "";
            // 
            // cell_id_INT
            // 
            this.cell_id_INT.Location = new System.Drawing.Point(162, 180);
            this.cell_id_INT.Name = "cell_id_INT";
            this.cell_id_INT.Size = new System.Drawing.Size(152, 30);
            this.cell_id_INT.TabIndex = 11;
            this.cell_id_INT.Text = "";
            // 
            // PCI_S1_INT
            // 
            this.PCI_S1_INT.Location = new System.Drawing.Point(162, 232);
            this.PCI_S1_INT.Name = "PCI_S1_INT";
            this.PCI_S1_INT.Size = new System.Drawing.Size(152, 30);
            this.PCI_S1_INT.TabIndex = 12;
            this.PCI_S1_INT.Text = "";
            // 
            // PCI_S2_INT
            // 
            this.PCI_S2_INT.Location = new System.Drawing.Point(162, 279);
            this.PCI_S2_INT.Name = "PCI_S2_INT";
            this.PCI_S2_INT.Size = new System.Drawing.Size(152, 30);
            this.PCI_S2_INT.TabIndex = 13;
            this.PCI_S2_INT.Text = "";
            // 
            // PCI_S3_INT
            // 
            this.PCI_S3_INT.Location = new System.Drawing.Point(162, 331);
            this.PCI_S3_INT.Name = "PCI_S3_INT";
            this.PCI_S3_INT.Size = new System.Drawing.Size(152, 30);
            this.PCI_S3_INT.TabIndex = 14;
            this.PCI_S3_INT.Text = "";
            // 
            // Add_PCI_Button
            // 
            this.Add_PCI_Button.BackColor = System.Drawing.Color.Teal;
            this.Add_PCI_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_PCI_Button.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_PCI_Button.Location = new System.Drawing.Point(280, 394);
            this.Add_PCI_Button.Name = "Add_PCI_Button";
            this.Add_PCI_Button.Size = new System.Drawing.Size(98, 45);
            this.Add_PCI_Button.TabIndex = 15;
            this.Add_PCI_Button.Text = "הוסף";
            this.Add_PCI_Button.UseVisualStyleBackColor = false;
            this.Add_PCI_Button.Click += new System.EventHandler(this.Add_PCI_Button_Click);
            // 
            // Add_PCI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 468);
            this.Controls.Add(this.Add_PCI_Button);
            this.Controls.Add(this.PCI_S3_INT);
            this.Controls.Add(this.PCI_S2_INT);
            this.Controls.Add(this.PCI_S1_INT);
            this.Controls.Add(this.cell_id_INT);
            this.Controls.Add(this.Name_Site_INT);
            this.Controls.Add(this.LABEL4);
            this.Controls.Add(this.LABEL3);
            this.Controls.Add(this.LABEL);
            this.Controls.Add(this.cell_id);
            this.Controls.Add(this.Name_Site);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_PCI";
            this.Text = "Add_PCI";
            this.Load += new System.EventHandler(this.Add_PCI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Name_Site;
        private System.Windows.Forms.Label cell_id;
        private System.Windows.Forms.Label LABEL;
        private System.Windows.Forms.Label LABEL3;
        private System.Windows.Forms.Label LABEL4;
        private System.Windows.Forms.RichTextBox Name_Site_INT;
        private System.Windows.Forms.RichTextBox cell_id_INT;
        private System.Windows.Forms.RichTextBox PCI_S1_INT;
        private System.Windows.Forms.RichTextBox PCI_S2_INT;
        private System.Windows.Forms.RichTextBox PCI_S3_INT;
        private System.Windows.Forms.Button Add_PCI_Button;
    }
}