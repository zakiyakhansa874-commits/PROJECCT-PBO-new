namespace TugasProject_PBO.Views.Admin
{
    partial class DashboardAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardAdmin));
            btLogout = new Button();
            btLaporanInventori = new Button();
            btMonitoringStok = new Button();
            btStokKeluar = new Button();
            btKelolaGudang = new Button();
            btStokMasuk = new Button();
            btDataHasilPanen = new Button();
            btDashboard = new Button();
            L_Role = new Label();
            L_Username = new Label();
            G_Profil = new PictureBox();
            BC_DashboardAdmin = new Panel();
            BC_HPT = new Panel();
            HPT_dataGridView1 = new DataGridView();
            Tanggal = new DataGridViewTextBoxColumn();
            Petani = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            beratbersih = new DataGridViewTextBoxColumn();
            kualitas = new DataGridViewTextBoxColumn();
            T_HPT = new Label();
            P_SSI = new Panel();
            L_StokSaatIni = new Label();
            G_Stok = new PictureBox();
            A_StokSaatIni = new Label();
            P_TG = new Panel();
            G_Gudang = new PictureBox();
            L_TotalGedung = new Label();
            A_TotalGedung = new Label();
            P_THP = new Panel();
            G_HasilPanen = new PictureBox();
            A_TotalHasilPanen = new Label();
            L_TotalHasilPanen = new Label();
            G_DashboardAdmin = new PictureBox();
            J_DashboardAdmin = new Label();
            BC_KG = new Panel();
            KG_progressBar = new ProgressBar();
            L_TeksPendukungSJ = new Label();
            SJ_KapasitasGudang = new Label();
            BC_MenuBar = new Panel();
            BC_MenuBar2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)G_Profil).BeginInit();
            BC_DashboardAdmin.SuspendLayout();
            BC_HPT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)HPT_dataGridView1).BeginInit();
            P_SSI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)G_Stok).BeginInit();
            P_TG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)G_Gudang).BeginInit();
            P_THP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)G_HasilPanen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)G_DashboardAdmin).BeginInit();
            BC_KG.SuspendLayout();
            BC_MenuBar.SuspendLayout();
            BC_MenuBar2.SuspendLayout();
            SuspendLayout();
            // 
            // btLogout
            // 
            btLogout.BackColor = Color.DarkKhaki;
            btLogout.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btLogout.Location = new Point(-5, 351);
            btLogout.Name = "btLogout";
            btLogout.Size = new Size(183, 34);
            btLogout.TabIndex = 9;
            btLogout.Text = "Logout";
            btLogout.UseVisualStyleBackColor = false;
            btLogout.Click += btLogout_Click;
            // 
            // btLaporanInventori
            // 
            btLaporanInventori.BackColor = Color.DarkKhaki;
            btLaporanInventori.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btLaporanInventori.Location = new Point(-1, 213);
            btLaporanInventori.Name = "btLaporanInventori";
            btLaporanInventori.Size = new Size(179, 33);
            btLaporanInventori.TabIndex = 8;
            btLaporanInventori.Text = "Laporan Inventori";
            btLaporanInventori.UseVisualStyleBackColor = false;
            btLaporanInventori.Click += btLaporanInventori_Click;
            // 
            // btMonitoringStok
            // 
            btMonitoringStok.BackColor = Color.DarkKhaki;
            btMonitoringStok.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btMonitoringStok.Location = new Point(-1, 182);
            btMonitoringStok.Name = "btMonitoringStok";
            btMonitoringStok.Size = new Size(179, 34);
            btMonitoringStok.TabIndex = 6;
            btMonitoringStok.Text = "Monitoring Stok";
            btMonitoringStok.UseVisualStyleBackColor = false;
            btMonitoringStok.Click += btMonitoringStok_Click;
            // 
            // btStokKeluar
            // 
            btStokKeluar.BackColor = Color.DarkKhaki;
            btStokKeluar.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btStokKeluar.Location = new Point(-1, 150);
            btStokKeluar.Name = "btStokKeluar";
            btStokKeluar.Size = new Size(186, 34);
            btStokKeluar.TabIndex = 5;
            btStokKeluar.Text = "Stok Keluar";
            btStokKeluar.UseVisualStyleBackColor = false;
            btStokKeluar.Click += btStokMasuk_Click;
            // 
            // btKelolaGudang
            // 
            btKelolaGudang.BackColor = Color.DarkKhaki;
            btKelolaGudang.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btKelolaGudang.Location = new Point(-5, 87);
            btKelolaGudang.Name = "btKelolaGudang";
            btKelolaGudang.Size = new Size(183, 34);
            btKelolaGudang.TabIndex = 5;
            btKelolaGudang.Text = "Kelola Gudang";
            btKelolaGudang.UseVisualStyleBackColor = false;
            btKelolaGudang.Click += btKelolaGudang_Click;
            // 
            // btStokMasuk
            // 
            btStokMasuk.BackColor = Color.DarkKhaki;
            btStokMasuk.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btStokMasuk.Location = new Point(-5, 118);
            btStokMasuk.Name = "btStokMasuk";
            btStokMasuk.Size = new Size(183, 34);
            btStokMasuk.TabIndex = 4;
            btStokMasuk.Text = "Stok Masuk";
            btStokMasuk.UseVisualStyleBackColor = false;
            btStokMasuk.Click += btStokMasuk_Click;
            // 
            // btDataHasilPanen
            // 
            btDataHasilPanen.BackColor = Color.DarkKhaki;
            btDataHasilPanen.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btDataHasilPanen.Location = new Point(-5, 55);
            btDataHasilPanen.Name = "btDataHasilPanen";
            btDataHasilPanen.Size = new Size(185, 34);
            btDataHasilPanen.TabIndex = 3;
            btDataHasilPanen.Text = "Data Hasil Panen";
            btDataHasilPanen.UseVisualStyleBackColor = false;
            btDataHasilPanen.Click += btDataHasilPanen_Click;
            // 
            // btDashboard
            // 
            btDashboard.BackColor = Color.DarkKhaki;
            btDashboard.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btDashboard.Location = new Point(-5, 23);
            btDashboard.Name = "btDashboard";
            btDashboard.Size = new Size(185, 34);
            btDashboard.TabIndex = 2;
            btDashboard.Text = "Dashboard";
            btDashboard.UseVisualStyleBackColor = false;
            btDashboard.Click += btDashboard_Click;
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
            L_Role.Click += L_Role_Click;
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
            L_Username.Click += L_Username_Click;
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
            G_Profil.Click += G_Profil_Click;
            // 
            // BC_DashboardAdmin
            // 
            BC_DashboardAdmin.BackColor = Color.Ivory;
            BC_DashboardAdmin.BorderStyle = BorderStyle.Fixed3D;
            BC_DashboardAdmin.Controls.Add(BC_HPT);
            BC_DashboardAdmin.Controls.Add(P_SSI);
            BC_DashboardAdmin.Controls.Add(P_TG);
            BC_DashboardAdmin.Controls.Add(P_THP);
            BC_DashboardAdmin.Controls.Add(G_DashboardAdmin);
            BC_DashboardAdmin.Controls.Add(J_DashboardAdmin);
            BC_DashboardAdmin.Controls.Add(BC_KG);
            BC_DashboardAdmin.Location = new Point(172, -7);
            BC_DashboardAdmin.Name = "BC_DashboardAdmin";
            BC_DashboardAdmin.Size = new Size(632, 456);
            BC_DashboardAdmin.TabIndex = 1;
            BC_DashboardAdmin.Click += BC_DashboardAdmin_Click;
            BC_DashboardAdmin.Paint += panel2_Paint;
            // 
            // BC_HPT
            // 
            BC_HPT.BackColor = Color.Peru;
            BC_HPT.BorderStyle = BorderStyle.Fixed3D;
            BC_HPT.Controls.Add(HPT_dataGridView1);
            BC_HPT.Controls.Add(T_HPT);
            BC_HPT.Location = new Point(-2, 267);
            BC_HPT.Name = "BC_HPT";
            BC_HPT.Size = new Size(632, 188);
            BC_HPT.TabIndex = 5;
            BC_HPT.Paint += panel7_Paint;
            // 
            // HPT_dataGridView1
            // 
            HPT_dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            HPT_dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Tanggal, Petani, Column1, beratbersih, kualitas });
            HPT_dataGridView1.Location = new Point(15, 28);
            HPT_dataGridView1.Name = "HPT_dataGridView1";
            HPT_dataGridView1.RowHeadersWidth = 51;
            HPT_dataGridView1.Size = new Size(599, 145);
            HPT_dataGridView1.TabIndex = 1;
            // 
            // Tanggal
            // 
            Tanggal.HeaderText = "Tanggal";
            Tanggal.MinimumWidth = 6;
            Tanggal.Name = "Tanggal";
            Tanggal.Width = 125;
            // 
            // Petani
            // 
            Petani.HeaderText = "Petani";
            Petani.MinimumWidth = 6;
            Petani.Name = "Petani";
            Petani.Width = 125;
            // 
            // Column1
            // 
            Column1.HeaderText = "Komoditas";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // beratbersih
            // 
            beratbersih.HeaderText = "Berat Bersih (kg)";
            beratbersih.MinimumWidth = 6;
            beratbersih.Name = "beratbersih";
            beratbersih.Width = 125;
            // 
            // kualitas
            // 
            kualitas.HeaderText = "Kualitas";
            kualitas.MinimumWidth = 6;
            kualitas.Name = "kualitas";
            kualitas.Width = 125;
            // 
            // T_HPT
            // 
            T_HPT.AccessibleDescription = "SJ_HasilPanen_Terbaru";
            T_HPT.AutoSize = true;
            T_HPT.BackColor = Color.Ivory;
            T_HPT.ForeColor = SystemColors.ActiveCaptionText;
            T_HPT.Location = new Point(-2, -1);
            T_HPT.Name = "T_HPT";
            T_HPT.Size = new Size(139, 20);
            T_HPT.TabIndex = 0;
            T_HPT.Text = "Hasil Panen Terbaru";
            T_HPT.Click += this.T_HPT_Clik;
            // 
            // P_SSI
            // 
            P_SSI.Controls.Add(L_StokSaatIni);
            P_SSI.Controls.Add(G_Stok);
            P_SSI.Controls.Add(A_StokSaatIni);
            P_SSI.Location = new Point(60, 63);
            P_SSI.Name = "P_SSI";
            P_SSI.Size = new Size(169, 73);
            P_SSI.TabIndex = 9;
            // 
            // L_StokSaatIni
            // 
            L_StokSaatIni.AutoSize = true;
            L_StokSaatIni.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            L_StokSaatIni.Location = new Point(74, 13);
            L_StokSaatIni.Name = "L_StokSaatIni";
            L_StokSaatIni.Size = new Size(79, 17);
            L_StokSaatIni.TabIndex = 6;
            L_StokSaatIni.Text = "Stok Saat Ini";
            // 
            // G_Stok
            // 
            G_Stok.Image = (Image)resources.GetObject("G_Stok.Image");
            G_Stok.Location = new Point(9, 12);
            G_Stok.Name = "G_Stok";
            G_Stok.Size = new Size(56, 48);
            G_Stok.SizeMode = PictureBoxSizeMode.Zoom;
            G_Stok.TabIndex = 6;
            G_Stok.TabStop = false;
            // 
            // A_StokSaatIni
            // 
            A_StokSaatIni.AutoSize = true;
            A_StokSaatIni.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            A_StokSaatIni.Location = new Point(63, 29);
            A_StokSaatIni.Name = "A_StokSaatIni";
            A_StokSaatIni.Size = new Size(99, 31);
            A_StokSaatIni.TabIndex = 8;
            A_StokSaatIni.Text = "5420 kg";
            // 
            // P_TG
            // 
            P_TG.Controls.Add(G_Gudang);
            P_TG.Controls.Add(L_TotalGedung);
            P_TG.Controls.Add(A_TotalGedung);
            P_TG.Location = new Point(421, 63);
            P_TG.Name = "P_TG";
            P_TG.Size = new Size(165, 73);
            P_TG.TabIndex = 4;
            // 
            // G_Gudang
            // 
            G_Gudang.Image = (Image)resources.GetObject("G_Gudang.Image");
            G_Gudang.Location = new Point(9, 13);
            G_Gudang.Name = "G_Gudang";
            G_Gudang.Size = new Size(56, 48);
            G_Gudang.SizeMode = PictureBoxSizeMode.Zoom;
            G_Gudang.TabIndex = 10;
            G_Gudang.TabStop = false;
            // 
            // L_TotalGedung
            // 
            L_TotalGedung.AutoSize = true;
            L_TotalGedung.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            L_TotalGedung.Location = new Point(71, 14);
            L_TotalGedung.Name = "L_TotalGedung";
            L_TotalGedung.Size = new Size(86, 17);
            L_TotalGedung.TabIndex = 6;
            L_TotalGedung.Text = "Total Gudang";
            L_TotalGedung.Click += L_TotalGedung_Click;
            // 
            // A_TotalGedung
            // 
            A_TotalGedung.AutoSize = true;
            A_TotalGedung.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            A_TotalGedung.Location = new Point(97, 29);
            A_TotalGedung.Name = "A_TotalGedung";
            A_TotalGedung.Size = new Size(27, 31);
            A_TotalGedung.TabIndex = 8;
            A_TotalGedung.Text = "3";
            A_TotalGedung.Click += label3_Click;
            // 
            // P_THP
            // 
            P_THP.Controls.Add(G_HasilPanen);
            P_THP.Controls.Add(A_TotalHasilPanen);
            P_THP.Controls.Add(L_TotalHasilPanen);
            P_THP.Location = new Point(239, 63);
            P_THP.Name = "P_THP";
            P_THP.Size = new Size(172, 73);
            P_THP.TabIndex = 5;
            // 
            // G_HasilPanen
            // 
            G_HasilPanen.Image = (Image)resources.GetObject("G_HasilPanen.Image");
            G_HasilPanen.Location = new Point(6, 13);
            G_HasilPanen.Name = "G_HasilPanen";
            G_HasilPanen.Size = new Size(56, 48);
            G_HasilPanen.SizeMode = PictureBoxSizeMode.Zoom;
            G_HasilPanen.TabIndex = 11;
            G_HasilPanen.TabStop = false;
            // 
            // A_TotalHasilPanen
            // 
            A_TotalHasilPanen.AutoSize = true;
            A_TotalHasilPanen.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            A_TotalHasilPanen.Location = new Point(62, 28);
            A_TotalHasilPanen.Name = "A_TotalHasilPanen";
            A_TotalHasilPanen.Size = new Size(99, 31);
            A_TotalHasilPanen.TabIndex = 9;
            A_TotalHasilPanen.Text = "1306 kg";
            A_TotalHasilPanen.Click += label5_Click;
            // 
            // L_TotalHasilPanen
            // 
            L_TotalHasilPanen.AutoSize = true;
            L_TotalHasilPanen.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            L_TotalHasilPanen.Location = new Point(62, 13);
            L_TotalHasilPanen.Name = "L_TotalHasilPanen";
            L_TotalHasilPanen.Size = new Size(107, 17);
            L_TotalHasilPanen.TabIndex = 7;
            L_TotalHasilPanen.Text = "Total Hasil Panen";
            L_TotalHasilPanen.Click += label1_Click_2;
            // 
            // G_DashboardAdmin
            // 
            G_DashboardAdmin.BackColor = Color.Transparent;
            G_DashboardAdmin.Image = (Image)resources.GetObject("G_DashboardAdmin.Image");
            G_DashboardAdmin.Location = new Point(21, 11);
            G_DashboardAdmin.Name = "G_DashboardAdmin";
            G_DashboardAdmin.Size = new Size(53, 45);
            G_DashboardAdmin.SizeMode = PictureBoxSizeMode.Zoom;
            G_DashboardAdmin.TabIndex = 2;
            G_DashboardAdmin.TabStop = false;
            // 
            // J_DashboardAdmin
            // 
            J_DashboardAdmin.AutoSize = true;
            J_DashboardAdmin.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            J_DashboardAdmin.Location = new Point(71, 18);
            J_DashboardAdmin.Name = "J_DashboardAdmin";
            J_DashboardAdmin.Size = new Size(231, 34);
            J_DashboardAdmin.TabIndex = 1;
            J_DashboardAdmin.Text = "Dashboard Admin";
            J_DashboardAdmin.Click += J_DashboardAdmin_Click;
            // 
            // BC_KG
            // 
            BC_KG.BackColor = Color.Peru;
            BC_KG.BorderStyle = BorderStyle.Fixed3D;
            BC_KG.Controls.Add(KG_progressBar);
            BC_KG.Controls.Add(L_TeksPendukungSJ);
            BC_KG.Controls.Add(SJ_KapasitasGudang);
            BC_KG.Location = new Point(-2, 150);
            BC_KG.Name = "BC_KG";
            BC_KG.Size = new Size(632, 111);
            BC_KG.TabIndex = 0;
            BC_KG.Paint += panel4_Paint;
            // 
            // KG_progressBar
            // 
            KG_progressBar.ForeColor = Color.SaddleBrown;
            KG_progressBar.Location = new Point(21, 53);
            KG_progressBar.Name = "KG_progressBar";
            KG_progressBar.Size = new Size(573, 29);
            KG_progressBar.TabIndex = 2;
            // 
            // L_TeksPendukungSJ
            // 
            L_TeksPendukungSJ.AutoSize = true;
            L_TeksPendukungSJ.BackColor = Color.Peru;
            L_TeksPendukungSJ.Location = new Point(18, 31);
            L_TeksPendukungSJ.Name = "L_TeksPendukungSJ";
            L_TeksPendukungSJ.Size = new Size(269, 20);
            L_TeksPendukungSJ.TabIndex = 4;
            L_TeksPendukungSJ.Text = "Gudang Utama A - 3200/5000 kg (64%)";
            L_TeksPendukungSJ.Click += label2_Click_1;
            // 
            // SJ_KapasitasGudang
            // 
            SJ_KapasitasGudang.AutoSize = true;
            SJ_KapasitasGudang.BackColor = Color.Ivory;
            SJ_KapasitasGudang.ForeColor = SystemColors.ActiveCaptionText;
            SJ_KapasitasGudang.Location = new Point(-2, -1);
            SJ_KapasitasGudang.Name = "SJ_KapasitasGudang";
            SJ_KapasitasGudang.Size = new Size(128, 20);
            SJ_KapasitasGudang.TabIndex = 0;
            SJ_KapasitasGudang.Text = "Kapasitas Gudang";
            // 
            // BC_MenuBar
            // 
            BC_MenuBar.BackColor = Color.DarkOliveGreen;
            BC_MenuBar.BorderStyle = BorderStyle.Fixed3D;
            BC_MenuBar.Controls.Add(BC_MenuBar2);
            BC_MenuBar.Controls.Add(L_Role);
            BC_MenuBar.Controls.Add(L_Username);
            BC_MenuBar.Controls.Add(G_Profil);
            BC_MenuBar.Location = new Point(-1, -4);
            BC_MenuBar.Name = "BC_MenuBar";
            BC_MenuBar.Size = new Size(184, 451);
            BC_MenuBar.TabIndex = 0;
            BC_MenuBar.Paint += BC_MenuBar_Paint;
            // 
            // BC_MenuBar2
            // 
            BC_MenuBar2.BackColor = Color.Ivory;
            BC_MenuBar2.Controls.Add(btLogout);
            BC_MenuBar2.Controls.Add(btLaporanInventori);
            BC_MenuBar2.Controls.Add(btMonitoringStok);
            BC_MenuBar2.Controls.Add(btStokKeluar);
            BC_MenuBar2.Controls.Add(btKelolaGudang);
            BC_MenuBar2.Controls.Add(btStokMasuk);
            BC_MenuBar2.Controls.Add(btDataHasilPanen);
            BC_MenuBar2.Controls.Add(btDashboard);
            BC_MenuBar2.Location = new Point(-3, 51);
            BC_MenuBar2.Name = "BC_MenuBar2";
            BC_MenuBar2.Size = new Size(185, 401);
            BC_MenuBar2.TabIndex = 0;
            BC_MenuBar2.Paint += panel3_Paint;
            // 
            // DashboardAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 448);
            Controls.Add(BC_DashboardAdmin);
            Controls.Add(BC_MenuBar);
            Name = "DashboardAdmin";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)G_Profil).EndInit();
            BC_DashboardAdmin.ResumeLayout(false);
            BC_DashboardAdmin.PerformLayout();
            BC_HPT.ResumeLayout(false);
            BC_HPT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)HPT_dataGridView1).EndInit();
            P_SSI.ResumeLayout(false);
            P_SSI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)G_Stok).EndInit();
            P_TG.ResumeLayout(false);
            P_TG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)G_Gudang).EndInit();
            P_THP.ResumeLayout(false);
            P_THP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)G_HasilPanen).EndInit();
            ((System.ComponentModel.ISupportInitialize)G_DashboardAdmin).EndInit();
            BC_KG.ResumeLayout(false);
            BC_KG.PerformLayout();
            BC_MenuBar.ResumeLayout(false);
            BC_MenuBar.PerformLayout();
            BC_MenuBar2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel BC_MenuBar;
        private Panel BC_MenuBar2;
        private Panel BC_KG;
        private PictureBox G_DashboardAdmin;
        private Panel P_THP;
        private Panel P_TG;
        private Label A_TotalGedung;
        private Label L_TotalHasilPanen;
        private Label A_TotalHasilPanen;
        private Label SJ_KapasitasGudang;
        private PictureBox G_Stok;
        private Panel P_SSI;
        private Label L_StokSaatIni;
        private Label A_StokSaatIni;
        private PictureBox G_Gudang;
        private PictureBox G_HasilPanen;
        private ProgressBar KG_progressBar;
        private Label L_TeksPendukungSJ;
        private Panel BC_HPT;
        private Label T_HPT;
        private DataGridView HPT_dataGridView1;
        private DataGridViewTextBoxColumn Tanggal;
        private DataGridViewTextBoxColumn Petani;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn beratbersih;
        private DataGridViewTextBoxColumn kualitas;
        private Button btLogout;
        private Button btLaporanInventori;
        private Button btStokKeluar;
        private Button btDashboard;
        private Button btMonitoringStok;
        private Button btKelolaGudang;
        private Button btStokMasuk;
        private Button btDataHasilPanen;
        private Label L_Role;
        private Label L_Username;
        private PictureBox G_Profil;
        private Label L_TotalGedung;
        private Label J_DashboardAdmin;
        private Panel BC_DashboardAdmin;
        





    }
}