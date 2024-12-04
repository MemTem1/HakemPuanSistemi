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
    public partial class FormVeriGir : Form
    {
        
        public FormVeriGir()
        {
            InitializeComponent();
        }
        OleDbConnection VeriBaglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VERİLER.accdb");
        private void temizle()
        {
            textBoxAd.Text = "";
            textBoxSoyad.Text = "";
            comboBoxCinsiyet.SelectedIndex = -1;
            comboBoxUlke.SelectedIndex = -1;
            comboBox1.SelectedItem = null;
            comboBox2.SelectedItem = null;
            comboBox3.SelectedItem = null;
            comboBox4.SelectedItem = null;
            comboBox5.SelectedIndex = -1;
            pictureBox1.Image = null;

        }
        private void comboSehir()
        {
            
            String[] Sehirler = { "ABD", "TÜRKİYE", "NORVEÇ", "KANADA", "FRANSA", "İRAN", "BREZİLYA", "BULGARİSTAN" };
            comboBoxUlke.Items.AddRange(Sehirler);

            String[] cinsiyet = { "KADIN", "ERKEK" };
            comboBoxCinsiyet.Items.AddRange(cinsiyet);
            
        }
        private void FormVeriGir_Load(object sender, EventArgs e)
        {
            for (int İ = 1; İ <= 10; İ++)
            {
                comboBox1.Items.Add(İ);
                comboBox2.Items.Add(İ);
                comboBox3.Items.Add(İ);
                comboBox4.Items.Add(İ);
                comboBox5.Items.Add(İ);
            }
            pictureBox1.SizeMode  = PictureBoxSizeMode.Zoom;
            comboSehir();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void verileriEkle()
        {
            try
            {
                VeriBaglanti.Open();
                string veri = "INSERT INTO VERİ (AD, SOYAD, CİNSİYET, ULKE, PUAN, RESİM) VALUES (@AD, @SOYAD, @CİNSİYET ,@ULKE, @PUAN, @RESİM)";
                OleDbCommand Ekle = new OleDbCommand(veri, VeriBaglanti);
                Ekle.Parameters.AddWithValue("@AD", textBoxAd.Text);
                Ekle.Parameters.AddWithValue("@SOYAD", textBoxSoyad.Text);
                Ekle.Parameters.AddWithValue("@CİNSİYET", comboBoxCinsiyet.Text);
                Ekle.Parameters.AddWithValue("@ULKE", comboBoxUlke.Text);
                Ekle.Parameters.AddWithValue("@PUAN", buttonPuanSonuc.Text);
                Ekle.Parameters.AddWithValue("@RESİM", ResimYolu);
                Ekle.ExecuteNonQuery();
                MessageBox.Show("veriler kayıt edildi");
                VeriBaglanti.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("veri tabanında hata => "+ex+"");
            }
            finally
            {
                VeriBaglanti.Close();
            }

        }

        private void buttonCıkıs_Click(object sender, EventArgs e)
        {
            DialogResult quit = MessageBox.Show("çıkımak istediğine emin misin", "uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (quit == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
        string ResimYolu;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.ShowDialog();
            ResimYolu  = fileDialog.FileName;
            pictureBox1.ImageLocation = ResimYolu;

        }

        private void PuanHesap()
        {
            try
            {
                double h1 = Convert.ToDouble(comboBox1.SelectedItem);
                double h2 = Convert.ToDouble(comboBox2.SelectedItem);
                double h3 = Convert.ToDouble(comboBox3.SelectedItem);
                double h4 = Convert.ToDouble(comboBox4.SelectedItem);
                double h5 = Convert.ToDouble(comboBox5.SelectedItem);
                double ortalama = (h1 + h2 + h3 + h4 + h5) / 5;
                buttonPuanSonuc.Text = ortalama.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonOyVer_Click(object sender, EventArgs e)
        {
            PuanHesap();
            verileriEkle();
            
        }

        private void buttonSonucGoster_Click(object sender, EventArgs e)
        {
            FormSonucGoster formSouc = new FormSonucGoster();
            formSouc.Show();
        }
    }
}
