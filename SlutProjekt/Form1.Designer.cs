
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl = new System.Windows.Forms.Label();
            this.tabTickets = new System.Windows.Forms.TabPage();
            this.tabFilms = new System.Windows.Forms.TabPage();
            this.tabCustomers = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabAdmin = new System.Windows.Forms.TabPage();
            this.dataGridAdmin = new System.Windows.Forms.DataGridView();
            this.Regisor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Premiar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Originalsprak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pris = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Omsattning = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbxRegisor = new System.Windows.Forms.TextBox();
            this.tbxTitel = new System.Windows.Forms.TextBox();
            this.tbxGenre = new System.Windows.Forms.TextBox();
            this.tbxPris = new System.Windows.Forms.TextBox();
            this.tbxSprak = new System.Windows.Forms.TextBox();
            this.tbxOmsattning = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRegistreraFilm = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.DateTimePremiar = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabHome.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabHome);
            this.tabControl1.Controls.Add(this.tabTickets);
            this.tabControl1.Controls.Add(this.tabFilms);
            this.tabControl1.Controls.Add(this.tabCustomers);
            this.tabControl1.Controls.Add(this.tabAdmin);
            this.tabControl1.Enabled = false;
            this.tabControl1.Location = new System.Drawing.Point(12, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 435);
            this.tabControl1.TabIndex = 0;
            // 
            // tabHome
            // 
            this.tabHome.Controls.Add(this.groupBox2);
            this.tabHome.Controls.Add(this.groupBox1);
            this.tabHome.Controls.Add(this.lbl);
            this.tabHome.Location = new System.Drawing.Point(4, 22);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(768, 409);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Hem";
            this.tabHome.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(53, 222);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(683, 150);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Populära filmer";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(53, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(683, 138);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nya Filmer";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Paytone One", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(182, 3);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(385, 59);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "ACE STAR BIOGRAF";
            this.lbl.Click += new System.EventHandler(this.lbl_Click);
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
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tabAdmin
            // 
            this.tabAdmin.Controls.Add(this.btnRefresh);
            this.tabAdmin.Controls.Add(this.label8);
            this.tabAdmin.Controls.Add(this.DateTimePremiar);
            this.tabAdmin.Controls.Add(this.label7);
            this.tabAdmin.Controls.Add(this.btnRegistreraFilm);
            this.tabAdmin.Controls.Add(this.label6);
            this.tabAdmin.Controls.Add(this.label5);
            this.tabAdmin.Controls.Add(this.label4);
            this.tabAdmin.Controls.Add(this.label3);
            this.tabAdmin.Controls.Add(this.label2);
            this.tabAdmin.Controls.Add(this.label1);
            this.tabAdmin.Controls.Add(this.tbxOmsattning);
            this.tabAdmin.Controls.Add(this.tbxSprak);
            this.tabAdmin.Controls.Add(this.tbxPris);
            this.tabAdmin.Controls.Add(this.tbxGenre);
            this.tabAdmin.Controls.Add(this.tbxTitel);
            this.tabAdmin.Controls.Add(this.tbxRegisor);
            this.tabAdmin.Controls.Add(this.dataGridAdmin);
            this.tabAdmin.Location = new System.Drawing.Point(4, 22);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdmin.Size = new System.Drawing.Size(768, 409);
            this.tabAdmin.TabIndex = 4;
            this.tabAdmin.Text = "Admin";
            this.tabAdmin.UseVisualStyleBackColor = true;
            // 
            // dataGridAdmin
            // 
            this.dataGridAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Regisor,
            this.Titel,
            this.Genre,
            this.Premiar,
            this.Originalsprak,
            this.Pris,
            this.Omsattning});
            this.dataGridAdmin.Location = new System.Drawing.Point(17, 197);
            this.dataGridAdmin.Name = "dataGridAdmin";
            this.dataGridAdmin.Size = new System.Drawing.Size(725, 150);
            this.dataGridAdmin.TabIndex = 0;
            // 
            // Regisor
            // 
            this.Regisor.HeaderText = "Regisör";
            this.Regisor.Name = "Regisor";
            // 
            // Titel
            // 
            this.Titel.HeaderText = "Film Titel";
            this.Titel.Name = "Titel";
            // 
            // Genre
            // 
            this.Genre.HeaderText = "Genre";
            this.Genre.Name = "Genre";
            // 
            // Premiar
            // 
            this.Premiar.HeaderText = "Premiär";
            this.Premiar.Name = "Premiar";
            // 
            // Originalsprak
            // 
            this.Originalsprak.HeaderText = "Original Språk";
            this.Originalsprak.Name = "Originalsprak";
            // 
            // Pris
            // 
            this.Pris.HeaderText = "Biljett Pris";
            this.Pris.Name = "Pris";
            // 
            // Omsattning
            // 
            this.Omsattning.HeaderText = "Omsättning";
            this.Omsattning.Name = "Omsattning";
            // 
            // tbxRegisor
            // 
            this.tbxRegisor.Location = new System.Drawing.Point(64, 34);
            this.tbxRegisor.Name = "tbxRegisor";
            this.tbxRegisor.Size = new System.Drawing.Size(100, 20);
            this.tbxRegisor.TabIndex = 1;
            // 
            // tbxTitel
            // 
            this.tbxTitel.Location = new System.Drawing.Point(64, 61);
            this.tbxTitel.Name = "tbxTitel";
            this.tbxTitel.Size = new System.Drawing.Size(100, 20);
            this.tbxTitel.TabIndex = 2;
            // 
            // tbxGenre
            // 
            this.tbxGenre.Location = new System.Drawing.Point(64, 87);
            this.tbxGenre.Name = "tbxGenre";
            this.tbxGenre.Size = new System.Drawing.Size(100, 20);
            this.tbxGenre.TabIndex = 3;
            // 
            // tbxPris
            // 
            this.tbxPris.Location = new System.Drawing.Point(275, 34);
            this.tbxPris.Name = "tbxPris";
            this.tbxPris.Size = new System.Drawing.Size(100, 20);
            this.tbxPris.TabIndex = 4;
            // 
            // tbxSprak
            // 
            this.tbxSprak.Location = new System.Drawing.Point(275, 60);
            this.tbxSprak.Name = "tbxSprak";
            this.tbxSprak.Size = new System.Drawing.Size(100, 20);
            this.tbxSprak.TabIndex = 5;
            // 
            // tbxOmsattning
            // 
            this.tbxOmsattning.Location = new System.Drawing.Point(275, 86);
            this.tbxOmsattning.Name = "tbxOmsattning";
            this.tbxOmsattning.Size = new System.Drawing.Size(100, 20);
            this.tbxOmsattning.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Regisör";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Film Titel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Genre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Biljett Pris";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(187, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Original Språk";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(187, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 12;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnRegistreraFilm
            // 
            this.btnRegistreraFilm.Location = new System.Drawing.Point(432, 79);
            this.btnRegistreraFilm.Name = "btnRegistreraFilm";
            this.btnRegistreraFilm.Size = new System.Drawing.Size(114, 23);
            this.btnRegistreraFilm.TabIndex = 13;
            this.btnRegistreraFilm.Text = "Registrera Film ";
            this.btnRegistreraFilm.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(187, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Omsättning";
            // 
            // DateTimePremiar
            // 
            this.DateTimePremiar.Location = new System.Drawing.Point(432, 53);
            this.DateTimePremiar.Name = "DateTimePremiar";
            this.DateTimePremiar.Size = new System.Drawing.Size(200, 20);
            this.DateTimePremiar.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(429, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Premiär:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(18, 168);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 17;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(553, 19);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 99);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(414, 19);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 99);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(290, 19);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 99);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SlutProjekt.Properties.Resources.Demon_Slayer;
            this.pictureBox2.Location = new System.Drawing.Point(157, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 99);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SlutProjekt.Properties.Resources.Black_Widow;
            this.pictureBox1.InitialImage = global::SlutProjekt.Properties.Resources.Black_Widow;
            this.pictureBox1.Location = new System.Drawing.Point(33, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
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
            this.tabHome.ResumeLayout(false);
            this.tabHome.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabAdmin.ResumeLayout(false);
            this.tabAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.TabPage tabTickets;
        private System.Windows.Forms.TabPage tabFilms;
        private System.Windows.Forms.TabPage tabCustomers;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabPage tabAdmin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxOmsattning;
        private System.Windows.Forms.TextBox tbxSprak;
        private System.Windows.Forms.TextBox tbxPris;
        private System.Windows.Forms.TextBox tbxGenre;
        private System.Windows.Forms.TextBox tbxTitel;
        private System.Windows.Forms.TextBox tbxRegisor;
        private System.Windows.Forms.DataGridView dataGridAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Regisor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Premiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Originalsprak;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pris;
        private System.Windows.Forms.DataGridViewTextBoxColumn Omsattning;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker DateTimePremiar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRegistreraFilm;
        private System.Windows.Forms.Button btnRefresh;
    }
}

