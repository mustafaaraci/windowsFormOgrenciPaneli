using System.Diagnostics.Eventing.Reader;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] ogrenciler = new string[10];
        double[] ortalamalar = new double[10];
        int index = 0;
       

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                ogrenciler[index] = ogrenciAdi.Text;
                ortalamalar[index] = double.Parse(ortalamasi.Text);
                index++;
                if (index == 10)
                {
                    btnEkle.Enabled = false;
                    MessageBox.Show("10 dan fazla öðrenci ekleyemezsiniz!");
                }

                else
                {
                    MessageBox.Show($"öðrenci ekleme baþarýlý");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + $"*****bir hata oluþtu*****");
            }

        }

        private void btn_tumOgrenciListesi_Click(object sender, EventArgs e)
        {
            listeGosterEkrani.Items.Clear();
            for (int i = 0; i < ogrenciler.Length; i++)
            {
                if (ortalamalar[i]>0 && ortalamalar[i]<=100)
                {
                    listeGosterEkrani.Items.Add($"{ogrenciler[i]}\t{ortalamalar[i]}");

                }


            }
        }

        private void btn_kalanOgrenciler_Click(object sender, EventArgs e)
        {
            listeGosterEkrani.Items.Clear();
            for (int i = 0; i < ogrenciler.Length; i++)
            {
                if (ortalamalar[i] >0 && ortalamalar[i] < 50)
                {
                    listeGosterEkrani.Items.Add($"{ogrenciler[i]}\t{ortalamalar[i]}");
                }
            }

        }

        private void btn_gecenOgrenciler_Click(object sender, EventArgs e)
        {
            listeGosterEkrani.Items.Clear();
            for (int i = 0; i < ogrenciler.Length; i++)
            {
                if (ortalamalar[i] >= 50)
                {
                    listeGosterEkrani.Items.Add($"{ogrenciler[i]}\t{ortalamalar[i]}");
                }
            }

        }

        private void btn_tesekkurAlanOgrenciler_Click(object sender, EventArgs e)
        {
            listeGosterEkrani.Items.Clear();
            for (int i = 0; i < ogrenciler.Length; i++)
            {
                if (ortalamalar[i] >= 70 && ortalamalar[i] <= 84)
                {
                    listeGosterEkrani.Items.Add($"{ogrenciler[i]}\t{ortalamalar[i]}");
                }
            }
        }

        private void btn_takdirAlanOgrenciler_Click(object sender, EventArgs e)
        {
            listeGosterEkrani.Items.Clear();
            for (int i = 0; i < ogrenciler.Length; i++)
            {
                if (ortalamalar[i] >= 85 && ortalamalar[i] <= 100)
                {
                    listeGosterEkrani.Items.Add($"{ogrenciler[i]}\t{ortalamalar[i]}");
                }
            }
        }
    }

}
