namespace Alışveriş_İndiirm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kitapAdet;
            double fiyat;

            kitapAdet = Convert.ToInt32(textBox2.Text);
            if(kitapAdet >=0 && kitapAdet <= 5)
            {
                fiyat=(kitapAdet*50)-(kitapAdet * 50* 0.20);
                label3.Text= fiyat + " TL";
            }
            if(kitapAdet >= 5 && kitapAdet <=10 )
            {
                fiyat = (kitapAdet * 50) - (kitapAdet * 50 * 0.40);
                label3.Text = fiyat + " TL";
            }
            if(kitapAdet >= 10)
            {
                fiyat = (kitapAdet * 50) - (kitapAdet * 50 * 0.60);
                label3.Text = fiyat + " TL";
            }


        }
    }
}
