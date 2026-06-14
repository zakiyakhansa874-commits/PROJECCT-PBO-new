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
            tbTanggal5 = new TextBox();
            tbGudang5 = new TextBox();
            tbPetani5 = new TextBox();
            tbJumlah5 = new TextBox();
            tbKualitas5 = new TextBox();
            tbCatatan5 = new TextBox();
            btSimpan5 = new Button();
            btBatal5 = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // LTanggal5
            // 
            LTanggal5.AutoSize = true;
            LTanggal5.Location = new Point(32, 30);
            LTanggal5.Name = "LTanggal5";
            LTanggal5.Size = new Size(64, 20);
            LTanggal5.TabIndex = 0;
            LTanggal5.Text = "Tanggal:";
            // 
            // LGudang
            // 
            LGudang.AutoSize = true;
            LGudang.Location = new Point(32, 68);
            LGudang.Name = "LGudang";
            LGudang.Size = new Size(64, 20);
            LGudang.TabIndex = 1;
            LGudang.Text = "Gudang:";
            // 
            // LPetani5
            // 
            LPetani5.AutoSize = true;
            LPetani5.Location = new Point(32, 105);
            LPetani5.Name = "LPetani5";
            LPetani5.Size = new Size(52, 20);
            LPetani5.TabIndex = 2;
            LPetani5.Text = "Petani:";
            LPetani5.TextAlign = ContentAlignment.TopCenter;
            LPetani5.Click += this.L_Petani9_Click;
            // 
            // LJumlah5
            // 
            LJumlah5.AutoSize = true;
            LJumlah5.Location = new Point(32, 141);
            LJumlah5.Name = "LJumlah5";
            LJumlah5.Size = new Size(88, 20);
            LJumlah5.TabIndex = 3;
            LJumlah5.Text = "Jumlah (kg):";
            // 
            // LKualitas5
            // 
            LKualitas5.AutoSize = true;
            LKualitas5.Location = new Point(32, 178);
            LKualitas5.Name = "LKualitas5";
            LKualitas5.Size = new Size(64, 20);
            LKualitas5.TabIndex = 4;
            LKualitas5.Text = "Kualitas:";
            // 
            // LCatatan5
            // 
            LCatatan5.AutoSize = true;
            LCatatan5.Location = new Point(33, 214);
            LCatatan5.Name = "LCatatan5";
            LCatatan5.Size = new Size(63, 20);
            LCatatan5.TabIndex = 5;
            LCatatan5.Text = "Catatan:";
            // 
            // tbTanggal5
            // 
            tbTanggal5.Location = new Point(123, 30);
            tbTanggal5.Name = "tbTanggal5";
            tbTanggal5.Size = new Size(312, 27);
            tbTanggal5.TabIndex = 6;
            tbTanggal5.TextChanged += this.textBox1_TextChanged;
            // 
            // tbGudang5
            // 
            tbGudang5.Location = new Point(123, 68);
            tbGudang5.Name = "tbGudang5";
            tbGudang5.Size = new Size(312, 27);
            tbGudang5.TabIndex = 7;
            tbGudang5.TextChanged += this.textBox2_TextChanged;
            // 
            // tbPetani5
            // 
            tbPetani5.Location = new Point(123, 105);
            tbPetani5.Name = "tbPetani5";
            tbPetani5.Size = new Size(312, 27);
            tbPetani5.TabIndex = 8;
            tbPetani5.TextChanged += this.textBox3_TextChanged;
            // 
            // tbJumlah5
            // 
            tbJumlah5.Location = new Point(123, 141);
            tbJumlah5.Name = "tbJumlah5";
            tbJumlah5.Size = new Size(312, 27);
            tbJumlah5.TabIndex = 9;
            // 
            // tbKualitas5
            // 
            tbKualitas5.Location = new Point(123, 178);
            tbKualitas5.Name = "tbKualitas5";
            tbKualitas5.Size = new Size(312, 27);
            tbKualitas5.TabIndex = 10;
            // 
            // tbCatatan5
            // 
            tbCatatan5.Location = new Point(123, 214);
            tbCatatan5.Multiline = true;
            tbCatatan5.Name = "tbCatatan5";
            tbCatatan5.Size = new Size(312, 50);
            tbCatatan5.TabIndex = 11;
            tbCatatan5.TextChanged += this.textBox6_TextChanged;
            // 
            // btSimpan5
            // 
            btSimpan5.Location = new Point(241, 296);
            btSimpan5.Name = "btSimpan5";
            btSimpan5.Size = new Size(94, 29);
            btSimpan5.TabIndex = 12;
            btSimpan5.Text = "Simpan";
            btSimpan5.UseVisualStyleBackColor = true;
            btSimpan5.Click += this.button1_Click;
            // 
            // btBatal5
            // 
            btBatal5.Location = new Point(341, 296);
            btBatal5.Name = "btBatal5";
            btBatal5.Size = new Size(94, 29);
            btBatal5.TabIndex = 13;
            btBatal5.Text = "Batal";
            btBatal5.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Location = new Point(43, 279);
            panel1.Name = "panel1";
            panel1.Size = new Size(392, 1);
            panel1.TabIndex = 14;
            // 
            // InputStokKeluar5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(578, 337);
            Controls.Add(panel1);
            Controls.Add(btBatal5);
            Controls.Add(btSimpan5);
            Controls.Add(tbCatatan5);
            Controls.Add(tbKualitas5);
            Controls.Add(tbJumlah5);
            Controls.Add(tbPetani5);
            Controls.Add(tbGudang5);
            Controls.Add(tbTanggal5);
            Controls.Add(LCatatan5);
            Controls.Add(LKualitas5);
            Controls.Add(LJumlah5);
            Controls.Add(LPetani5);
            Controls.Add(LGudang);
            Controls.Add(LTanggal5);
            Name = "InputStokKeluar5";
            Text = "Tambah Stok Keluar ";
            Load += this.InputStokKeluar_Load;
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
        private TextBox tbTanggal5;
        private TextBox tbGudang5;
        private TextBox tbPetani5;
        private TextBox tbJumlah5;
        private TextBox tbKualitas5;
        private TextBox tbCatatan5;
        private Button btSimpan5;
        private Button btBatal5;
        private Panel panel1;
    }
}