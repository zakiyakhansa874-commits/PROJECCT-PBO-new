using System;
using System.Collections.Generic;
using inventory_panen_mvc.Models;
//using inventory_panen_mvc.Views;
using System.Windows.Forms;

//namespace inventory_panen_mvc.Controllers
//{
//    public class HasilPanenController
//    {
//        private DataPanenForm view;
//        private HasilPanenContext context;

//        public HasilPanenController(DataPanenForm dataPanenForm)
//        {
//            this.view = dataPanenForm;
//            this.context = new HasilPanenContext();
//        }
        
//        public void LoadDataPanen()
//        {
//            List<HasilPanen> list = context.GetAll();
//            view.GridDataPanen.DataSource = list; // Binding list data langsung ke DataGridView di UI
//        }

//        public void AddDataPanen()
//        {
//            try
//            {
//                HasilPanen baru = new HasilPanen
//                {
//                    NamaKomoditas = view.TxtKomoditas.Text,
//                    Berat = Convert.ToDouble(view.TxtBerat.Text),
//                    TanggalPanen = view.DtpTanggal.Value,
//                    Kualitas = view.CboKualitas.SelectedItem.ToString()
//                };

//                if (context.Insert(baru))
//                {
//                    MessageBox.Show("Data Hasil Panen berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                    LoadDataPanen(); // Refresh Tabel
//                }
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Terjadi kesalahan input: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }
//    }
//}