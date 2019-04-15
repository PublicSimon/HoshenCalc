namespace WindowsFormsApp1
{
    partial class Add_Site
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
            this.Add_Site_Name = new System.Windows.Forms.Label();
            this.Add_Cell_ID = new System.Windows.Forms.Label();
            this.siteNameTextbox = new System.Windows.Forms.TextBox();
            this.cellIdTextbox = new System.Windows.Forms.TextBox();
            this.Add_Button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(544, 51);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hoshen Calculator";
            // 
            // Exit
            // 
            this.Exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(483, 0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(61, 51);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "X";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Add_Site_Name
            // 
            this.Add_Site_Name.AutoSize = true;
            this.Add_Site_Name.BackColor = System.Drawing.Color.Transparent;
            this.Add_Site_Name.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Site_Name.Location = new System.Drawing.Point(32, 133);
            this.Add_Site_Name.Name = "Add_Site_Name";
            this.Add_Site_Name.Size = new System.Drawing.Size(108, 25);
            this.Add_Site_Name.TabIndex = 4;
            this.Add_Site_Name.Text = "Site Name";
            this.Add_Site_Name.UseWaitCursor = true;
            // 
            // Add_Cell_ID
            // 
            this.Add_Cell_ID.AutoSize = true;
            this.Add_Cell_ID.BackColor = System.Drawing.Color.Transparent;
            this.Add_Cell_ID.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Cell_ID.Location = new System.Drawing.Point(32, 196);
            this.Add_Cell_ID.Name = "Add_Cell_ID";
            this.Add_Cell_ID.Size = new System.Drawing.Size(81, 25);
            this.Add_Cell_ID.TabIndex = 5;
            this.Add_Cell_ID.Text = " Cell ID";
            this.Add_Cell_ID.UseWaitCursor = true;
            // 
            // siteNameTextbox
            // 
            this.siteNameTextbox.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siteNameTextbox.Location = new System.Drawing.Point(155, 133);
            this.siteNameTextbox.Name = "siteNameTextbox";
            this.siteNameTextbox.Size = new System.Drawing.Size(112, 29);
            this.siteNameTextbox.TabIndex = 6;
            // 
            // cellIdTextbox
            // 
            this.cellIdTextbox.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellIdTextbox.Location = new System.Drawing.Point(155, 192);
            this.cellIdTextbox.Name = "cellIdTextbox";
            this.cellIdTextbox.Size = new System.Drawing.Size(112, 29);
            this.cellIdTextbox.TabIndex = 7;
            // 
            // Add_Button
            // 
            this.Add_Button.BackColor = System.Drawing.Color.Teal;
            this.Add_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Button.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Button.Location = new System.Drawing.Point(220, 274);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(98, 45);
            this.Add_Button.TabIndex = 12;
            this.Add_Button.Text = "הוסף";
            this.Add_Button.UseVisualStyleBackColor = false;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Add_Site
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 377);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.cellIdTextbox);
            this.Controls.Add(this.siteNameTextbox);
            this.Controls.Add(this.Add_Cell_ID);
            this.Controls.Add(this.Add_Site_Name);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_Site";
            this.Text = "Add_Site";
            this.Load += new System.EventHandler(this.Add_Site_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Add_Site_Name;
        private System.Windows.Forms.Label Add_Cell_ID;
        private System.Windows.Forms.TextBox siteNameTextbox;
        private System.Windows.Forms.TextBox cellIdTextbox;
        private System.Windows.Forms.Button Add_Button;
    }
}