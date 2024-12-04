using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorselProgramlamaFinalÖdev
{
    public partial class FormSonucGoster : Form
    {
        OleDbConnection VeriBaglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VERİLER.accdb");
        public FormSonucGoster()
        {
            InitializeComponent();
        }

        private void FormSonucGoster_Load(object sender, EventArgs e)
        {
            string veriGetir =  "SELECT * FROM VERİ ORDER BY PUAN ASC";
            VeriBaglanti.Open();
            DataSet Ds  = new DataSet();
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter( veriGetir , VeriBaglanti);
            dataAdapter.Fill(Ds, "VERİ");
            dataGridView1.DataSource = Ds.Tables["veri"];
            
            VeriBaglanti.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            FormBilgiKart bilgiKarti  =new FormBilgiKart();
            bilgiKarti.ULKE = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            bilgiKarti.AD = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            bilgiKarti.PUAN = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            bilgiKarti.RESİM = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            bilgiKarti.Show();
        }
    }
}
