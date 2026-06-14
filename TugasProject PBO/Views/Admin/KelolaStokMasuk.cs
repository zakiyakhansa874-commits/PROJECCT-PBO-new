using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TugasProject_PBO.Views.Admin
{
    public partial class KelolaStokMasuk : Form
    {
        public KelolaStokMasuk()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void G_KelolaStokMasuk_Click(object sender, EventArgs e)
        {

        }
        private void BC_MenuBar_Paint2(object sender, PaintEventArgs e)
        {

        }

        private void BC_Page4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btTambah4_Click(object sender, EventArgs e)
        {
            InputStokMasuk4 form = new InputStokMasuk4();
            form.ShowDialog();
        }
    }
}
