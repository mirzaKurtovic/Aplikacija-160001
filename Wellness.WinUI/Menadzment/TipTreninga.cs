using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wellness.Model.Requests;

namespace Wellness.WinUI.Menadzment
{
    public partial class TipTreninga : Form
    {
        TipTreningaInsertRequest request = new TipTreningaInsertRequest();
        APIService _apiService_tipTreninga = new APIService("TipTreninga");
        public TipTreninga()
        {
            InitializeComponent();



        }

        private void TipTreninga_Load(object sender, EventArgs e)
        {


        }

        private void BtnSlikaNova_Click(object sender, EventArgs e)
        {
            // open file dialog   
            var open = openFileDialog1;
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;

                var file = File.ReadAllBytes(fileName);

                request.Image = file;
                txtSlika.Text = fileName;

                Image image = Image.FromFile(fileName);
                pbSlika.Image = image;
            }
        }

        private async void BtnSacuvaj_Click(object sender, EventArgs e)
        {
            request.TipTreninga1 = txtNaziv.Text;
            request.Opis = txtOpis.Text;


            var tt =await _apiService_tipTreninga.Insert<Wellness.Model.TipTreninga>(request);
            Close();


        }
    }
}
