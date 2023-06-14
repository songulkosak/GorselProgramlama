using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VizeGenelTekrar2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static int topla(int sayi1,int sayi2,int sayi3,int sayi4)
        {
            MessageBox.Show("İnteger Toplama");
            return sayi1 + sayi2 + sayi3 + sayi4;
        }
        public static double topla(double sayi1, double sayi2, double sayi3, double sayi4)
        {
            MessageBox.Show("Double Toplama");
            return sayi1 + sayi2 + sayi3 + sayi4;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //int sayi1, sayi2, sayi3, sayi4;
            //sayi1 = Convert.ToInt32(textBox1.Text);
            //sayi2 = Convert.ToInt32(textBox2.Text);
            //sayi3 = Convert.ToInt32(textBox3.Text);
            //sayi4 = Convert.ToInt32(textBox4.Text);


            double sayi1, sayi2, sayi3, sayi4;
            sayi1 = Convert.ToDouble(textBox1.Text);
            sayi2 = Convert.ToDouble(textBox2.Text);
            sayi3 = Convert.ToDouble(textBox3.Text);
            sayi4 = Convert.ToDouble(textBox4.Text);

            label5.Text=topla(sayi1,sayi2,sayi3,sayi4).ToString();


        }
    }
}
