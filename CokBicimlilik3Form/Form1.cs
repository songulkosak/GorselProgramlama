using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CokBicimlilik3Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Canli C1=new Canli();
            }
            else if (radioButton2.Checked)
            {
                Insan I1 = new Insan();
            }
            else 
            {
                Bitki B1 = new Bitki();
            }  
        }
    }
}
