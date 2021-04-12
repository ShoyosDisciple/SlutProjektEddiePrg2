
namespace SlutProjekt
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.tabTickets = new System.Windows.Forms.TabPage();
            this.tabCustomers = new System.Windows.Forms.TabPage();
            this.tabFilms = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabHome);
            this.tabControl1.Controls.Add(this.tabTickets);
            this.tabControl1.Controls.Add(this.tabFilms);
            this.tabControl1.Controls.Add(this.tabCustomers);
            this.tabControl1.Enabled = false;
            this.tabControl1.Location = new System.Drawing.Point(12, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 435);
            this.tabControl1.TabIndex = 0;
            // 
            // tabHome
            // 
            this.tabHome.Location = new System.Drawing.Point(4, 22);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(768, 409);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Hem";
            this.tabHome.UseVisualStyleBackColor = true;
            // 
            // tabTickets
            // 
            this.tabTickets.Location = new System.Drawing.Point(4, 22);
            this.tabTickets.Name = "tabTickets";
            this.tabTickets.Padding = new System.Windows.Forms.Padding(3);
            this.tabTickets.Size = new System.Drawing.Size(768, 409);
            this.tabTickets.TabIndex = 1;
            this.tabTickets.Text = "Biljetter";
            this.tabTickets.UseVisualStyleBackColor = true;
            // 
            // tabCustomers
            // 
            this.tabCustomers.Location = new System.Drawing.Point(4, 22);
            this.tabCustomers.Name = "tabCustomers";
            this.tabCustomers.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustomers.Size = new System.Drawing.Size(768, 409);
            this.tabCustomers.TabIndex = 2;
            this.tabCustomers.Text = "Medlem";
            this.tabCustomers.UseVisualStyleBackColor = true;
            // 
            // tabFilms
            // 
            this.tabFilms.Location = new System.Drawing.Point(4, 22);
            this.tabFilms.Name = "tabFilms";
            this.tabFilms.Padding = new System.Windows.Forms.Padding(3);
            this.tabFilms.Size = new System.Drawing.Size(768, 409);
            this.tabFilms.TabIndex = 3;
            this.tabFilms.Text = "Filmer";
            this.tabFilms.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.TabPage tabTickets;
        private System.Windows.Forms.TabPage tabFilms;
        private System.Windows.Forms.TabPage tabCustomers;
    }
}

