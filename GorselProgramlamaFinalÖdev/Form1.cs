using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorselProgramlamaFinalÖdev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "GİRİŞ YAP";
            Random random = new Random();
            labelGCode.Text = random.Next(100, 9999).ToString();
            pictureBoxKontrol.Image = Properties.Resources.dur;
            pictureBoxKontrol.SizeMode = PictureBoxSizeMode.Zoom;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (labelGCode.Text == textBox1.Text)
            {
                pictureBoxKontrol.Image = Properties.Resources.geç;
                MessageBox.Show("giriş başarılı");
                FormVeriGir fr2 = new FormVeriGir();
                fr2.Show();
            }
            else
            {
                MessageBox.Show("girdiğiniz kod yanlıştır" , "hata", MessageBoxButtons.OK);
            }
        }
    }
}
