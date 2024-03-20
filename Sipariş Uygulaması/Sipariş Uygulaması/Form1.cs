using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sipariş_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 0;
        private void label1_Click(object sender, EventArgs e)
        {
            label1.BackColor = System.Drawing.Color.Transparent;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.BackColor = System.Drawing.Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            sayac = sayac + 1;
            string k_adi, sifre;
            k_adi = textBox1.Text;
            sifre = textBox2.Text;
            if (k_adi == "Kerem123")
            {
                if (sifre == "Kerem1234")
                {
                    MessageBox.Show("Şifre Doğru,Giriş Başarılı");
                    groupBox1.Visible = false;
                    groupBox2.Visible = true;
                }
                else
                {
                    MessageBox.Show("Şifre Yanlış,Giriş Başarısız");
                }
            }
            else 
            {
                MessageBox.Show("Giriş Başarısız");
            }
            if (sayac == 3) 
            {
                button1.Enabled = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else 
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int toplam = 0;
            if (checkBox2.Checked == true) 
            {
                toplam = toplam + 8500;
            }
            if (checkBox3.Checked == true)
            {
                toplam = toplam + 44000;
            }
            if (checkBox4.Checked == true)
            {
                toplam = toplam + 35000;
            }
            if (checkBox5.Checked == true)
            {
                toplam = toplam + 27000;
            }
            if (checkBox6.Checked == true)
            {
                toplam = toplam + 89000;
            }
            if (checkBox7.Checked == true)
            {
                toplam = toplam + 12000;
            }
            if (checkBox8.Checked == true)
            {
                toplam = toplam + 24000;
            }
            if (checkBox9.Checked == true)
            {
                toplam = toplam + 16000;
            }
            textBox13.Text = toplam.ToString();
            groupBox2.Visible = false;
            groupBox4.Visible = true;
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double tutar;
            double aylıkTutar;
            double kargoTutar;
            int sayi1;
            sayi1 = Convert.ToInt32(textBox13.Text);
            tutar = Convert.ToDouble(textBox13.Text);
            if (radioButton3.Checked == true) 
            {
                tutar = tutar + (tutar * 0.05);
                kargoTutar = tutar + 20;
                aylıkTutar = tutar / 3;
                label13.Text = Convert.ToString(aylıkTutar) + "TL";
                label16.Text = Convert.ToString(tutar) + "TL";
                label20.Text = Convert.ToString(kargoTutar) + "TL";
            }
            if (radioButton4.Checked == true)
            {
                tutar = tutar + (tutar * 0.06);
                kargoTutar = tutar + 20;
                aylıkTutar = tutar / 6;
                label13.Text = Convert.ToString(aylıkTutar) + "TL";
                label16.Text = Convert.ToString(tutar) + "TL";
                label20.Text = Convert.ToString(kargoTutar) + "TL";
            }
            if (radioButton5.Checked == true)
            {
                tutar = tutar + (tutar * 0.09);
                kargoTutar = tutar + 20;
                aylıkTutar = tutar / 9;
                label13.Text = Convert.ToString(aylıkTutar) + "TL";
                label16.Text = Convert.ToString(tutar) + "TL";
                label20.Text = Convert.ToString(kargoTutar) + "TL";
            }
            if (radioButton6.Checked == true)
            {
                tutar = tutar + (tutar * 0.10);
                kargoTutar = tutar + 20;
                aylıkTutar = tutar / 12;
                label13.Text = Convert.ToString(aylıkTutar) + "TL";
                label16.Text = Convert.ToString(tutar) + "TL";
                label20.Text = Convert.ToString(kargoTutar) + "TL";
            }
            if (radioButton1.Checked == true) 
            {
                kargoTutar = tutar + 20;
                label16.Text = Convert.ToString(tutar) + "TL";
                label20.Text = Convert.ToString(kargoTutar) + "TL";
                
            }
            if (tutar > 20000)
            {
                MessageBox.Show("İyi Günler,20000 TL Üzeri Alışverişinizde Kargo Bizden.Yine Bekleriz");
            }
            else 
            {
                MessageBox.Show("İyi Günler, Alışverişinizi 20000 TL ye Tamamlamak İstermisiniz ? Tamamlarsanız Kargo Bizden ");
            }
            if (sayi1 <= 20000)
            {
                label18.Text = "20,00 TL ";
            }
            else 
            {
                label18.Text = "00 TL ";
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox4.Visible = false;
            groupBox3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            groupBox5.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            groupBox5.Visible = false;
            groupBox3.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            groupBox4.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            groupBox4.Visible = false;
            groupBox2.Visible = true;
        }

    }
}
