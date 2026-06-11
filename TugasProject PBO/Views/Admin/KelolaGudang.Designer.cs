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
            SuspendLayout();
            // 
            // LNamaGudang
            // 
            LNamaGudang.AutoSize = true;
            LNamaGudang.Location = new Point(12, 20);
            LNamaGudang.Name = "LNamaGudang";
            LNamaGudang.Size = new Size(108, 20);
            LNamaGudang.TabIndex = 0;
            LNamaGudang.Text = "Nama Gudang:";
            LNamaGudang.Click += label1_Click;
            // 
            // LLokasi
            // 
            LLokasi.AutoSize = true;
            LLokasi.Location = new Point(12, 55);
            LLokasi.Name = "LLokasi";
            LLokasi.Size = new Size(53, 20);
            LLokasi.TabIndex = 1;
            LLokasi.Text = "Lokasi:";
            // 
            // LKapasitas
            // 
            LKapasitas.AutoSize = true;
            LKapasitas.Location = new Point(12, 90);
            LKapasitas.Name = "LKapasitas";
            LKapasitas.Size = new Size(105, 20);
            LKapasitas.TabIndex = 2;
            LKapasitas.Text = "Kapasitas (kg):";
            // 
            // LStokSaatIni
            // 
            LStokSaatIni.AutoSize = true;
            LStokSaatIni.Location = new Point(12, 125);
            LStokSaatIni.Name = "LStokSaatIni";
            LStokSaatIni.Size = new Size(124, 20);
            LStokSaatIni.TabIndex = 3;
            LStokSaatIni.Text = "Stok Saat Ini (kg):";
            // 
            // txtNamaGudang
            // 
            txtNamaGudang.Location = new Point(135, 18);
            txtNamaGudang.Name = "txtNamaGudang";
            txtNamaGudang.Size = new Size(225, 27);
            txtNamaGudang.TabIndex = 4;
            // 
            // txtLokasi
            // 
            txtLokasi.Location = new Point(135, 53);
            txtLokasi.Name = "txtLokasi";
            txtLokasi.Size = new Size(225, 27);
            txtLokasi.TabIndex = 5;
            // 
            // txtKapasitas
            // 
            txtKapasitas.Location = new Point(135, 88);
            txtKapasitas.Name = "txtKapasitas";
            txtKapasitas.Size = new Size(225, 27);
            txtKapasitas.TabIndex = 6;
            // 
            // txtStokSaatIni
            // 
            txtStokSaatIni.Location = new Point(135, 123);
            txtStokSaatIni.Name = "txtStokSaatIni";
            txtStokSaatIni.Size = new Size(225, 27);
            txtStokSaatIni.TabIndex = 7;
            // 
            // GGaris
            // 
            GGaris.BackColor = Color.Silver;
            GGaris.Location = new Point(15, 170);
            GGaris.Name = "GGaris";
            GGaris.Size = new Size(345, 1);
            GGaris.TabIndex = 8;
            // 
            // btSimpan
            // 
            btSimpan.BackColor = Color.Beige;
            btSimpan.Location = new Point(176, 190);
            btSimpan.Name = "btSimpan";
            btSimpan.Size = new Size(75, 26);
            btSimpan.TabIndex = 9;
            btSimpan.Text = "Simpan";
            btSimpan.UseVisualStyleBackColor = false;
            // 
            // btBatal
            // 
            btBatal.BackColor = Color.Beige;
            btBatal.Location = new Point(269, 190);
            btBatal.Name = "btBatal";
            btBatal.Size = new Size(75, 25);
            btBatal.TabIndex = 10;
            btBatal.Text = "Batal";
            btBatal.UseVisualStyleBackColor = false;
            btBatal.Click += btBatal_Click;
            // 
            // KelolaGudang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(372, 228);
            Controls.Add(btBatal);
            Controls.Add(btSimpan);
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
    }
}