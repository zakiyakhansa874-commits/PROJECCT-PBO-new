namespace TugasProject_PBO.Views.Petani
{
    partial class BCInputHasilPanen
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
            LPetani = new Label();
            LNamaPetani = new Label();
            LTanggalPanen = new Label();
            dtpTanggalPanen = new DateTimePicker();
            Lkomoditas = new Label();
            cbKomoditas = new ComboBox();
            LBeratKotor = new Label();
            txtBeratKotor = new TextBox();
            LBeratBersih = new Label();
            txtBeratBersih = new TextBox();
            LKualitas = new Label();
            cbKualitas = new ComboBox();
            LCatatan = new Label();
            txtCatatan = new TextBox();
            GGaris = new Panel();
            btSimpan = new Button();
            btBatal = new Button();
            SuspendLayout();
            // 
            // LPetani
            // 
            LPetani.AutoSize = true;
            LPetani.Location = new Point(10, 20);
            LPetani.Name = "LPetani";
            LPetani.Size = new Size(58, 20);
            LPetani.TabIndex = 0;
            LPetani.Text = "Petani:";
           
            // 
            // LNamaPetani
            // 
            LNamaPetani.AutoSize = true;
            LNamaPetani.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LNamaPetani.ForeColor = Color.ForestGreen;
            LNamaPetani.Location = new Point(115, 20);
            LNamaPetani.Name = "LNamaPetani";
            LNamaPetani.Size = new Size(103, 20);
            LNamaPetani.TabIndex = 1;
            LNamaPetani.Text = "Pak Hendra";
            // 
            // LTanggalPanen
            // 
            LTanggalPanen.AutoSize = true;
            LTanggalPanen.Location = new Point(10, 50);
            LTanggalPanen.Name = "LTanggalPanen";
            LTanggalPanen.Size = new Size(120, 20);
            LTanggalPanen.TabIndex = 2;
            LTanggalPanen.Text = "Tanggal Panen:";
            // 
            // dtpTanggalPanen
            // 
            dtpTanggalPanen.Format = DateTimePickerFormat.Short;
            dtpTanggalPanen.Location = new Point(152, 46);
            dtpTanggalPanen.Name = "dtpTanggalPanen";
            dtpTanggalPanen.Size = new Size(255, 25);
            dtpTanggalPanen.TabIndex = 3;
            // 
            // Lkomoditas
            // 
            Lkomoditas.AutoSize = true;
            Lkomoditas.Location = new Point(10, 80);
            Lkomoditas.Name = "Lkomoditas";
            Lkomoditas.Size = new Size(88, 20);
            Lkomoditas.TabIndex = 4;
            Lkomoditas.Text = "Komoditas:";
            // 
            // cbKomoditas
            // 
            cbKomoditas.DropDownStyle = ComboBoxStyle.DropDownList;
            cbKomoditas.FormattingEnabled = true;
            cbKomoditas.Location = new Point(152, 75);
            cbKomoditas.Name = "cbKomoditas";
            cbKomoditas.Size = new Size(255, 28);
            cbKomoditas.TabIndex = 5;
            // 
            // LBeratKotor
            // 
            LBeratKotor.AutoSize = true;
            LBeratKotor.Location = new Point(10, 110);
            LBeratKotor.Name = "LBeratKotor";
            LBeratKotor.Size = new Size(125, 20);
            LBeratKotor.TabIndex = 6;
            LBeratKotor.Text = "Berat Kotor (kg):";
            // 
            // txtBeratKotor
            // 
            txtBeratKotor.Location = new Point(152, 107);
            txtBeratKotor.Name = "txtBeratKotor";
            txtBeratKotor.Size = new Size(255, 25);
            txtBeratKotor.TabIndex = 7;
            // 
            // LBeratBersih
            // 
            LBeratBersih.AutoSize = true;
            LBeratBersih.Location = new Point(10, 140);
            LBeratBersih.Name = "LBeratBersih";
            LBeratBersih.Size = new Size(132, 20);
            LBeratBersih.TabIndex = 8;
            LBeratBersih.Text = "Berat Bersih (kg):";
            // 
            // txtBeratBersih
            // 
            txtBeratBersih.BackColor = Color.White;
            txtBeratBersih.ForeColor = Color.Gray;
            txtBeratBersih.Location = new Point(152, 137);
            txtBeratBersih.Name = "txtBeratBersih";
            txtBeratBersih.ReadOnly = true;
            txtBeratBersih.Size = new Size(255, 25);
            txtBeratBersih.TabIndex = 9;
            txtBeratBersih.Text = "Otomatis dihitung";
         
            // 
            // LKualitas
            // 
            LKualitas.AutoSize = true;
            LKualitas.Location = new Point(10, 170);
            LKualitas.Name = "LKualitas";
            LKualitas.Size = new Size(69, 20);
            LKualitas.TabIndex = 10;
            LKualitas.Text = "Kualitas:";
            // 
            // cbKualitas
            // 
            cbKualitas.DropDownStyle = ComboBoxStyle.DropDownList;
            cbKualitas.FormattingEnabled = true;
            cbKualitas.Location = new Point(152, 165);
            cbKualitas.Name = "cbKualitas";
            cbKualitas.Size = new Size(255, 28);
            cbKualitas.TabIndex = 11;
            // 
            // LCatatan
            // 
            LCatatan.AutoSize = true;
            LCatatan.Location = new Point(10, 200);
            LCatatan.Name = "LCatatan";
            LCatatan.Size = new Size(70, 20);
            LCatatan.TabIndex = 12;
            LCatatan.Text = "Catatan:";
           
            // 
            // txtCatatan
            // 
            txtCatatan.Location = new Point(152, 197);
            txtCatatan.Multiline = true;
            txtCatatan.Name = "txtCatatan";
            txtCatatan.Size = new Size(255, 52);
            txtCatatan.TabIndex = 13;
            // 
            // GGaris
            // 
            GGaris.BackColor = Color.Gray;
            GGaris.Location = new Point(10, 265);
            GGaris.Name = "GGaris";
            GGaris.Size = new Size(397, 1);
            GGaris.TabIndex = 14;
            // 
            // btSimpan
            // 
            btSimpan.BackColor = Color.Beige;
            btSimpan.Location = new Point(236, 282);
            btSimpan.Name = "btSimpan";
            btSimpan.Size = new Size(85, 37);
            btSimpan.TabIndex = 15;
            btSimpan.Text = "Simpan";
            btSimpan.UseVisualStyleBackColor = false;
            btSimpan.Click += btSimpan_Click;
            // 
            // btBatal
            // 
            btBatal.BackColor = Color.Beige;
            btBatal.Location = new Point(327, 282);
            btBatal.Name = "btBatal";
            btBatal.Size = new Size(80, 37);
            btBatal.TabIndex = 16;
            btBatal.Text = "Batal";
            btBatal.UseVisualStyleBackColor = false;
            // 
            // BCInputHasilPanen
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Beige;
            ClientSize = new Size(617, 376);
            Controls.Add(btBatal);
            Controls.Add(btSimpan);
            Controls.Add(GGaris);
            Controls.Add(txtCatatan);
            Controls.Add(LCatatan);
            Controls.Add(cbKualitas);
            Controls.Add(LKualitas);
            Controls.Add(txtBeratBersih);
            Controls.Add(LBeratBersih);
            Controls.Add(txtBeratKotor);
            Controls.Add(LBeratKotor);
            Controls.Add(cbKomoditas);
            Controls.Add(Lkomoditas);
            Controls.Add(dtpTanggalPanen);
            Controls.Add(LTanggalPanen);
            Controls.Add(LNamaPetani);
            Controls.Add(LPetani);
            Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "BCInputHasilPanen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Input Hasil Panen";
            Load += InputDataHasilPanen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LPetani;
        private Label LNamaPetani;
        private Label LTanggalPanen;
        private DateTimePicker dtpTanggalPanen;
        private Label Lkomoditas;
        private ComboBox cbKomoditas;
        private Label LBeratKotor;
        private TextBox txtBeratKotor;
        private Label LBeratBersih;
        private TextBox txtBeratBersih;
        private Label LKualitas;
        private ComboBox cbKualitas;
        private Label LCatatan;
        private TextBox txtCatatan;
        private Panel GGaris;
        private Button btSimpan;
        private Button btBatal;
    }
}