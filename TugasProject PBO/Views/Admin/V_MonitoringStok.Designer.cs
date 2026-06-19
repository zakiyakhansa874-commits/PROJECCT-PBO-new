namespace TugasProject_PBO.Views.Admin
{
    partial class V_MonitoringStok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_MonitoringStok));
            BC_MenuBar6ini = new Panel();
            BC_MenuBar1 = new Panel();
            btLogout_6 = new Button();
            btLaporanInventori_6 = new Button();
            btMonitoringStok_6 = new Button();
            btStokKeluar_6 = new Button();
            btKelolaGudang_6 = new Button();
            btStokMasuk_6 = new Button();
            btKelolaHasilPanen_6 = new Button();
            btDashboard_6 = new Button();
            L_Role6 = new Label();
            L_Username6 = new Label();
            G_Profil6 = new PictureBox();
            BC_ = new Panel();
            BC_penel6 = new Panel();
            L_KeluarTerakhir6 = new Label();
            L_MasukTerakhir6 = new Label();
            DGV_KeluarTerakhir6 = new DataGridView();
            DGV_MasukTerakhir = new DataGridView();
            DGV_RiwayatStok = new DataGridView();
            SJ_RiwayatStok6 = new Label();
            SJ_StatusGudang6 = new Label();
            BC_Page6 = new PictureBox();
            J_MonitoringStok6 = new Label();
            NamaGudang = new DataGridViewTextBoxColumn();
            Lokasi = new DataGridViewTextBoxColumn();
            Stokkg = new DataGridViewTextBoxColumn();
            Kapasitas = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            Tanggal = new DataGridViewTextBoxColumn();
            Gudang = new DataGridViewTextBoxColumn();
            Kg = new DataGridViewTextBoxColumn();
            Tanggal2 = new DataGridViewTextBoxColumn();
            Tujuan = new DataGridViewTextBoxColumn();
            Kg2 = new DataGridViewTextBoxColumn();
            BC_MenuBar6ini.SuspendLayout();
            BC_MenuBar1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)G_Profil6).BeginInit();
            BC_.SuspendLayout();
            BC_penel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_KeluarTerakhir6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGV_MasukTerakhir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGV_RiwayatStok).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BC_Page6).BeginInit();
            SuspendLayout();
            // 
            // BC_MenuBar6ini
            // 
            BC_MenuBar6ini.BackColor = Color.DarkOliveGreen;
            BC_MenuBar6ini.BorderStyle = BorderStyle.Fixed3D;
            BC_MenuBar6ini.Controls.Add(BC_MenuBar1);
            BC_MenuBar6ini.Controls.Add(L_Role6);
            BC_MenuBar6ini.Controls.Add(L_Username6);
            BC_MenuBar6ini.Controls.Add(G_Profil6);
            BC_MenuBar6ini.Location = new Point(-5, -1);
            BC_MenuBar6ini.Name = "BC_MenuBar6ini";
            BC_MenuBar6ini.Size = new Size(205, 571);
            BC_MenuBar6ini.TabIndex = 1;
            // 
            // BC_MenuBar1
            // 
            BC_MenuBar1.BackColor = Color.Ivory;
            BC_MenuBar1.Controls.Add(btLogout_6);
            BC_MenuBar1.Controls.Add(btLaporanInventori_6);
            BC_MenuBar1.Controls.Add(btMonitoringStok_6);
            BC_MenuBar1.Controls.Add(btStokKeluar_6);
            BC_MenuBar1.Controls.Add(btKelolaGudang_6);
            BC_MenuBar1.Controls.Add(btStokMasuk_6);
            BC_MenuBar1.Controls.Add(btKelolaHasilPanen_6);
            BC_MenuBar1.Controls.Add(btDashboard_6);
            BC_MenuBar1.Location = new Point(3, 51);
            BC_MenuBar1.Name = "BC_MenuBar1";
            BC_MenuBar1.Size = new Size(191, 513);
            BC_MenuBar1.TabIndex = 0;
            // 
            // btLogout_6
            // 
            btLogout_6.BackColor = Color.DarkKhaki;
            btLogout_6.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btLogout_6.Location = new Point(-5, 461);
            btLogout_6.Name = "btLogout_6";
            btLogout_6.Size = new Size(200, 34);
            btLogout_6.TabIndex = 9;
            btLogout_6.Text = "Logout";
            btLogout_6.UseVisualStyleBackColor = false;
            btLogout_6.Click += btLogout_6_Click;
            // 
            // btLaporanInventori_6
            // 
            btLaporanInventori_6.BackColor = Color.DarkKhaki;
            btLaporanInventori_6.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btLaporanInventori_6.Location = new Point(-5, 317);
            btLaporanInventori_6.Name = "btLaporanInventori_6";
            btLaporanInventori_6.Size = new Size(200, 33);
            btLaporanInventori_6.TabIndex = 8;
            btLaporanInventori_6.Text = "Laporan Inventori";
            btLaporanInventori_6.UseVisualStyleBackColor = false;
            btLaporanInventori_6.Click += btLaporanInventori_6_Click;
            // 
            // btMonitoringStok_6
            // 
            btMonitoringStok_6.BackColor = Color.DarkKhaki;
            btMonitoringStok_6.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btMonitoringStok_6.Location = new Point(-5, 268);
            btMonitoringStok_6.Name = "btMonitoringStok_6";
            btMonitoringStok_6.Size = new Size(200, 34);
            btMonitoringStok_6.TabIndex = 6;
            btMonitoringStok_6.Text = "Monitoring Stok";
            btMonitoringStok_6.UseVisualStyleBackColor = false;
            btMonitoringStok_6.Click += btMonitoringStok_6_Click;
            // 
            // btStokKeluar_6
            // 
            btStokKeluar_6.BackColor = Color.DarkKhaki;
            btStokKeluar_6.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btStokKeluar_6.Location = new Point(-5, 222);
            btStokKeluar_6.Name = "btStokKeluar_6";
            btStokKeluar_6.Size = new Size(200, 34);
            btStokKeluar_6.TabIndex = 5;
            btStokKeluar_6.Text = "Stok Keluar";
            btStokKeluar_6.UseVisualStyleBackColor = false;
            btStokKeluar_6.Click += btStokKeluar_6_Click;
            // 
            // btKelolaGudang_6
            // 
            btKelolaGudang_6.BackColor = Color.DarkKhaki;
            btKelolaGudang_6.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btKelolaGudang_6.Location = new Point(-5, 123);
            btKelolaGudang_6.Name = "btKelolaGudang_6";
            btKelolaGudang_6.Size = new Size(200, 34);
            btKelolaGudang_6.TabIndex = 5;
            btKelolaGudang_6.Text = "Kelola Gudang";
            btKelolaGudang_6.UseVisualStyleBackColor = false;
            btKelolaGudang_6.Click += btKelolaGudang_6_Click;
            // 
            // btStokMasuk_6
            // 
            btStokMasuk_6.BackColor = Color.DarkKhaki;
            btStokMasuk_6.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btStokMasuk_6.Location = new Point(-5, 173);
            btStokMasuk_6.Name = "btStokMasuk_6";
            btStokMasuk_6.Size = new Size(200, 34);
            btStokMasuk_6.TabIndex = 4;
            btStokMasuk_6.Text = "Stok Masuk";
            btStokMasuk_6.UseVisualStyleBackColor = false;
            btStokMasuk_6.Click += btStokMasuk_6_Click;
            // 
            // btKelolaHasilPanen_6
            // 
            btKelolaHasilPanen_6.BackColor = Color.DarkKhaki;
            btKelolaHasilPanen_6.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btKelolaHasilPanen_6.Location = new Point(-5, 76);
            btKelolaHasilPanen_6.Name = "btKelolaHasilPanen_6";
            btKelolaHasilPanen_6.Size = new Size(200, 34);
            btKelolaHasilPanen_6.TabIndex = 3;
            btKelolaHasilPanen_6.Text = "Kelola Hasil Panen";
            btKelolaHasilPanen_6.UseVisualStyleBackColor = false;
            // 
            // btDashboard_6
            // 
            btDashboard_6.BackColor = Color.DarkKhaki;
            btDashboard_6.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btDashboard_6.Location = new Point(-5, 31);
            btDashboard_6.Name = "btDashboard_6";
            btDashboard_6.Size = new Size(200, 34);
            btDashboard_6.TabIndex = 2;
            btDashboard_6.Text = "Dashboard";
            btDashboard_6.UseVisualStyleBackColor = false;
            btDashboard_6.Click += btDashboard_6_Click;
            // 
            // L_Role6
            // 
            L_Role6.AutoSize = true;
            L_Role6.BackColor = Color.DarkOliveGreen;
            L_Role6.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            L_Role6.ForeColor = SystemColors.ButtonHighlight;
            L_Role6.Location = new Point(65, 24);
            L_Role6.Name = "L_Role6";
            L_Role6.Size = new Size(40, 21);
            L_Role6.TabIndex = 0;
            L_Role6.Text = "Role";
            // 
            // L_Username6
            // 
            L_Username6.AutoSize = true;
            L_Username6.Font = new Font("Calibri", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            L_Username6.ForeColor = SystemColors.ButtonHighlight;
            L_Username6.Location = new Point(65, 4);
            L_Username6.Name = "L_Username6";
            L_Username6.Size = new Size(87, 22);
            L_Username6.TabIndex = 0;
            L_Username6.Text = "Username";
            // 
            // G_Profil6
            // 
            G_Profil6.BackColor = Color.Transparent;
            G_Profil6.BorderStyle = BorderStyle.FixedSingle;
            G_Profil6.Image = (Image)resources.GetObject("G_Profil6.Image");
            G_Profil6.InitialImage = null;
            G_Profil6.Location = new Point(20, 6);
            G_Profil6.Name = "G_Profil6";
            G_Profil6.Size = new Size(43, 41);
            G_Profil6.SizeMode = PictureBoxSizeMode.Zoom;
            G_Profil6.TabIndex = 0;
            G_Profil6.TabStop = false;
            // 
            // BC_
            // 
            BC_.BackColor = Color.Ivory;
            BC_.Controls.Add(BC_penel6);
            BC_.Controls.Add(BC_Page6);
            BC_.Controls.Add(J_MonitoringStok6);
            BC_.Location = new Point(188, -9);
            BC_.Name = "BC_";
            BC_.Size = new Size(1049, 579);
            BC_.TabIndex = 2;
            BC_.Paint += BC__Paint;
            // 
            // BC_penel6
            // 
            BC_penel6.BackColor = Color.SaddleBrown;
            BC_penel6.Controls.Add(L_KeluarTerakhir6);
            BC_penel6.Controls.Add(L_MasukTerakhir6);
            BC_penel6.Controls.Add(DGV_KeluarTerakhir6);
            BC_penel6.Controls.Add(DGV_MasukTerakhir);
            BC_penel6.Controls.Add(DGV_RiwayatStok);
            BC_penel6.Controls.Add(SJ_RiwayatStok6);
            BC_penel6.Controls.Add(SJ_StatusGudang6);
            BC_penel6.Location = new Point(33, 97);
            BC_penel6.Name = "BC_penel6";
            BC_penel6.Size = new Size(972, 442);
            BC_penel6.TabIndex = 5;
            // 
            // L_KeluarTerakhir6
            // 
            L_KeluarTerakhir6.AutoSize = true;
            L_KeluarTerakhir6.Location = new Point(506, 252);
            L_KeluarTerakhir6.Name = "L_KeluarTerakhir6";
            L_KeluarTerakhir6.Size = new Size(107, 20);
            L_KeluarTerakhir6.TabIndex = 6;
            L_KeluarTerakhir6.Text = "Keluar Terakhir";
            // 
            // L_MasukTerakhir6
            // 
            L_MasukTerakhir6.AutoSize = true;
            L_MasukTerakhir6.Location = new Point(25, 249);
            L_MasukTerakhir6.Name = "L_MasukTerakhir6";
            L_MasukTerakhir6.Size = new Size(107, 20);
            L_MasukTerakhir6.TabIndex = 5;
            L_MasukTerakhir6.Text = "Masuk Terakhir";
            // 
            // DGV_KeluarTerakhir6
            // 
            DGV_KeluarTerakhir6.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_KeluarTerakhir6.BackgroundColor = SystemColors.ControlLightLight;
            DGV_KeluarTerakhir6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_KeluarTerakhir6.Columns.AddRange(new DataGridViewColumn[] { Tanggal2, Tujuan, Kg2 });
            DGV_KeluarTerakhir6.Location = new Point(505, 277);
            DGV_KeluarTerakhir6.Name = "DGV_KeluarTerakhir6";
            DGV_KeluarTerakhir6.RowHeadersWidth = 51;
            DGV_KeluarTerakhir6.Size = new Size(443, 135);
            DGV_KeluarTerakhir6.TabIndex = 4;
            // 
            // DGV_MasukTerakhir
            // 
            DGV_MasukTerakhir.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_MasukTerakhir.BackgroundColor = SystemColors.ControlLightLight;
            DGV_MasukTerakhir.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_MasukTerakhir.Columns.AddRange(new DataGridViewColumn[] { Tanggal, Gudang, Kg });
            DGV_MasukTerakhir.Location = new Point(25, 277);
            DGV_MasukTerakhir.Name = "DGV_MasukTerakhir";
            DGV_MasukTerakhir.RowHeadersWidth = 51;
            DGV_MasukTerakhir.Size = new Size(443, 135);
            DGV_MasukTerakhir.TabIndex = 3;
            // 
            // DGV_RiwayatStok
            // 
            DGV_RiwayatStok.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_RiwayatStok.BackgroundColor = SystemColors.HighlightText;
            DGV_RiwayatStok.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_RiwayatStok.Columns.AddRange(new DataGridViewColumn[] { NamaGudang, Lokasi, Stokkg, Kapasitas, Status, Total });
            DGV_RiwayatStok.Location = new Point(25, 40);
            DGV_RiwayatStok.Name = "DGV_RiwayatStok";
            DGV_RiwayatStok.RowHeadersWidth = 51;
            DGV_RiwayatStok.Size = new Size(923, 151);
            DGV_RiwayatStok.TabIndex = 2;
            DGV_RiwayatStok.CellContentClick += DGV_RiwayatMutasiStok_CellContentClick;
            // 
            // SJ_RiwayatStok6
            // 
            SJ_RiwayatStok6.AutoSize = true;
            SJ_RiwayatStok6.BackColor = Color.Ivory;
            SJ_RiwayatStok6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SJ_RiwayatStok6.Location = new Point(0, 0);
            SJ_RiwayatStok6.Name = "SJ_RiwayatStok6";
            SJ_RiwayatStok6.Size = new Size(130, 23);
            SJ_RiwayatStok6.TabIndex = 1;
            SJ_RiwayatStok6.Text = "Riwayat Stok     ";
            // 
            // SJ_StatusGudang6
            // 
            SJ_StatusGudang6.AutoSize = true;
            SJ_StatusGudang6.BackColor = Color.Ivory;
            SJ_StatusGudang6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SJ_StatusGudang6.Location = new Point(0, 210);
            SJ_StatusGudang6.Name = "SJ_StatusGudang6";
            SJ_StatusGudang6.Size = new Size(147, 23);
            SJ_StatusGudang6.TabIndex = 0;
            SJ_StatusGudang6.Text = "Status Gudang     ";
            // 
            // BC_Page6
            // 
            BC_Page6.BackColor = Color.Transparent;
            BC_Page6.Image = (Image)resources.GetObject("BC_Page6.Image");
            BC_Page6.Location = new Point(37, 26);
            BC_Page6.Name = "BC_Page6";
            BC_Page6.Size = new Size(73, 58);
            BC_Page6.SizeMode = PictureBoxSizeMode.Zoom;
            BC_Page6.TabIndex = 4;
            BC_Page6.TabStop = false;
            // 
            // J_MonitoringStok6
            // 
            J_MonitoringStok6.AutoSize = true;
            J_MonitoringStok6.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            J_MonitoringStok6.Location = new Point(102, 34);
            J_MonitoringStok6.Name = "J_MonitoringStok6";
            J_MonitoringStok6.Size = new Size(239, 39);
            J_MonitoringStok6.TabIndex = 3;
            J_MonitoringStok6.Text = "Monitoring Stok";
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
            // Stokkg
            // 
            Stokkg.HeaderText = "Stok (kg)";
            Stokkg.MinimumWidth = 6;
            Stokkg.Name = "Stokkg";
            // 
            // Kapasitas
            // 
            Kapasitas.HeaderText = "Kapasitas (kg)";
            Kapasitas.MinimumWidth = 6;
            Kapasitas.Name = "Kapasitas";
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.MinimumWidth = 6;
            Total.Name = "Total";
            // 
            // Tanggal
            // 
            Tanggal.HeaderText = "Tanggal";
            Tanggal.MinimumWidth = 6;
            Tanggal.Name = "Tanggal";
            // 
            // Gudang
            // 
            Gudang.HeaderText = "Gudang";
            Gudang.MinimumWidth = 6;
            Gudang.Name = "Gudang";
            // 
            // Kg
            // 
            Kg.HeaderText = "Kg";
            Kg.MinimumWidth = 6;
            Kg.Name = "Kg";
            // 
            // Tanggal2
            // 
            Tanggal2.HeaderText = "Tanggal";
            Tanggal2.MinimumWidth = 6;
            Tanggal2.Name = "Tanggal2";
            // 
            // Tujuan
            // 
            Tujuan.HeaderText = "Tujuan";
            Tujuan.MinimumWidth = 6;
            Tujuan.Name = "Tujuan";
            // 
            // Kg2
            // 
            Kg2.HeaderText = "Kg";
            Kg2.MinimumWidth = 6;
            Kg2.Name = "Kg2";
            // 
            // V_MonitoringStok
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1223, 561);
            Controls.Add(BC_);
            Controls.Add(BC_MenuBar6ini);
            Name = "V_MonitoringStok";
            Text = "Form6";
            Load += MonitoringStok_Load;
            BC_MenuBar6ini.ResumeLayout(false);
            BC_MenuBar6ini.PerformLayout();
            BC_MenuBar1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)G_Profil6).EndInit();
            BC_.ResumeLayout(false);
            BC_.PerformLayout();
            BC_penel6.ResumeLayout(false);
            BC_penel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_KeluarTerakhir6).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGV_MasukTerakhir).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGV_RiwayatStok).EndInit();
            ((System.ComponentModel.ISupportInitialize)BC_Page6).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel BC_MenuBar6ini;
        private Panel BC_MenuBar1;
        private Button btLogout_6;
        private Button btLaporanInventori_6;
        private Button btMonitoringStok_6;
        private Button btStokKeluar_6;
        private Button btKelolaGudang_6;
        private Button btStokMasuk_6;
        private Button btKelolaHasilPanen_6;
        private Button btDashboard_6;
        private Label L_Role6;
        private Label L_Username6;
        private PictureBox G_Profil6;
        private Panel BC_;
        private PictureBox BC_Page6;
        private Label J_MonitoringStok6;
        private Panel BC_penel6;
        private DataGridView DGV_RiwayatStok;
        private Label SJ_RiwayatMutasiStok6;
        private Label SJ_StatusGudang6;
        private Label L_KeluarTerakhir6;
        private Label L_MasukTerakhir6;
        private DataGridView DGV_KeluarTerakhir6;
        private DataGridView DGV_MasukTerakhir;
        private DataGridViewTextBoxColumn Tanggal2;
        private DataGridViewTextBoxColumn Tujuan;
        private DataGridViewTextBoxColumn Kg2;
        private DataGridViewTextBoxColumn Tanggal;
        private DataGridViewTextBoxColumn Gudang;
        private DataGridViewTextBoxColumn Kg;
        private DataGridViewTextBoxColumn Lokasi;
        private DataGridViewTextBoxColumn Stok;
        private DataGridViewTextBoxColumn Kapasitas;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Terisi;
        private Label SJ_RiwayatStok6;
        private DataGridViewTextBoxColumn NamaGudang;
        private DataGridViewTextBoxColumn Stokkg;
        private DataGridViewTextBoxColumn Total;
    }
}