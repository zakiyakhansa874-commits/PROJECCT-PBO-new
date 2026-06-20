namespace TugasProject_PBO.Views.Admin
{
    partial class InputStokKeluar5
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
            LTanggal5 = new Label();
            LGudang = new Label();
            LPetani5 = new Label();
            LJumlah5 = new Label();
            LKualitas5 = new Label();
            LCatatan5 = new Label();
            tbJumlah5 = new TextBox();
            tbCatatan5 = new TextBox();
            btSimpan5 = new Button();
            btBatal5 = new Button();
            panel1 = new Panel();
            comboBox1 = new ComboBox();
            cbGudang5 = new ComboBox();
            dtpTanggal5 = new DateTimePicker();
            cbKualitas5 = new ComboBox();
            cbAdmin5 = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // LTanggal5
            // 
            LTanggal5.AutoSize = true;
            LTanggal5.Location = new Point(40, 38);
            LTanggal5.Margin = new Padding(4, 0, 4, 0);
            LTanggal5.Name = "LTanggal5";
            LTanggal5.Size = new Size(77, 25);
            LTanggal5.TabIndex = 0;
            LTanggal5.Text = "Tanggal:";
            LTanggal5.Click += LTanggal5_Click;
            // 
            // LGudang
            // 
            LGudang.AutoSize = true;
            LGudang.Location = new Point(40, 85);
            LGudang.Margin = new Padding(4, 0, 4, 0);
            LGudang.Name = "LGudang";
            LGudang.Size = new Size(79, 25);
            LGudang.TabIndex = 1;
            LGudang.Text = "Gudang:";
            LGudang.Click += LGudang_Click;
            // 
            // LPetani5
            // 
            LPetani5.AutoSize = true;
            LPetani5.Location = new Point(40, 131);
            LPetani5.Margin = new Padding(4, 0, 4, 0);
            LPetani5.Name = "LPetani5";
            LPetani5.Size = new Size(69, 25);
            LPetani5.TabIndex = 2;
            LPetani5.Text = "Admin:";
            LPetani5.TextAlign = ContentAlignment.TopCenter;
            LPetani5.Click += L_Petani9_Click;
            // 
            // LJumlah5
            // 
            LJumlah5.AutoSize = true;
            LJumlah5.Location = new Point(40, 176);
            LJumlah5.Margin = new Padding(4, 0, 4, 0);
            LJumlah5.Name = "LJumlah5";
            LJumlah5.Size = new Size(106, 25);
            LJumlah5.TabIndex = 3;
            LJumlah5.Text = "Jumlah (kg):";
            // 
            // LKualitas5
            // 
            LKualitas5.AutoSize = true;
            LKualitas5.Location = new Point(40, 222);
            LKualitas5.Margin = new Padding(4, 0, 4, 0);
            LKualitas5.Name = "LKualitas5";
            LKualitas5.Size = new Size(76, 25);
            LKualitas5.TabIndex = 4;
            LKualitas5.Text = "Kualitas:";
            // 
            // LCatatan5
            // 
            LCatatan5.AutoSize = true;
            LCatatan5.Location = new Point(41, 268);
            LCatatan5.Margin = new Padding(4, 0, 4, 0);
            LCatatan5.Name = "LCatatan5";
            LCatatan5.Size = new Size(76, 25);
            LCatatan5.TabIndex = 5;
            LCatatan5.Text = "Catatan:";
            // 
            // tbJumlah5
            // 
            tbJumlah5.Location = new Point(154, 176);
            tbJumlah5.Margin = new Padding(4, 4, 4, 4);
            tbJumlah5.Name = "tbJumlah5";
            tbJumlah5.Size = new Size(389, 31);
            tbJumlah5.TabIndex = 9;
            // 
            // tbCatatan5
            // 
            tbCatatan5.Location = new Point(154, 268);
            tbCatatan5.Margin = new Padding(4, 4, 4, 4);
            tbCatatan5.Multiline = true;
            tbCatatan5.Name = "tbCatatan5";
            tbCatatan5.Size = new Size(389, 62);
            tbCatatan5.TabIndex = 11;
            tbCatatan5.TextChanged += textBox6_TextChanged;
            // 
            // btSimpan5
            // 
            btSimpan5.Location = new Point(301, 370);
            btSimpan5.Margin = new Padding(4, 4, 4, 4);
            btSimpan5.Name = "btSimpan5";
            btSimpan5.Size = new Size(118, 36);
            btSimpan5.TabIndex = 12;
            btSimpan5.Text = "Simpan";
            btSimpan5.UseVisualStyleBackColor = true;
            btSimpan5.Click += btSimpan5_Click;
            // 
            // btBatal5
            // 
            btBatal5.Location = new Point(426, 370);
            btBatal5.Margin = new Padding(4, 4, 4, 4);
            btBatal5.Name = "btBatal5";
            btBatal5.Size = new Size(118, 36);
            btBatal5.TabIndex = 13;
            btBatal5.Text = "Batal";
            btBatal5.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(comboBox1);
            panel1.Location = new Point(54, 349);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(490, 1);
            panel1.TabIndex = 14;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(0, 0);
            comboBox1.Margin = new Padding(4, 4, 4, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(188, 33);
            comboBox1.TabIndex = 0;
            // 
            // cbGudang5
            // 
            cbGudang5.FormattingEnabled = true;
            cbGudang5.Location = new Point(154, 81);
            cbGudang5.Margin = new Padding(4, 4, 4, 4);
            cbGudang5.Name = "cbGudang5";
            cbGudang5.Size = new Size(389, 33);
            cbGudang5.TabIndex = 15;
            // 
            // dtpTanggal5
            // 
            dtpTanggal5.Format = DateTimePickerFormat.Short;
            dtpTanggal5.Location = new Point(154, 31);
            dtpTanggal5.Margin = new Padding(4, 4, 4, 4);
            dtpTanggal5.Name = "dtpTanggal5";
            dtpTanggal5.Size = new Size(389, 31);
            dtpTanggal5.TabIndex = 16;
            dtpTanggal5.ValueChanged += dtpTanggal5_ValueChanged;
            // 
            // cbKualitas5
            // 
            cbKualitas5.FormattingEnabled = true;
            cbKualitas5.Location = new Point(154, 219);
            cbKualitas5.Margin = new Padding(4, 4, 4, 4);
            cbKualitas5.Name = "cbKualitas5";
            cbKualitas5.Size = new Size(389, 33);
            cbKualitas5.TabIndex = 17;
            // 
            // cbAdmin5
            // 
            cbAdmin5.FormattingEnabled = true;
            cbAdmin5.Location = new Point(154, 128);
            cbAdmin5.Margin = new Padding(4, 4, 4, 4);
            cbAdmin5.Name = "cbAdmin5";
            cbAdmin5.Size = new Size(389, 33);
            cbAdmin5.TabIndex = 18;
            cbAdmin5.SelectedIndexChanged += cbAdmin5_SelectedIndexChanged;
            // 
            // InputStokKeluar5
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(722, 421);
            Controls.Add(cbAdmin5);
            Controls.Add(cbKualitas5);
            Controls.Add(dtpTanggal5);
            Controls.Add(cbGudang5);
            Controls.Add(panel1);
            Controls.Add(btBatal5);
            Controls.Add(btSimpan5);
            Controls.Add(tbCatatan5);
            Controls.Add(tbJumlah5);
            Controls.Add(LCatatan5);
            Controls.Add(LKualitas5);
            Controls.Add(LJumlah5);
            Controls.Add(LPetani5);
            Controls.Add(LGudang);
            Controls.Add(LTanggal5);
            Margin = new Padding(4, 4, 4, 4);
            Name = "InputStokKeluar5";
            Text = "Tambah Stok Keluar ";
            Load += InputStokKeluar_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LTanggal5;
        private Label LGudang;
        private Label LPetani5;
        private Label LJumlah5;
        private Label LKualitas5;
        private Label LCatatan5;
        private TextBox tbJumlah5;
        private TextBox tbCatatan5;
        private Button btSimpan5;
        private Button btBatal5;
        private Panel panel1;
        private ComboBox comboBox1;
        private ComboBox cbGudang5;
        private DateTimePicker dtpTanggal5;
        private ComboBox cbKualitas5;
        private ComboBox cbAdmin5;
    }
}