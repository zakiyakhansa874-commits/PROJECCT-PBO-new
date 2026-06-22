namespace TugasProject_PBO.Views.Admin
{
    partial class V_KelolaGudang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_KelolaGudang));
            BC_MenuBar3ini = new Panel();
            BC_MenuBar3 = new Panel();
            btLogout3 = new Button();
            btLaporanInventori3 = new Button();
            btMonitoringStok3 = new Button();
            btStokKeluar3 = new Button();
            btKelolaGudang3 = new Button();
            btStokMasuk3 = new Button();
            btKelolaHasilPanen3 = new Button();
            btDashboard3 = new Button();
            L_Role = new Label();
            L_Username = new Label();
            G_Profil = new PictureBox();
            BC_Page3 = new Panel();
            P_DGV3 = new Panel();
            DGV_KelolaGudang3 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            NamaGudang = new DataGridViewTextBoxColumn();
            Lokasi = new DataGridViewTextBoxColumn();
            Kapasitas = new DataGridViewTextBoxColumn();
            StokSaatIni = new DataGridViewTextBoxColumn();
            Terisi = new DataGridViewTextBoxColumn();
            btHapus3 = new Button();
            btEdit3 = new Button();
            btTambah3 = new Button();
            G_KelolaGudang3 = new PictureBox();
            J_KelolaGudang3 = new Label();
            BC_MenuBar3ini.SuspendLayout();
            BC_MenuBar3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)G_Profil).BeginInit();
            BC_Page3.SuspendLayout();
            P_DGV3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_KelolaGudang3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)G_KelolaGudang3).BeginInit();
            SuspendLayout();
            // 
            // BC_MenuBar3ini
            // 
            BC_MenuBar3ini.BackColor = Color.DarkOliveGreen;
            BC_MenuBar3ini.BorderStyle = BorderStyle.Fixed3D;
            BC_MenuBar3ini.Controls.Add(BC_MenuBar3);
            BC_MenuBar3ini.Controls.Add(L_Role);
            BC_MenuBar3ini.Controls.Add(L_Username);
            BC_MenuBar3ini.Controls.Add(G_Profil);
            BC_MenuBar3ini.Location = new Point(-1, 0);
            BC_MenuBar3ini.Name = "BC_MenuBar3ini";
            BC_MenuBar3ini.Size = new Size(205, 571);
            BC_MenuBar3ini.TabIndex = 1;
            BC_MenuBar3ini.Paint += BC_MenuBar_Paint3;
            // 
            // BC_MenuBar3
            // 
            BC_MenuBar3.BackColor = Color.Ivory;
            BC_MenuBar3.Controls.Add(btLogout3);
            BC_MenuBar3.Controls.Add(btLaporanInventori3);
            BC_MenuBar3.Controls.Add(btMonitoringStok3);
            BC_MenuBar3.Controls.Add(btStokKeluar3);
            BC_MenuBar3.Controls.Add(btKelolaGudang3);
            BC_MenuBar3.Controls.Add(btStokMasuk3);
            BC_MenuBar3.Controls.Add(btKelolaHasilPanen3);
            BC_MenuBar3.Controls.Add(btDashboard3);
            BC_MenuBar3.Location = new Point(-2, 51);
            BC_MenuBar3.Name = "BC_MenuBar3";
            BC_MenuBar3.Size = new Size(219, 513);
            BC_MenuBar3.TabIndex = 0;
            // 
            // btLogout3
            // 
            btLogout3.BackColor = Color.DarkKhaki;
            btLogout3.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btLogout3.Location = new Point(-5, 461);
            btLogout3.Name = "btLogout3";
            btLogout3.Size = new Size(200, 33);
            btLogout3.TabIndex = 9;
            btLogout3.Text = "Logout";
            btLogout3.UseVisualStyleBackColor = false;
            btLogout3.Click += btLogout3_Click;
            // 
            // btLaporanInventori3
            // 
            btLaporanInventori3.BackColor = Color.DarkKhaki;
            btLaporanInventori3.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btLaporanInventori3.Location = new Point(-5, 317);
            btLaporanInventori3.Name = "btLaporanInventori3";
            btLaporanInventori3.Size = new Size(200, 33);
            btLaporanInventori3.TabIndex = 8;
            btLaporanInventori3.Text = "Laporan Inventori";
            btLaporanInventori3.UseVisualStyleBackColor = false;
            btLaporanInventori3.Click += btLaporanInventori3_Click;
            // 
            // btMonitoringStok3
            // 
            btMonitoringStok3.BackColor = Color.DarkKhaki;
            btMonitoringStok3.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btMonitoringStok3.Location = new Point(-5, 268);
            btMonitoringStok3.Name = "btMonitoringStok3";
            btMonitoringStok3.Size = new Size(200, 33);
            btMonitoringStok3.TabIndex = 6;
            btMonitoringStok3.Text = "Monitoring Stok";
            btMonitoringStok3.UseVisualStyleBackColor = false;
            btMonitoringStok3.Click += btMonitoringStok3_Click;
            // 
            // btStokKeluar3
            // 
            btStokKeluar3.BackColor = Color.DarkKhaki;
            btStokKeluar3.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btStokKeluar3.Location = new Point(-5, 222);
            btStokKeluar3.Name = "btStokKeluar3";
            btStokKeluar3.Size = new Size(200, 33);
            btStokKeluar3.TabIndex = 5;
            btStokKeluar3.Text = "Stok Keluar";
            btStokKeluar3.UseVisualStyleBackColor = false;
            btStokKeluar3.Click += btStokKeluar3_Click;
            // 
            // btKelolaGudang3
            // 
            btKelolaGudang3.BackColor = Color.DarkKhaki;
            btKelolaGudang3.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btKelolaGudang3.Location = new Point(-5, 123);
            btKelolaGudang3.Name = "btKelolaGudang3";
            btKelolaGudang3.Size = new Size(200, 33);
            btKelolaGudang3.TabIndex = 5;
            btKelolaGudang3.Text = "Kelola Gudang";
            btKelolaGudang3.UseVisualStyleBackColor = false;
            btKelolaGudang3.Click += btKelolaGudang3_Click;
            // 
            // btStokMasuk3
            // 
            btStokMasuk3.BackColor = Color.DarkKhaki;
            btStokMasuk3.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btStokMasuk3.Location = new Point(-5, 173);
            btStokMasuk3.Name = "btStokMasuk3";
            btStokMasuk3.Size = new Size(200, 33);
            btStokMasuk3.TabIndex = 4;
            btStokMasuk3.Text = "Stok Masuk";
            btStokMasuk3.UseVisualStyleBackColor = false;
            btStokMasuk3.Click += btStokMasuk3_Click;
            // 
            // btKelolaHasilPanen3
            // 
            btKelolaHasilPanen3.BackColor = Color.DarkKhaki;
            btKelolaHasilPanen3.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btKelolaHasilPanen3.Location = new Point(-5, 76);
            btKelolaHasilPanen3.Name = "btKelolaHasilPanen3";
            btKelolaHasilPanen3.Size = new Size(200, 33);
            btKelolaHasilPanen3.TabIndex = 3;
            btKelolaHasilPanen3.Text = "Kelola Hasil Panen";
            btKelolaHasilPanen3.UseVisualStyleBackColor = false;
            btKelolaHasilPanen3.Click += btKelolaHasilPanen3_Click;
            // 
            // btDashboard3
            // 
            btDashboard3.BackColor = Color.DarkKhaki;
            btDashboard3.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btDashboard3.Location = new Point(-5, 31);
            btDashboard3.Name = "btDashboard3";
            btDashboard3.Size = new Size(200, 33);
            btDashboard3.TabIndex = 2;
            btDashboard3.Text = "Dashboard";
            btDashboard3.UseVisualStyleBackColor = false;
            btDashboard3.Click += btDashboard3_Click;
            // 
            // L_Role
            // 
            L_Role.AutoSize = true;
            L_Role.BackColor = Color.DarkOliveGreen;
            L_Role.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            L_Role.ForeColor = SystemColors.ButtonHighlight;
            L_Role.Location = new Point(65, 24);
            L_Role.Name = "L_Role";
            L_Role.Size = new Size(40, 21);
            L_Role.TabIndex = 0;
            L_Role.Text = "Role";
            // 
            // L_Username
            // 
            L_Username.AutoSize = true;
            L_Username.Font = new Font("Calibri", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            L_Username.ForeColor = SystemColors.ButtonHighlight;
            L_Username.Location = new Point(65, 4);
            L_Username.Name = "L_Username";
            L_Username.Size = new Size(87, 22);
            L_Username.TabIndex = 0;
            L_Username.Text = "Username";
            // 
            // G_Profil
            // 
            G_Profil.BackColor = Color.Transparent;
            G_Profil.BorderStyle = BorderStyle.FixedSingle;
            G_Profil.Image = (Image)resources.GetObject("G_Profil.Image");
            G_Profil.InitialImage = null;
            G_Profil.Location = new Point(20, 6);
            G_Profil.Name = "G_Profil";
            G_Profil.Size = new Size(43, 41);
            G_Profil.SizeMode = PictureBoxSizeMode.Zoom;
            G_Profil.TabIndex = 0;
            G_Profil.TabStop = false;
            // 
            // BC_Page3
            // 
            BC_Page3.BackColor = Color.Ivory;
            BC_Page3.Controls.Add(P_DGV3);
            BC_Page3.Controls.Add(btHapus3);
            BC_Page3.Controls.Add(btEdit3);
            BC_Page3.Controls.Add(btTambah3);
            BC_Page3.Controls.Add(G_KelolaGudang3);
            BC_Page3.Controls.Add(J_KelolaGudang3);
            BC_Page3.Location = new Point(190, 0);
            BC_Page3.Name = "BC_Page3";
            BC_Page3.Size = new Size(1049, 579);
            BC_Page3.TabIndex = 2;
            BC_Page3.Paint += BC_Page3_Paint;
            // 
            // P_DGV3
            // 
            P_DGV3.BackColor = Color.SaddleBrown;
            P_DGV3.Controls.Add(DGV_KelolaGudang3);
            P_DGV3.Location = new Point(32, 108);
            P_DGV3.Name = "P_DGV3";
            P_DGV3.Size = new Size(972, 434);
            P_DGV3.TabIndex = 13;
            // 
            // DGV_KelolaGudang3
            // 
            DGV_KelolaGudang3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_KelolaGudang3.BackgroundColor = SystemColors.ControlLightLight;
            DGV_KelolaGudang3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_KelolaGudang3.Columns.AddRange(new DataGridViewColumn[] { ID, NamaGudang, Lokasi, Kapasitas, StokSaatIni, Terisi });
            DGV_KelolaGudang3.Location = new Point(29, 24);
            DGV_KelolaGudang3.Name = "DGV_KelolaGudang3";
            DGV_KelolaGudang3.RowHeadersWidth = 51;
            DGV_KelolaGudang3.Size = new Size(916, 385);
            DGV_KelolaGudang3.TabIndex = 0;
            DGV_KelolaGudang3.CellClick += DGV_KelolaGudang3_CellClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            // 
            // NamaGudang
            // 
            NamaGudang.HeaderText = "Nama Gudang";
            NamaGudang.MinimumWidth = 6;
            NamaGudang.Name = "NamaGudang";
            // 
            // Lokasi
            // 
            Lokasi.HeaderText = "Lokasi";
            Lokasi.MinimumWidth = 6;
            Lokasi.Name = "Lokasi";
            // 
            // Kapasitas
            // 
            Kapasitas.HeaderText = "Kapasitas (kg)";
            Kapasitas.MinimumWidth = 6;
            Kapasitas.Name = "Kapasitas";
            // 
            // StokSaatIni
            // 
            StokSaatIni.HeaderText = "Stok Saat Ini (kg)";
            StokSaatIni.MinimumWidth = 6;
            StokSaatIni.Name = "StokSaatIni";
            // 
            // Terisi
            // 
            Terisi.HeaderText = "Terisi";
            Terisi.MinimumWidth = 6;
            Terisi.Name = "Terisi";
            // 
            // btHapus3
            // 
            btHapus3.BackColor = Color.MediumSeaGreen;
            btHapus3.Location = new Point(876, 58);
            btHapus3.Name = "btHapus3";
            btHapus3.Size = new Size(94, 29);
            btHapus3.TabIndex = 12;
            btHapus3.Text = "🗑️ Hapus";
            btHapus3.UseVisualStyleBackColor = false;
            btHapus3.Click += btHapus3_Click;
            // 
            // btEdit3
            // 
            btEdit3.BackColor = Color.SandyBrown;
            btEdit3.Location = new Point(769, 58);
            btEdit3.Name = "btEdit3";
            btEdit3.Size = new Size(94, 29);
            btEdit3.TabIndex = 11;
            btEdit3.Text = "✏️ Edit";
            btEdit3.UseVisualStyleBackColor = false;
            btEdit3.Click += btEdit3_Click;
            // 
            // btTambah3
            // 
            btTambah3.BackColor = Color.Goldenrod;
            btTambah3.Location = new Point(663, 58);
            btTambah3.Name = "btTambah3";
            btTambah3.Size = new Size(94, 29);
            btTambah3.TabIndex = 10;
            btTambah3.Text = "➕Tambah";
            btTambah3.UseVisualStyleBackColor = false;
            btTambah3.Click += btTambah3_Click;
            // 
            // G_KelolaGudang3
            // 
            G_KelolaGudang3.BackColor = Color.Transparent;
            G_KelolaGudang3.Image = (Image)resources.GetObject("G_KelolaGudang3.Image");
            G_KelolaGudang3.Location = new Point(37, 26);
            G_KelolaGudang3.Name = "G_KelolaGudang3";
            G_KelolaGudang3.Size = new Size(73, 58);
            G_KelolaGudang3.SizeMode = PictureBoxSizeMode.Zoom;
            G_KelolaGudang3.TabIndex = 8;
            G_KelolaGudang3.TabStop = false;
            // 
            // J_KelolaGudang3
            // 
            J_KelolaGudang3.AutoSize = true;
            J_KelolaGudang3.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            J_KelolaGudang3.Location = new Point(102, 34);
            J_KelolaGudang3.Name = "J_KelolaGudang3";
            J_KelolaGudang3.Size = new Size(222, 39);
            J_KelolaGudang3.TabIndex = 7;
            J_KelolaGudang3.Text = "Kelola Gudang";
            J_KelolaGudang3.Click += J_KelolaGudang3_Click;
            // 
            // V_KelolaGudang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1223, 561);
            Controls.Add(BC_Page3);
            Controls.Add(BC_MenuBar3ini);
            Name = "V_KelolaGudang";
            Text = "Form1";
            BC_MenuBar3ini.ResumeLayout(false);
            BC_MenuBar3ini.PerformLayout();
            BC_MenuBar3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)G_Profil).EndInit();
            BC_Page3.ResumeLayout(false);
            BC_Page3.PerformLayout();
            P_DGV3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGV_KelolaGudang3).EndInit();
            ((System.ComponentModel.ISupportInitialize)G_KelolaGudang3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel BC_MenuBar3ini;
        private Panel BC_MenuBar3;
        private Button btLogout3;
        private Button btLaporanInventori3;
        private Button btMonitoringStok3;
        private Button btStokKeluar3;
        private Button btKelolaGudang3;
        private Button btStokMasuk3;
        private Button btKelolaHasilPanen3;
        private Button btDashboard3;
        private Label L_Role;
        private Label L_Username;
        private PictureBox G_Profil;
        private Panel BC_Page3;
        private PictureBox G_KelolaGudang3;
        private Label J_KelolaGudang3;
        private Panel BC_MenuBar_Paint;
        private Button btHapus3;
        private Button btEdit3;
        private Button btTambah3;
        private Panel P_DGV3;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NamaGudang;
        private DataGridViewTextBoxColumn Lokasi;
        private DataGridViewTextBoxColumn Kapasitas;
        private DataGridViewTextBoxColumn StokSaatIni;
        private DataGridViewTextBoxColumn Terisi;
        private DataGridView DGV_KelolaGudang3;
    }
}