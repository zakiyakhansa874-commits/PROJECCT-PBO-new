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
            GWarning.Location = new Point(38, 62);
            GWarning.Margin = new Padding(4);
            GWarning.Name = "GWarning";
            GWarning.Size = new Size(62, 62);
            GWarning.SizeMode = PictureBoxSizeMode.StretchImage;
            GWarning.TabIndex = 0;
            GWarning.TabStop = false;
            // 
            // JJudul
            // 
            JJudul.AutoSize = true;
            JJudul.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            JJudul.Location = new Point(126, 62);
            JJudul.Margin = new Padding(4, 0, 4, 0);
            JJudul.Name = "JJudul";
            JJudul.Size = new Size(234, 29);
            JJudul.TabIndex = 1;
            JJudul.Text = "Yakin ingin keluar?";
            JJudul.Click += label1_Click;
            // 
            // SJKeluar
            // 
            SJKeluar.AutoSize = true;
            SJKeluar.ForeColor = SystemColors.GrayText;
            SJKeluar.Location = new Point(125, 112);
            SJKeluar.Margin = new Padding(4, 0, 4, 0);
            SJKeluar.Name = "SJKeluar";
            SJKeluar.Size = new Size(438, 50);
            SJKeluar.TabIndex = 2;
            SJKeluar.Text = "Anda akan keluar dari sesi sebagai Pak Hendra.\nSemua perubahan yang belum tersimpan akan hilang.";
            SJKeluar.Click += label1_Click_1;
            // 
            // GGaris
            // 
            GGaris.BackColor = SystemColors.ButtonShadow;
            GGaris.Location = new Point(25, 225);
            GGaris.Margin = new Padding(4);
            GGaris.Name = "GGaris";
            GGaris.Size = new Size(600, 2);
            GGaris.TabIndex = 3;
            // 
            // btKeluar
            // 
            btKeluar.BackColor = Color.Beige;
            btKeluar.Location = new Point(275, 262);
            btKeluar.Margin = new Padding(4);
            btKeluar.Name = "btKeluar";
            btKeluar.Size = new Size(162, 44);
            btKeluar.TabIndex = 4;
            btKeluar.Text = "Ya, Keluar";
            btKeluar.UseVisualStyleBackColor = false;
            btKeluar.Click += btKeluar_Click;
            // 
            // btBatal
            // 
            btBatal.BackColor = Color.Beige;
            btBatal.ForeColor = Color.Black;
            btBatal.Location = new Point(462, 262);
            btBatal.Margin = new Padding(4);
            btBatal.Name = "btBatal";
            btBatal.Size = new Size(162, 44);
            btBatal.TabIndex = 5;
            btBatal.Text = "Batal";
            btBatal.UseVisualStyleBackColor = false;
            btBatal.Click += btBatal_Click_1;
            // 
            // FormKonfirmasiKeluar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(818, 425);
            Controls.Add(btBatal);
            Controls.Add(btKeluar);
            Controls.Add(GGaris);
            Controls.Add(SJKeluar);
            Controls.Add(JJudul);
            Controls.Add(GWarning);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
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