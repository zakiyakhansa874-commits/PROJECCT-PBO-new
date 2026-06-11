namespace TugasProject_PBO.Views.Admin
{
    partial class KelolaHasilPanen
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
            LTanggal = new Label();
            LKomoditas = new Label();
            LBeratKotor = new Label();
            LBeratBersih = new Label();
            LKualitas = new Label();
            LCatatan = new Label();
            cbPetani = new ComboBox();
            dtpTanggal = new DateTimePicker();
            cbKomoditas = new ComboBox();
            txtBeratKotor = new TextBox();
            txtBeratBersih = new TextBox();
            cbKualitas = new ComboBox();
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
            LPetani.Size = new Size(53, 18);
            LPetani.TabIndex = 0;
            LPetani.Text = "Petani:";
            // 
            // LTanggal
            // 
            LTanggal.AutoSize = true;
            LTanggal.Location = new Point(10, 50);
            LTanggal.Name = "LTanggal";
            LTanggal.Size = new Size(64, 18);
            LTanggal.TabIndex = 1;
            LTanggal.Text = "Tanggal:";
            LTanggal.Click += label2_Click;
            // 
            // LKomoditas
            // 
            LKomoditas.AutoSize = true;
            LKomoditas.BackColor = Color.Beige;
            LKomoditas.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LKomoditas.Location = new Point(10, 80);
            LKomoditas.Name = "LKomoditas";
            LKomoditas.Size = new Size(84, 18);
            LKomoditas.TabIndex = 2;
            LKomoditas.Text = "Komoditas:";
            // 
            // LBeratKotor
            // 
            LBeratKotor.AutoSize = true;
            LBeratKotor.Location = new Point(10, 110);
            LBeratKotor.Name = "LBeratKotor";
            LBeratKotor.Size = new Size(118, 18);
            LBeratKotor.TabIndex = 3;
            LBeratKotor.Text = "Berat Kotor (kg):";
            // 
            // LBeratBersih
            // 
            LBeratBersih.AutoSize = true;
            LBeratBersih.Location = new Point(10, 140);
            LBeratBersih.Name = "LBeratBersih";
            LBeratBersih.Size = new Size(123, 18);
            LBeratBersih.TabIndex = 4;
            LBeratBersih.Text = "Berat Bersih (kg):";
            // 
            // LKualitas
            // 
            LKualitas.AutoSize = true;
            LKualitas.Location = new Point(10, 170);
            LKualitas.Name = "LKualitas";
            LKualitas.Size = new Size(64, 18);
            LKualitas.TabIndex = 5;
            LKualitas.Text = "Kualitas:";
            // 
            // LCatatan
            // 
            LCatatan.AutoSize = true;
            LCatatan.Location = new Point(10, 200);
            LCatatan.Name = "LCatatan";
            LCatatan.Size = new Size(63, 18);
            LCatatan.TabIndex = 6;
            LCatatan.Text = "Catatan:";
            // 
            // cbPetani
            // 
            cbPetani.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPetani.FormattingEnabled = true;
            cbPetani.Location = new Point(130, 15);
            cbPetani.Name = "cbPetani";
            cbPetani.Size = new Size(260, 26);
            cbPetani.TabIndex = 7;
            // 
            // dtpTanggal
            // 
            dtpTanggal.Format = DateTimePickerFormat.Short;
            dtpTanggal.Location = new Point(130, 45);
            dtpTanggal.Name = "dtpTanggal";
            dtpTanggal.Size = new Size(260, 24);
            dtpTanggal.TabIndex = 8;
            // 
            // cbKomoditas
            // 
            cbKomoditas.DropDownStyle = ComboBoxStyle.DropDownList;
            cbKomoditas.FormattingEnabled = true;
            cbKomoditas.Location = new Point(130, 75);
            cbKomoditas.Name = "cbKomoditas";
            cbKomoditas.Size = new Size(260, 26);
            cbKomoditas.TabIndex = 9;
            // 
            // txtBeratKotor
            // 
            txtBeratKotor.Location = new Point(130, 105);
            txtBeratKotor.Name = "txtBeratKotor";
            txtBeratKotor.Size = new Size(260, 24);
            txtBeratKotor.TabIndex = 10;
            // 
            // txtBeratBersih
            // 
            txtBeratBersih.Location = new Point(130, 135);
            txtBeratBersih.Name = "txtBeratBersih";
            txtBeratBersih.Size = new Size(260, 24);
            txtBeratBersih.TabIndex = 11;
            // 
            // cbKualitas
            // 
            cbKualitas.DropDownStyle = ComboBoxStyle.DropDownList;
            cbKualitas.FormattingEnabled = true;
            cbKualitas.Location = new Point(130, 165);
            cbKualitas.Name = "cbKualitas";
            cbKualitas.Size = new Size(260, 26);
            cbKualitas.TabIndex = 12;
            // 
            // txtCatatan
            // 
            txtCatatan.Location = new Point(130, 195);
            txtCatatan.Multiline = true;
            txtCatatan.Name = "txtCatatan";
            txtCatatan.Size = new Size(260, 40);
            txtCatatan.TabIndex = 13;
            // 
            // GGaris
            // 
            GGaris.BackColor = Color.Silver;
            GGaris.Location = new Point(15, 255);
            GGaris.Name = "GGaris";
            GGaris.Size = new Size(370, 1);
            GGaris.TabIndex = 14;
            // 
            // btSimpan
            // 
            btSimpan.BackColor = Color.Beige;
            btSimpan.Location = new Point(187, 262);
            btSimpan.Name = "btSimpan";
            btSimpan.Size = new Size(75, 29);
            btSimpan.TabIndex = 15;
            btSimpan.Text = "Simpan";
            btSimpan.UseVisualStyleBackColor = false;
            // 
            // btBatal
            // 
            btBatal.BackColor = Color.Beige;
            btBatal.Location = new Point(282, 262);
            btBatal.Name = "btBatal";
            btBatal.Size = new Size(75, 29);
            btBatal.TabIndex = 16;
            btBatal.Text = "Batal";
            btBatal.UseVisualStyleBackColor = false;
            // 
            // KelolaHasilPanen
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(402, 303);
            Controls.Add(btBatal);
            Controls.Add(btSimpan);
            Controls.Add(GGaris);
            Controls.Add(txtCatatan);
            Controls.Add(cbKualitas);
            Controls.Add(txtBeratBersih);
            Controls.Add(txtBeratKotor);
            Controls.Add(cbKomoditas);
            Controls.Add(dtpTanggal);
            Controls.Add(cbPetani);
            Controls.Add(LCatatan);
            Controls.Add(LKualitas);
            Controls.Add(LBeratBersih);
            Controls.Add(LBeratKotor);
            Controls.Add(LKomoditas);
            Controls.Add(LTanggal);
            Controls.Add(LPetani);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "KelolaHasilPanen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit Hasil Panen";
            Load += KelolaHasilPanen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LPetani;
        private Label LTanggal;
        private Label LKomoditas;
        private Label LBeratKotor;
        private Label LBeratBersih;
        private Label LKualitas;
        private Label LCatatan;
        private ComboBox cbPetani;
        private DateTimePicker dtpTanggal;
        private ComboBox cbKomoditas;
        private TextBox txtBeratKotor;
        private TextBox txtBeratBersih;
        private ComboBox cbKualitas;
        private TextBox txtCatatan;
        private Panel GGaris;
        private Button btSimpan;
        private Button btBatal;
    }
}