using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace agacOdev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        agac bn = new agac();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               int a = Int32.Parse(dEkleText.Text);
               bn.ekle(a);
                dEkleLabel.Text = "düğüm eklendi";
                dSilLabel.Text = "";
            }
            catch
            {
                dEkleLabel.Text = "";
                MessageBox.Show("Hatalı Değer Girdiniz.");
            }
            dEkleText.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int b = Int32.Parse(dSilText.Text);
                bn.sil(b);
                dSilLabel.Text = "düğüm silindi";
                dEkleLabel.Text = "";
            }
            catch
            {
                dSilLabel.Text = "";
                MessageBox.Show("Hatalı Değer Girdiniz.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int deger1 = Int32.Parse(dBulText.Text);
            string sonuc = bn.getDerece(bn.Root, deger1).ToString();
            dDuzeyLabel.Text = "Düğümün düzeyi : " + sonuc;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bPreOrder.Text = "";
            bn.diziSayi = 0;
            bn.preOrder(bn.Root);
            for(int i = 0; i<bn.diziSayi; i++)
            {
                bPreOrder.Text = bPreOrder.Text + " "+ bn.getDizi(i).ToString();
                aDugum.Text = bn.diziSayi.ToString();
            }

            bInOrder.Text = "";
            bn.diziSayi = 0;
            bn.inOrder(bn.Root);
            for (int i = 0; i < bn.diziSayi; i++)
            {
                bInOrder.Text = bInOrder.Text + " " + bn.getDizi(i).ToString();
                aDugum.Text = bn.diziSayi.ToString();
            }

            bPostOrder.Text = "";
            bn.diziSayi = 0;
            bn.postOrder(bn.Root);
            for (int i = 0; i < bn.diziSayi; i++)
            {
                bPostOrder.Text = bPostOrder.Text + " " + bn.getDizi(i).ToString();
                aDugum.Text = bn.diziSayi.ToString();
            }

            aYukseklik.Text = bn.agacYukseklik().ToString();

            bYapraklar.Text = "";
            bn.yaprakSayi = 0;
            bn.yapraklarBul(bn.Root);
            for(int i = 0; i < bn.yaprakSayi; i++)
            {
                bYapraklar.Text = bYapraklar.Text + " " + bn.getYaprakDizi(i).ToString();
                aDugum.Text = bn.diziSayi.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            aDugumTextBox.Text = "";
            bn.solSayi = 0;
            bn.solYapraklar(bn.Root);

            bn.sagSayi = 0;
            bn.sagYapraklar(bn.Root);

            int toplam = bn.solSayi + bn.sagSayi;
            int kereYazdirSol = 0;
            int kereYazdirSag = 0;

            aDugumTextBox.Text = bn.getRoot(bn.Root).ToString() + " -> Kök ";
            for(int i = 0; i<= toplam ; toplam --)
            {
                if(bn.getSolYaprakDugum(toplam) != 0 && bn.getSolYaprakDugum(toplam) != bn.getRoot(bn.Root))
                {
                    aDugumTextBox.Text = aDugumTextBox.Text +"\n" + bn.getSolYaprakDugum(toplam).ToString() + " - >";
                    for(int k = 0; k <= kereYazdirSol; k++)
                    {
                        aDugumTextBox.Text = aDugumTextBox.Text + " sol";
                    }
                    kereYazdirSol++;
                }

                if(bn.getSagYaprakDugum(toplam) != 0 && bn.getSagYaprakDugum(toplam) != bn.getRoot(bn.Root))
                {
                    aDugumTextBox.Text =aDugumTextBox.Text + "\n" + bn.getSagYaprakDugum(toplam).ToString() + " - >";
                    for (int k = 0; k <= kereYazdirSag; k++)
                    {
                        aDugumTextBox.Text = aDugumTextBox.Text + " sağ";
                    }
                    kereYazdirSag++;
                }
                
            }
        }


    }
}
