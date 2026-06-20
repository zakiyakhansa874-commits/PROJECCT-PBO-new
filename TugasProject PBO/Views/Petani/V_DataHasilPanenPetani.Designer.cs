namespace TugasProject_PBO.Views.Petani
{
    partial class V_DataHasilPanenPetani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_DataHasilPanenPetani));
            BC_MenuBar8ini = new Panel();
            BC_MenuBar8 = new Panel();
            btLogout_8 = new Button();
            btKelolaHasilPanen_8 = new Button();
            btDashboard_8 = new Button();
            L_Petani8 = new Label();
            L_Username8 = new Label();
            G_Profil8 = new PictureBox();
            BC_Page8 = new Panel();
            BC_DataHasilPanenSaya8 = new Panel();
            DGV_InputHasilPanen8 = new DataGridView();
            Tanggal4 = new DataGridViewTextBoxColumn();
            Komoditas = new DataGridViewTextBoxColumn();
            BeratKotor = new DataGridViewTextBoxColumn();
            BeratBersih = new DataGridViewTextBoxColumn();
            Kualitas = new DataGridViewTextBoxColumn();
            Catatan = new DataGridViewTextBoxColumn();
            label6 = new Label();
            btInputBaru8 = new Button();
            G_InputHasilPetani = new PictureBox();
            J_InputHasilPanenPetani8 = new Label();
            BC_MenuBar8ini.SuspendLayout();
            BC_MenuBar8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)G_Profil8).BeginInit();
            BC_Page8.SuspendLayout();
            BC_DataHasilPanenSaya8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_InputHasilPanen8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)G_InputHasilPetani).BeginInit();
            SuspendLayout();
            // 
            // BC_MenuBar8ini
            // 
            BC_MenuBar8ini.BackColor = Color.DarkOliveGreen;
            BC_MenuBar8ini.BorderStyle = BorderStyle.Fixed3D;
            BC_MenuBar8ini.Controls.Add(BC_MenuBar8);
            BC_MenuBar8ini.Controls.Add(L_Petani8);
            BC_MenuBar8ini.Controls.Add(L_Username8);
            BC_MenuBar8ini.Controls.Add(G_Profil8);
            BC_MenuBar8ini.Location = new Point(-1, -1);
            BC_MenuBar8ini.Margin = new Padding(4);
            BC_MenuBar8ini.Name = "BC_MenuBar8ini";
            BC_MenuBar8ini.Size = new Size(255, 713);
            BC_MenuBar8ini.TabIndex = 1;
            // 
            // BC_MenuBar8
            // 
            BC_MenuBar8.BackColor = Color.Ivory;
            BC_MenuBar8.Controls.Add(btLogout_8);
            BC_MenuBar8.Controls.Add(btKelolaHasilPanen_8);
            BC_MenuBar8.Controls.Add(btDashboard_8);
            BC_MenuBar8.Location = new Point(-4, 64);
            BC_MenuBar8.Margin = new Padding(4);
            BC_MenuBar8.Name = "BC_MenuBar8";
            BC_MenuBar8.Size = new Size(239, 641);
            BC_MenuBar8.TabIndex = 0;
            // 
            // btLogout_8
            // 
            btLogout_8.BackColor = Color.DarkKhaki;
            btLogout_8.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btLogout_8.Location = new Point(-6, 576);
            btLogout_8.Margin = new Padding(4);
            btLogout_8.Name = "btLogout_8";
            btLogout_8.Size = new Size(250, 42);
            btLogout_8.TabIndex = 9;
            btLogout_8.Text = "Logout";
            btLogout_8.UseVisualStyleBackColor = true;
           
            // 
            // btKelolaHasilPanen_8
            // 
            btKelolaHasilPanen_8.BackColor = Color.DarkKhaki;
            btKelolaHasilPanen_8.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btKelolaHasilPanen_8.Location = new Point(-6, 95);
            btKelolaHasilPanen_8.Margin = new Padding(4);
            btKelolaHasilPanen_8.Name = "btKelolaHasilPanen_8";
            btKelolaHasilPanen_8.Size = new Size(250, 42);
            btKelolaHasilPanen_8.TabIndex = 3;
            btKelolaHasilPanen_8.Text = "Monitoring Stok";
            btKelolaHasilPanen_8.UseVisualStyleBackColor = false;
            btKelolaHasilPanen_8.Click += btKelolaHasilPanen_1_Click;
            // 
            // btDashboard_8
            // 
            btDashboard_8.BackColor = Color.DarkKhaki;
            btDashboard_8.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btDashboard_8.Location = new Point(-6, 39);
            btDashboard_8.Margin = new Padding(4);
            btDashboard_8.Name = "btDashboard_8";
            btDashboard_8.Size = new Size(250, 42);
            btDashboard_8.TabIndex = 2;
            btDashboard_8.Text = "Input Hasil Panen";
            btDashboard_8.UseVisualStyleBackColor = false;
            // 
            // L_Petani8
            // 
            L_Petani8.AutoSize = true;
            L_Petani8.BackColor = Color.DarkOliveGreen;
            L_Petani8.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            L_Petani8.ForeColor = SystemColors.ButtonHighlight;
            L_Petani8.Location = new Point(81, 30);
            L_Petani8.Margin = new Padding(4, 0, 4, 0);
            L_Petani8.Name = "L_Petani8";
            L_Petani8.Size = new Size(66, 26);
            L_Petani8.TabIndex = 0;
            L_Petani8.Text = "Petani";
            // 
            // L_Username8
            // 
            L_Username8.AutoSize = true;
            L_Username8.Font = new Font("Calibri", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            L_Username8.ForeColor = SystemColors.ButtonHighlight;
            L_Username8.Location = new Point(81, 5);
            L_Username8.Margin = new Padding(4, 0, 4, 0);
            L_Username8.Name = "L_Username8";
            L_Username8.Size = new Size(106, 27);
            L_Username8.TabIndex = 0;
            L_Username8.Text = "Username";
            // 
            // G_Profil8
            // 
            G_Profil8.BackColor = Color.Transparent;
            G_Profil8.BorderStyle = BorderStyle.FixedSingle;
            G_Profil8.Image = (Image)resources.GetObject("G_Profil8.Image");
            G_Profil8.InitialImage = null;
            G_Profil8.Location = new Point(25, 8);
            G_Profil8.Margin = new Padding(4);
            G_Profil8.Name = "G_Profil8";
            G_Profil8.Size = new Size(53, 51);
            G_Profil8.SizeMode = PictureBoxSizeMode.Zoom;
            G_Profil8.TabIndex = 0;
            G_Profil8.TabStop = false;
            // 
            // BC_Page8
            // 
            BC_Page8.BackColor = Color.Ivory;
            BC_Page8.Controls.Add(BC_DataHasilPanenSaya8);
            BC_Page8.Controls.Add(btInputBaru8);
            BC_Page8.Controls.Add(G_InputHasilPetani);
            BC_Page8.Controls.Add(J_InputHasilPanenPetani8);
            BC_Page8.Location = new Point(215, 0);
            BC_Page8.Margin = new Padding(4);
            BC_Page8.Name = "BC_Page8";
            BC_Page8.Size = new Size(1311, 724);
            BC_Page8.TabIndex = 2;
            // 
            // BC_DataHasilPanenSaya8
            // 
            BC_DataHasilPanenSaya8.BackColor = Color.SaddleBrown;
            BC_DataHasilPanenSaya8.Controls.Add(DGV_InputHasilPanen8);
            BC_DataHasilPanenSaya8.Controls.Add(label6);
            BC_DataHasilPanenSaya8.Location = new Point(44, 125);
            BC_DataHasilPanenSaya8.Margin = new Padding(4);
            BC_DataHasilPanenSaya8.Name = "BC_DataHasilPanenSaya8";
            BC_DataHasilPanenSaya8.Size = new Size(1215, 542);
            BC_DataHasilPanenSaya8.TabIndex = 11;
            // 
            // DGV_InputHasilPanen8
            // 
            DGV_InputHasilPanen8.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_InputHasilPanen8.BackgroundColor = SystemColors.ControlLightLight;
            DGV_InputHasilPanen8.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_InputHasilPanen8.Columns.AddRange(new DataGridViewColumn[] { Tanggal4, Komoditas, BeratKotor, BeratBersih, Kualitas, Catatan });
            DGV_InputHasilPanen8.Location = new Point(34, 29);
            DGV_InputHasilPanen8.Margin = new Padding(4);
            DGV_InputHasilPanen8.Name = "DGV_InputHasilPanen8";
            DGV_InputHasilPanen8.RowHeadersWidth = 51;
            DGV_InputHasilPanen8.Size = new Size(1145, 484);
            DGV_InputHasilPanen8.TabIndex = 3;
            DGV_InputHasilPanen8.CellContentClick += DGV_InputHasilPanen8_CellContentClick_1;
            // 
            // Tanggal4
            // 
            Tanggal4.HeaderText = "Tanggal ";
            Tanggal4.MinimumWidth = 6;
            Tanggal4.Name = "Tanggal4";
            // 
            // Komoditas
            // 
            Komoditas.HeaderText = "Komoditas";
            Komoditas.MinimumWidth = 6;
            Komoditas.Name = "Komoditas";
            // 
            // BeratKotor
            // 
            BeratKotor.HeaderText = "Berat Kotor (kg)";
            BeratKotor.MinimumWidth = 6;
            BeratKotor.Name = "BeratKotor";
            // 
            // BeratBersih
            // 
            BeratBersih.HeaderText = "Berat Bersih (kg)";
            BeratBersih.MinimumWidth = 6;
            BeratBersih.Name = "BeratBersih";
            // 
            // Kualitas
            // 
            Kualitas.HeaderText = "Kualitas";
            Kualitas.MinimumWidth = 6;
            Kualitas.Name = "Kualitas";
            // 
            // Catatan
            // 
            Catatan.HeaderText = "Catatan";
            Catatan.MinimumWidth = 6;
            Catatan.Name = "Catatan";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Ivory;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(322, 141);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(0, 30);
            label6.TabIndex = 1;
            // 
            // btInputBaru8
            // 
            btInputBaru8.BackColor = Color.Goldenrod;
            btInputBaru8.Location = new Point(1074, 72);
            btInputBaru8.Margin = new Padding(4);
            btInputBaru8.Name = "btInputBaru8";
            btInputBaru8.Size = new Size(145, 36);
            btInputBaru8.TabIndex = 2;
            btInputBaru8.Text = "➕ Input Baru";
            btInputBaru8.UseVisualStyleBackColor = false;
            btInputBaru8.Click += btInputBaru8_Click_1;
            // 
            // G_InputHasilPetani
            // 
            G_InputHasilPetani.BackColor = Color.Transparent;
            G_InputHasilPetani.Image = (Image)resources.GetObject("G_InputHasilPetani.Image");
            G_InputHasilPetani.Location = new Point(46, 32);
            G_InputHasilPetani.Margin = new Padding(4);
            G_InputHasilPetani.Name = "G_InputHasilPetani";
            G_InputHasilPetani.Size = new Size(91, 72);
            G_InputHasilPetani.SizeMode = PictureBoxSizeMode.Zoom;
            G_InputHasilPetani.TabIndex = 4;
            G_InputHasilPetani.TabStop = false;
            // 
            // J_InputHasilPanenPetani8
            // 
            J_InputHasilPanenPetani8.AutoSize = true;
            J_InputHasilPanenPetani8.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            J_InputHasilPanenPetani8.Location = new Point(128, 42);
            J_InputHasilPanenPetani8.Margin = new Padding(4, 0, 4, 0);
            J_InputHasilPanenPetani8.Name = "J_InputHasilPanenPetani8";
            J_InputHasilPanenPetani8.Size = new Size(406, 46);
            J_InputHasilPanenPetani8.TabIndex = 3;
            J_InputHasilPanenPetani8.Text = "Data Hasil Panen Petani";
            J_InputHasilPanenPetani8.Click += J_InputHasilPanenPetani8_Click;
            // 
            // V_DataHasilPanenPetani
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1529, 701);
            Controls.Add(BC_Page8);
            Controls.Add(BC_MenuBar8ini);
            Margin = new Padding(4);
            Name = "V_DataHasilPanenPetani";
            Text = "Form1";
            BC_MenuBar8ini.ResumeLayout(false);
            BC_MenuBar8ini.PerformLayout();
            BC_MenuBar8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)G_Profil8).EndInit();
            BC_Page8.ResumeLayout(false);
            BC_Page8.PerformLayout();
            BC_DataHasilPanenSaya8.ResumeLayout(false);
            BC_DataHasilPanenSaya8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_InputHasilPanen8).EndInit();
            ((System.ComponentModel.ISupportInitialize)G_InputHasilPetani).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel BC_MenuBar8ini;
        private Panel BC_MenuBar8;
        private Button btLogout_8;
        private Button btKelolaHasilPanen_8;
        private Button btDashboard_8;
        private Label L_Petani8;
        private Label L_Username8;
        private PictureBox G_Profil8;
        private Panel BC_Page8;
        private PictureBox G_InputHasilPetani;
        private Label J_InputHasilPanenPetani8;
        private Panel BC_DataHasilPanenSaya8;
        private Label label6;
        private DataGridView DGV_InputHasilPanen8;
        private Button btInputBaru8;
        private DataGridViewTextBoxColumn Tanggal4;
        private DataGridViewTextBoxColumn Komoditas;
        private DataGridViewTextBoxColumn BeratKotor;
        private DataGridViewTextBoxColumn BeratBersih;
        private DataGridViewTextBoxColumn Kualitas;
        private DataGridViewTextBoxColumn Catatan;
    }
}