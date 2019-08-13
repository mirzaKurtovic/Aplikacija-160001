using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wellness.Model;
using Wellness.WinUI.Clanarina;
using Wellness.WinUI.Menadzment;
using Wellness.WinUI.Trening;
namespace Wellness.WinUI
{
    public partial class frmIndex : Form
    {
        private int childFormNumber = 0;
        private readonly Radnik _radnik;
        private  Trener _trener = null;
        private readonly APIService _apiService_Trener = new APIService("Trener");
        public frmIndex(Radnik radnik)
        {
            InitializeComponent();
            _radnik = radnik;
            
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void PregledToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClanarine frm = new frmClanarine();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
           
        }

        private void NovaClanarinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClanarinaDetalji frm = new frmClanarinaDetalji();
            frm.MdiParent = this;
            frm.Show();
        }

        private void PregledToolStripMenuItem1_Click(object sender, EventArgs e)
        {


            frmTrening frm = new frmTrening(_trener);
            frm.MdiParent = this;
            frm.Show();
        }

        private void NoviTreningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTreningDetalji frm = new frmTreningDetalji(null,_trener);
            frm.MdiParent = this;
            frm.Show();
        }

        private void NoviRadnikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRadniciDetalji frm= new frmRadniciDetalji();
            frm.Show();
        }

        private async void FrmIndex_Load(object sender, EventArgs e)
        {
            if (_radnik.Osoba.Uloga.Naziv == "Trener")
            {
                menadzmentToolStripMenuItem.Visible = false;
                treningToolStripMenuItem.Visible = true;
                clanarinaToolStripMenuItem.Visible = false;


                
                    var TrenerSearchRequest = new Model.Requests.TrenerSearchRequest()
                    {
                        OsobaId = _radnik.OsobaId
                    };

                    var TrenerList =await _apiService_Trener.Get<List<Wellness.Model.Trener>>(TrenerSearchRequest);
                    _trener = TrenerList[0];

                


            }
            if (_radnik.Osoba.Uloga.Naziv == "Recepcionar")
            {
                menadzmentToolStripMenuItem.Visible = false;
                treningToolStripMenuItem.Visible = false;
                clanarinaToolStripMenuItem.Visible = true;
            }
            if (_radnik.Osoba.Uloga.Naziv == "Menadzer")
            {
                menadzmentToolStripMenuItem.Visible = true;
                treningToolStripMenuItem.Visible = false;
                clanarinaToolStripMenuItem.Visible = true;
            }
        }

        private void PregledToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmRadnici frm = new frmRadnici(_radnik);
            frm.Show();
            frm.MdiParent = this;

        }

        private void IsplataRadnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIsplataRadnika frm = new frmIsplataRadnika();
            frm.Show();
        }

        private void IzvjestavanjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIzvjestaj frm = new frmIzvjestaj();
            frm.Show();
        }

        private void TipTreningaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Menadzment.TipTreninga();
            frm.Show();
        }
    }
}
