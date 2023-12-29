using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormGiris
{
    public partial class Form1 : Form
    {
        List<string> isimler = new List<string>();
        List<string> soyisimler = new List<string>();
        List<DateTime> dogumTarihleri = new List<DateTime>();
        List<bool> cinsiyet = new List<bool>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isimler.Add(txtAd.Text);
            soyisimler.Add(txtSoyad.Text);
            dogumTarihleri.Add(dtDogumTarihi.Value);
            cinsiyet.Add(chkCinsiyet.Checked);
            FormuTemizle();
            int sonuc = Topla(3, 5);

        }
        int a = 0;
        private void FormuTemizle()
        {
            txtAd.Text = string.Empty;
            txtSoyad.Text = string.Empty;
            dtDogumTarihi.Value = DateTime.Now;
            chkCinsiyet.Checked = false;
        }
        private int Topla(int a, int b)
        {
            return a + b;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
