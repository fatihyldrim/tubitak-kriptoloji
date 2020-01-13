using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harf_Rakam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_Kelime1.Enabled = true;
            txt_Kelime2.Enabled = false;
            txt_Kelime3.Enabled = false;
            txt_Kelime4.Enabled = false;
            txt_Kelime5.Enabled = false;
            txt_Kelime6.Enabled = false;
        }

        private char[] harfler = new char[] { 'a', 'b', 'c', 'ç', 'd', 'e', 'f', 'g', 'ğ', 'h', 'ı', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'ö', 'p', 'r', 's', 'ş', 't', 'u', 'ü', 'v', 'y', 'z' };

        private void btn_Uret_Click(object sender, EventArgs e)
        {
            lbl_RakamDegerleri1.Text = rakambul(txt_Kelime1.Text);
            lbl_RakamDegerleri2.Text = rakambul(txt_Kelime2.Text);
            lbl_RakamDegerleri3.Text = rakambul(txt_Kelime3.Text);
            lbl_RakamDegerleri4.Text = rakambul(txt_Kelime4.Text);
            lbl_RakamDegerleri5.Text = rakambul(txt_Kelime5.Text);
            lbl_RakamDegerleri6.Text = rakambul(txt_Kelime6.Text);

            if (CalissinMi(chcD1, chcY1)) lbl_toplam1.Text = toplam(lbl_RakamDegerleri1.Text);
            if (CalissinMi(chcD2, chcY1)) lbl_toplam2.Text = toplam(lbl_RakamDegerleri2.Text);
            if (CalissinMi(chcD3, chcY1)) lbl_toplam3.Text = toplam(lbl_RakamDegerleri3.Text);
            if (CalissinMi(chcD4, chcY1)) lbl_toplam4.Text = toplam(lbl_RakamDegerleri4.Text);
            if (CalissinMi(chcD5, chcY1)) lbl_toplam5.Text = toplam(lbl_RakamDegerleri5.Text);
            if (CalissinMi(chcD6, chcY1)) lbl_toplam6.Text = toplam(lbl_RakamDegerleri6.Text);

            int[] adet = new int[] { 0, 1 };
            if (CalissinMi(chcD1, chcY2)) lbl_12top1.Text = toplam(lbl_RakamDegerleri1.Text, adet);
            if (CalissinMi(chcD2, chcY2)) lbl_12top2.Text = toplam(lbl_RakamDegerleri2.Text, adet);
            if (CalissinMi(chcD3, chcY2)) lbl_12top3.Text = toplam(lbl_RakamDegerleri3.Text, adet);
            if (CalissinMi(chcD4, chcY2)) lbl_12top4.Text = toplam(lbl_RakamDegerleri4.Text, adet);
            if (CalissinMi(chcD5, chcY2)) lbl_12top5.Text = toplam(lbl_RakamDegerleri5.Text, adet);
            if (CalissinMi(chcD6, chcY2)) lbl_12top6.Text = toplam(lbl_RakamDegerleri6.Text, adet);

            adet = new int[] { 1, 2 };
            if (CalissinMi(chcD1, chcY3)) lbl_23top1.Text = toplam(lbl_RakamDegerleri1.Text, adet);
            if (CalissinMi(chcD2, chcY3)) lbl_23top2.Text = toplam(lbl_RakamDegerleri2.Text, adet);
            if (CalissinMi(chcD3, chcY3)) lbl_23top3.Text = toplam(lbl_RakamDegerleri3.Text, adet);
            if (CalissinMi(chcD4, chcY3)) lbl_23top4.Text = toplam(lbl_RakamDegerleri4.Text, adet);
            if (CalissinMi(chcD5, chcY3)) lbl_23top5.Text = toplam(lbl_RakamDegerleri5.Text, adet);
            if (CalissinMi(chcD6, chcY3)) lbl_23top6.Text = toplam(lbl_RakamDegerleri6.Text, adet);

            adet = new int[] { 0, 1, 2 };
            if (CalissinMi(chcD1, chcY4)) lbl_123top1.Text = toplam(lbl_RakamDegerleri1.Text, adet);
            if (CalissinMi(chcD2, chcY4)) lbl_123top2.Text = toplam(lbl_RakamDegerleri2.Text, adet);
            if (CalissinMi(chcD3, chcY4)) lbl_123top3.Text = toplam(lbl_RakamDegerleri3.Text, adet);
            if (CalissinMi(chcD4, chcY4)) lbl_123top4.Text = toplam(lbl_RakamDegerleri4.Text, adet);
            if (CalissinMi(chcD5, chcY4)) lbl_123top5.Text = toplam(lbl_RakamDegerleri5.Text, adet);
            if (CalissinMi(chcD6, chcY4)) lbl_123top6.Text = toplam(lbl_RakamDegerleri6.Text, adet);


            if (CalissinMi(chcD1, chcY5)) lbl_1Stop1.Text = toplam(lbl_RakamDegerleri1.Text, new int[] { 0, -1 });
            if (CalissinMi(chcD2, chcY5)) lbl_1Stop2.Text = toplam(lbl_RakamDegerleri2.Text, new int[] { 0, -1 });
            if (CalissinMi(chcD3, chcY5)) lbl_1Stop3.Text = toplam(lbl_RakamDegerleri3.Text, new int[] { 0, -1 });
            if (CalissinMi(chcD4, chcY5)) lbl_1Stop4.Text = toplam(lbl_RakamDegerleri4.Text, new int[] { 0, -1 });
            if (CalissinMi(chcD5, chcY5)) lbl_1Stop5.Text = toplam(lbl_RakamDegerleri5.Text, new int[] { 0, -1 });
            if (CalissinMi(chcD6, chcY5)) lbl_1Stop6.Text = toplam(lbl_RakamDegerleri6.Text, new int[] { 0, -1 });

            if (CalissinMi(chcD1, chcY6)) lbl_2S2top1.Text = toplam(lbl_RakamDegerleri1.Text, new int[] { 1, -2 });
            if (CalissinMi(chcD2, chcY6)) lbl_2S2top2.Text = toplam(lbl_RakamDegerleri2.Text, new int[] { 1, -2 });
            if (CalissinMi(chcD3, chcY6)) lbl_2S2top3.Text = toplam(lbl_RakamDegerleri3.Text, new int[] { 1, -2 });
            if (CalissinMi(chcD4, chcY6)) lbl_2S2top4.Text = toplam(lbl_RakamDegerleri4.Text, new int[] { 1, -2 });
            if (CalissinMi(chcD5, chcY6)) lbl_2S2top5.Text = toplam(lbl_RakamDegerleri5.Text, new int[] { 1, -2 });
            if (CalissinMi(chcD6, chcY6)) lbl_2S2top6.Text = toplam(lbl_RakamDegerleri6.Text, new int[] { 1, -2 });

        }
        private bool CalissinMi(CheckBox chcD, CheckBox chcY)
        {
            bool sonuc = false;
            if (chcD.Checked && chcY.Checked)
                sonuc = true;
            else
                sonuc = false;
            return sonuc;
        }
        private string toplam(string yazi)
        {
            string[] degerler = yazi.Split(new[] { " , " }, StringSplitOptions.None);
            int toplam = 0;
            for (int i = 0; i < degerler.Length - 1; i++)
            {
                toplam += Convert.ToInt32(degerler[i]);
            }
            if (chcMod29.Checked)
            {
                toplam = toplam % 29;
            }
            return toplam.ToString();
        }
        private string toplam(string yazi, int[] Harfler)
        {

            string[] degerler = yazi.Split(new[] { " , " }, StringSplitOptions.None);
            int toplam = 0;
            if (Harfler[1] == -1) Harfler[1] = degerler.Length - 2;
            if (Harfler[1] == -2) Harfler[1] = degerler.Length - 3;
            for (int i = 0; i < Harfler.Length; i++)
            {

                toplam += Convert.ToInt32(degerler[Harfler[i]]);
            }
                        if (chcMod29.Checked)
            {
                toplam = toplam % 29;
            }
            return toplam.ToString();
        }

        private string rakambul(string yazi)
        {
            string deger = "";
            for (int i = 0; i < yazi.Length; i++)
            {
                char a = yazi[i];

                for (int k = 0; k < 29; k++)
                {
                    if (harfler[k] == a)
                    {
                        deger += k.ToString() + " , ";
                    }
                }
            }
            return deger;
        }

        private void chcD1_CheckedChanged(object sender, EventArgs e)
        {
            if (chcD1.Checked) txt_Kelime1.Enabled = true;
            else txt_Kelime1.Enabled = false;
        }

        private void chcD2_CheckedChanged(object sender, EventArgs e)
        {
            if (chcD2.Checked) txt_Kelime2.Enabled = true;
            else txt_Kelime2.Enabled = false;
        }

        private void chcD3_CheckedChanged(object sender, EventArgs e)
        {
            if (chcD3.Checked) txt_Kelime3.Enabled = true;
            else txt_Kelime3.Enabled = false;
        }

        private void chcD4_CheckedChanged(object sender, EventArgs e)
        {
            if (chcD4.Checked) txt_Kelime4.Enabled = true;
            else txt_Kelime4.Enabled = false;
        }

        private void chcD5_CheckedChanged(object sender, EventArgs e)
        {
            if (chcD5.Checked) txt_Kelime5.Enabled = true;
            else txt_Kelime5.Enabled = false;
        }

        private void chcD6_CheckedChanged(object sender, EventArgs e)
        {
            if (chcD6.Checked) txt_Kelime6.Enabled = true;
            else txt_Kelime6.Enabled = false;
        }
    }
}
