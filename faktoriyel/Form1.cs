using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

// EMİRHAN ERSOY - 22118080001


namespace faktoriyel
{
    public partial class FaktoriyelUygulama : Form
    {
        public FaktoriyelUygulama()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FaktoriyelUygulama_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void fktrylSayi_TextChanged(object sender, EventArgs e)
        {

        }

        private void fktrylKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Bu kodlar formun mouse hareketi ile hareket ettirilmesi içindir.

        bool move;
        int mouse_x;
        int mouse_y;


        private void FaktoriyelUygulama_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void FaktoriyelUygulama_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void FaktoriyelUygulama_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {

            // Kullanıcının verdiği sayıya bakılıyor.

            int sayi = Convert.ToInt32(textSayi.Text);

            if (sayi > 16)
            {
                MessageBox.Show("Girilen Değer Çok Büyük Olduğu İçin Faktöriyel Değeri Hesaplanamadı...","UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("İstenilen İşlemler Başarıyla Hesaplandı...", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //**********************************************************************************
            //Faktöriyel hesabı

            int faktoriyel = 1;
            if (sayi > 16)
            {
                textSonuc.Text = "Hesaplanamadı.";
            }
            else {
                for (int i = 1; i <= sayi; i++)
                {
                    faktoriyel *= i;
                }

                textSonuc.Text = Convert.ToString(faktoriyel);
                }
            //*********************************************************************************//
            //Asal Sayı kontrolü

            bool asalMi = true;



            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0) // eğer sayı i'ye bölünebiliyorsa
                {
                    asalMi = false; // sayı asal değil demektir
                    break; // döngüyü sonlandırıyoruz
                }
            }

            if(sayi == 0 || sayi == 1)
            {
                asalMi = false;
            }

            if (asalMi)
            {
                textAsal.Text = "Sayı asaldır.";
            }
            else
            {
                textAsal.Text = "Sayı asal değildir.";
            }

            //******************************************************************************//
            //Faktöriyelin açılımı

            string faktoriyelAcilimi = "";

            for(int i = sayi; i >= 1; i--)
            {
                faktoriyelAcilimi += Convert.ToString(i);

                if (i != 1)
                { 
                    faktoriyelAcilimi += "-";
                }

                }

            textAcilim.Text = faktoriyelAcilimi;

            //****************************************************************************************
        }

        // Temizleme butonu
        private void fktrylTemizle_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Başarıyla Temizlendi...", "Faktöriyel Hesaplama Aracı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textSayi.Clear();
            textSonuc.Clear();
            textAcilim.Clear();       
            textAsal.Clear();
        }

        private void textSonuc_TextChanged(object sender, EventArgs e)
        {

        }

        private void textAsal_TextChanged(object sender, EventArgs e)
        {

        }

        private void textAcilim_TextChanged(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void fktrylKapat_MouseEnter(object sender, EventArgs e)
        {
            fktrylKapat.BackColor = Color.Tomato;
        }

        private void fktrylKapat_MouseLeave(object sender, EventArgs e)
        {
            fktrylKapat.BackColor = Color.Transparent;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }


        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
