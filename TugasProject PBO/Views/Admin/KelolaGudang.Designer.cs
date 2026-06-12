namespace TugasProject_PBO.Views.Admin
{
    partial class KelolaGudang
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
            LNamaGudang = new Label();
            LLokasi = new Label();
            LKapasitas = new Label();
            LStokSaatIni = new Label();
            txtNamaGudang = new TextBox();
            txtLokasi = new TextBox();
            txtKapasitas = new TextBox();
            txtStokSaatIni = new TextBox();
            GGaris = new Panel();
            btSimpan = new Button();
            btBatal = new Button();
            lblStatus = new Label();
            SuspendLayout();
            // 
            // LNamaGudang
            // 
            LNamaGudang.AutoSize = true;
            LNamaGudang.Location = new Point(15, 25);
            LNamaGudang.Margin = new Padding(4, 0, 4, 0);
            LNamaGudang.Name = "LNamaGudang";
            LNamaGudang.Size = new Size(131, 25);
            LNamaGudang.TabIndex = 0;
            LNamaGudang.Text = "Nama Gudang:";
            LNamaGudang.Click += LNamaGudang_Click;
            // 
            // LLokasi
            // 
            LLokasi.AutoSize = true;
            LLokasi.Location = new Point(15, 69);
            LLokasi.Margin = new Padding(4, 0, 4, 0);
            LLokasi.Name = "LLokasi";
            LLokasi.Size = new Size(65, 25);
            LLokasi.TabIndex = 1;
            LLokasi.Text = "Lokasi:";
            LLokasi.Click += LLokasi_Click;
            // 
            // LKapasitas
            // 
            LKapasitas.AutoSize = true;
            LKapasitas.Location = new Point(15, 112);
            LKapasitas.Margin = new Padding(4, 0, 4, 0);
            LKapasitas.Name = "LKapasitas";
            LKapasitas.Size = new Size(125, 25);
            LKapasitas.TabIndex = 2;
            LKapasitas.Text = "Kapasitas (kg):";
            LKapasitas.Click += LKapasitas_Click;
            // 
            // LStokSaatIni
            // 
            LStokSaatIni.AutoSize = true;
            LStokSaatIni.Location = new Point(15, 156);
            LStokSaatIni.Margin = new Padding(4, 0, 4, 0);
            LStokSaatIni.Name = "LStokSaatIni";
            LStokSaatIni.Size = new Size(149, 25);
            LStokSaatIni.TabIndex = 3;
            LStokSaatIni.Text = "Stok Saat Ini (kg):";
            LStokSaatIni.Click += LStokSaatIni_Click;
            // 
            // txtNamaGudang
            // 
            txtNamaGudang.Location = new Point(169, 22);
            txtNamaGudang.Margin = new Padding(4);
            txtNamaGudang.Name = "txtNamaGudang";
            txtNamaGudang.Size = new Size(280, 31);
            txtNamaGudang.TabIndex = 4;
            txtNamaGudang.TextChanged += txtNamaGudang_TextChanged;
            // 
            // txtLokasi
            // 
            txtLokasi.Location = new Point(169, 66);
            txtLokasi.Margin = new Padding(4);
            txtLokasi.Name = "txtLokasi";
            txtLokasi.Size = new Size(280, 31);
            txtLokasi.TabIndex = 5;
            txtLokasi.TextChanged += txtLokasi_TextChanged;
            // 
            // txtKapasitas
            // 
            txtKapasitas.Location = new Point(169, 110);
            txtKapasitas.Margin = new Padding(4);
            txtKapasitas.Name = "txtKapasitas";
            txtKapasitas.Size = new Size(280, 31);
            txtKapasitas.TabIndex = 6;
            txtKapasitas.TextChanged += txtKapasitas_TextChanged;
            // 
            // txtStokSaatIni
            // 
            txtStokSaatIni.Location = new Point(169, 154);
            txtStokSaatIni.Margin = new Padding(4);
            txtStokSaatIni.Name = "txtStokSaatIni";
            txtStokSaatIni.Size = new Size(280, 31);
            txtStokSaatIni.TabIndex = 7;
            txtStokSaatIni.TextChanged += txtStokSaatIni_TextChanged;
            // 
            // GGaris
            // 
            GGaris.BackColor = Color.Silver;
            GGaris.Location = new Point(19, 212);
            GGaris.Margin = new Padding(4);
            GGaris.Name = "GGaris";
            GGaris.Size = new Size(431, 1);
            GGaris.TabIndex = 8;
            // 
            // btSimpan
            // 
            btSimpan.BackColor = Color.Beige;
            btSimpan.Location = new Point(220, 238);
            btSimpan.Margin = new Padding(4);
            btSimpan.Name = "btSimpan";
            btSimpan.Size = new Size(94, 32);
            btSimpan.TabIndex = 9;
            btSimpan.Text = "Simpan";
            btSimpan.UseVisualStyleBackColor = false;
            btSimpan.Click += btSimpan_Click;
            // 
            // btBatal
            // 
            btBatal.BackColor = Color.Beige;
            btBatal.Location = new Point(336, 238);
            btBatal.Margin = new Padding(4);
            btBatal.Name = "btBatal";
            btBatal.Size = new Size(94, 31);
            btBatal.TabIndex = 10;
            btBatal.Text = "Batal";
            btBatal.UseVisualStyleBackColor = false;
            btBatal.Click += btBatal_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(169, 195);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 25);
            lblStatus.TabIndex = 11;
            // 
            // KelolaGudang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(666, 395);
            Controls.Add(btBatal);
            Controls.Add(btSimpan);
            Controls.Add(lblStatus);
            Controls.Add(GGaris);
            Controls.Add(txtStokSaatIni);
            Controls.Add(txtKapasitas);
            Controls.Add(txtLokasi);
            Controls.Add(txtNamaGudang);
            Controls.Add(LStokSaatIni);
            Controls.Add(LKapasitas);
            Controls.Add(LLokasi);
            Controls.Add(LNamaGudang);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "KelolaGudang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit Gudang";
            Load += KelolaGudang_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LNamaGudang;
        private Label LLokasi;
        private Label LKapasitas;
        private Label LStokSaatIni;
        private TextBox txtNamaGudang;
        private TextBox txtLokasi;
        private TextBox txtKapasitas;
        private TextBox txtStokSaatIni;
        private Panel GGaris;
        private Button btSimpan;
        private Button btBatal;
        private Label lblStatus;
    }
}