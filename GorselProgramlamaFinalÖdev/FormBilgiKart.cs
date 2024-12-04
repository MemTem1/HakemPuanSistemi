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
    public partial class FormBilgiKart : Form
    {
        public FormBilgiKart()
        {
            InitializeComponent();
        }

         public string AD, ULKE, PUAN, RESİM;
        private void FormBilgiKart_Load(object sender, EventArgs e)
        {
            buttonAd.Text = AD;
            buttonPuan.Text = PUAN;
            pictureBoxKisiResim.ImageLocation = RESİM;
            Ulkeler();
            pictureBoxKisiResim.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxUlke.SizeMode = PictureBoxSizeMode.Zoom;
            
        }

        private void Ulkeler()
        {
            switch (ULKE)
            {
                case "TÜRKİYE":
                    pictureBoxUlke.Image = Properties.Resources.türkiye; break;

                case "NORVEÇ":
                    pictureBoxUlke.Image = Properties.Resources.NORVEÇ; break;

                case "ABD":
                    pictureBoxUlke.Image = Properties.Resources.ABD; break;
                
                case "FRANSA":
                    pictureBoxUlke.Image = Properties.Resources.FRANSA; break;

                case "BREZİLYA":
                    pictureBoxUlke.Image = Properties.Resources.BREZİLYA; break;

                case "BULGARİSTAN":
                    pictureBoxUlke.Image = Properties.Resources.BULGARİSTAN; break;

                case "İRAN":
                    pictureBoxUlke.Image = Properties.Resources.İRAN; break;

                case "KANADA":
                    pictureBoxUlke.Image = Properties.Resources.KANADA; break;

                default:
                    
                    break;


            }
        }
    }
}
