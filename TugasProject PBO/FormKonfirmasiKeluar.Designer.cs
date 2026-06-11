namespace TugasProject_PBO
{
    partial class FormKonfirmasiKeluar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKonfirmasiKeluar));
            GWarning = new PictureBox();
            JJudul = new Label();
            SJKeluar = new Label();
            GGaris = new Panel();
            btKeluar = new Button();
            btBatal = new Button();
            ((System.ComponentModel.ISupportInitialize)GWarning).BeginInit();
            SuspendLayout();
            // 
            // GWarning
            // 
            GWarning.BackColor = Color.Transparent;
            GWarning.Image = (Image)resources.GetObject("GWarning.Image");
            GWarning.Location = new Point(30, 50);
            GWarning.Name = "GWarning";
            GWarning.Size = new Size(50, 50);
            GWarning.SizeMode = PictureBoxSizeMode.StretchImage;
            GWarning.TabIndex = 0;
            GWarning.TabStop = false;
            // 
            // JJudul
            // 
            JJudul.AutoSize = true;
            JJudul.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            JJudul.Location = new Point(101, 50);
            JJudul.Name = "JJudul";
            JJudul.Size = new Size(195, 25);
            JJudul.TabIndex = 1;
            JJudul.Text = "Yakin ingin keluar?";
            JJudul.Click += label1_Click;
            // 
            // SJKeluar
            // 
            SJKeluar.AutoSize = true;
            SJKeluar.ForeColor = SystemColors.GrayText;
            SJKeluar.Location = new Point(100, 90);
            SJKeluar.Name = "SJKeluar";
            SJKeluar.Size = new Size(364, 40);
            SJKeluar.TabIndex = 2;
            SJKeluar.Text = "Anda akan keluar dari sesi sebagai Pak Hendra.\nSemua perubahan yang belum tersimpan akan hilang.";
            SJKeluar.Click += label1_Click_1;
            // 
            // GGaris
            // 
            GGaris.BackColor = SystemColors.ButtonShadow;
            GGaris.Location = new Point(20, 180);
            GGaris.Name = "GGaris";
            GGaris.Size = new Size(480, 2);
            GGaris.TabIndex = 3;
            // 
            // btKeluar
            // 
            btKeluar.BackColor = Color.Beige;
            btKeluar.Location = new Point(220, 210);
            btKeluar.Name = "btKeluar";
            btKeluar.Size = new Size(130, 35);
            btKeluar.TabIndex = 4;
            btKeluar.Text = "Ya, Keluar";
            btKeluar.UseVisualStyleBackColor = false;
            btKeluar.Click += btKeluar_Click;
            // 
            // btBatal
            // 
            btBatal.BackColor = Color.Beige;
            btBatal.ForeColor = Color.Black;
            btBatal.Location = new Point(370, 210);
            btBatal.Name = "btBatal";
            btBatal.Size = new Size(130, 35);
            btBatal.TabIndex = 5;
            btBatal.Text = "Batal";
            btBatal.UseVisualStyleBackColor = false;
            // 
            // FormKonfirmasiKeluar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(532, 253);
            Controls.Add(btBatal);
            Controls.Add(btKeluar);
            Controls.Add(GGaris);
            Controls.Add(SJKeluar);
            Controls.Add(JJudul);
            Controls.Add(GWarning);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormKonfirmasiKeluar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Konfirmasi Keluar";
            Load += FormKonfirmasiKeluar_Load;
            ((System.ComponentModel.ISupportInitialize)GWarning).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox GWarning;
        private Label JJudul;
        private Label SJKeluar;
        private Panel GGaris;
        private Button btKeluar;
        private Button btBatal;
    }
}