using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İşçiMaaş
{
    public partial class Form1 : Form
    {
        Double maas, satilan_urun, prim, mesai_ucreti, mesai_saati, toplam_mesai, toplam_maas;

        

        

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnToplamMaaş_Click(object sender, EventArgs e)
        {
            maas = Convert.ToDouble(textBox3.Text);
            mesai_saati = Convert.ToDouble(textBox7.Text);
            satilan_urun = Convert.ToDouble(textBox4.Text);
            prim = maas * 3 / 100;
            prim = satilan_urun * prim;
            textBox6.Text = Convert.ToString(prim);
            mesai_ucreti = maas / 30;
            textBox13.Text = Convert.ToString(mesai_ucreti);
            toplam_mesai = mesai_saati * mesai_ucreti;
            textBox8.Text = Convert.ToString(toplam_mesai);
            toplam_maas = (maas + toplam_mesai + prim);
            textBox9.Text = Convert.ToString(toplam_maas);


        }
        private void BtnTazminat_Click(object sender, EventArgs e)
        {
            DateTime ise_baslama, isi_birakma;
            long kac_gun = 0;
            double alacagı_tazminat;
            maas = Convert.ToDouble(textBox3.Text);
            ise_baslama = DateTime.Parse(textBox10.Text);
            isi_birakma = DateTime.Parse(textBox11.Text);
            kac_gun = (long)(isi_birakma.ToOADate() - ise_baslama.ToOADate());
            textBox12.Text = Convert.ToString(kac_gun);
            alacagı_tazminat = kac_gun / 365 * maas;
            textBox5.Text = Convert.ToString(alacagı_tazminat);
            if (alacagı_tazminat <= 0)
            {
                MessageBox.Show("Tam Seneniz Dolduğu Zaman Tazminatınızı Alırsınız");
            }

        }
        private void BtnEmekli_Click(object sender, EventArgs e)
        {
            double prim_gün_sayisi, kalan_prim_sayisi;
            prim_gün_sayisi = Convert.ToDouble(textBox14.Text);
            if (prim_gün_sayisi > 3500)
            {
                MessageBox.Show("emeklilik priminizi doldurmuşsunuz. Emeklilik işlemlerinizi Başlatın");
            }
            kalan_prim_sayisi = 3500 - prim_gün_sayisi;
            textBox15.Text = Convert.ToString(kalan_prim_sayisi);
        }
        private void Form1_Load(object sender, EventArgs e)
        {



            textBox13.Enabled = false;
            textBox8.Enabled = false;
            textBox9.Enabled = false;
            textBox6.Enabled = false;
            textBox12.Enabled = false;
            textBox5.Enabled = false;
            textBox15.Enabled = false;
        }
    }
}
