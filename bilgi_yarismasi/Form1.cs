using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bilgi_yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruNo = 0, dogru = 0, yanlis = 0;

        private void btn_B_Click(object sender, EventArgs e)
        {
            btn_A.Enabled = false;
            btn_B.Enabled = false;
            btn_C.Enabled = false;
            btn_D.Enabled = false;
            btn_Sonraki.Enabled = true;

            label5.Text = btn_B.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lbl_Dogru.Text = dogru.ToString();
                pct_Yesil.Visible = true;
            }
            else
            {
                yanlis++;
                lbl_Yanlis.Text = yanlis.ToString();
                pct_Kirmizi.Visible = true;
            }
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            btn_A.Enabled = false;
            btn_B.Enabled = false;
            btn_C.Enabled = false;
            btn_D.Enabled = false;
            btn_Sonraki.Enabled = true;

            label5.Text = btn_C.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lbl_Dogru.Text = dogru.ToString();
                pct_Yesil.Visible = true;
            }
            else
            {
                yanlis++;
                lbl_Yanlis.Text = yanlis.ToString();
                pct_Kirmizi.Visible = true;
            }
        }

        private void btn_D_Click(object sender, EventArgs e)
        {
            btn_A.Enabled = false;
            btn_B.Enabled = false;
            btn_C.Enabled = false;
            btn_D.Enabled = false;
            btn_Sonraki.Enabled = true;

            label5.Text = btn_D.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lbl_Dogru.Text = dogru.ToString();
                pct_Yesil.Visible = true;
            }
            else
            {
                yanlis++;
                lbl_Yanlis.Text = yanlis.ToString();
                pct_Kirmizi.Visible = true;
            }
        }

        private void btn_A_Click(object sender, EventArgs e)
        {
            btn_A.Enabled = false;
            btn_B.Enabled = false;
            btn_C.Enabled = false;
            btn_D.Enabled = false;
            btn_Sonraki.Enabled = true;

            label5.Text = btn_A.Text;
            if (label4.Text==label5.Text)
            {
                dogru++;
                lbl_Dogru.Text = dogru.ToString();
                pct_Yesil.Visible = true;
            }
            else
            {
                yanlis++;
                lbl_Yanlis.Text= yanlis.ToString();
                pct_Kirmizi.Visible = true;
            }
        }

        private void btn_Sonraki_Click(object sender, EventArgs e)
        {
            btn_A.Enabled = true;
            btn_B.Enabled = true;
            btn_C.Enabled= true;
            btn_D.Enabled= true;
            btn_Sonraki.Enabled = false;

            pct_Yesil.Visible = false;
            pct_Kirmizi.Visible = false;


            soruNo++;
            lbl_SoruNo.Text = soruNo.ToString();

            if (soruNo == 1)
            {
                rtb_Soru.Text = "Cumhuriyet kaç yılında ilan edilmiştir?";
                btn_A.Text = "1920";
                btn_B.Text = "1921";
                btn_C.Text = "1922";
                btn_D.Text = "1923";
                label4.Text = "1923";
            }
            if (soruNo==2)
            {
                rtb_Soru.Text = "Hangi il Ege Bölgemizde yer almamaktadır?";
                btn_A.Text = "İzmir";
                btn_B.Text = "Balıkesir";
                btn_C.Text = "Aydın";
                btn_D.Text = "Manisa";
                label4.Text = "Balıkesir";
          }
            if (soruNo==3)
            {
                rtb_Soru.Text = "Son Kuşlar romanı hangi yazarımıza aittir?";
                btn_A.Text = "Sait Faik Abasıyanık";
                btn_B.Text = "Cemal Süreya";
                btn_C.Text = "Attila İlhan";
                btn_D.Text = "Reşat Nuri Güntekin";
                label4.Text = "Sait Faik Abasıyanık";
                btn_Sonraki.Text = "Sonuçlar";
            }
            if (soruNo==4)
            {
                btn_A.Enabled = false;
                btn_B.Enabled = false;
                btn_C.Enabled = false;  
                btn_D.Enabled = false;
                btn_Sonraki.Enabled = false;

                MessageBox.Show("Doğru: "+ dogru + "\n" + "Yanlış: "+yanlis);

            }

        }
    }
}
