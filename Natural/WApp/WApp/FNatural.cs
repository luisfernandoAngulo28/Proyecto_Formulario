using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CApp;

namespace WApp
{
    public partial class FNatural : Form
    {
        public FNatural()
        {
            InitializeComponent();
        }

        clsNatu Natu = new clsNatu();
        clsNatu Nume = new clsNatu();
        clsNatu Nume1 = new clsNatu();
        clsNatu Nume2 = new clsNatu();

        private void button1_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(textBox1.Text);
            //int numero = Convert.ToInt32(textBox1.Text);

            Nume = new clsNatu(numero);
            //label1.Text = (Natu.Sucesor(Nume).n).ToString();
            label2.Text = Convert.ToString(Natu.Sucesor(Nume).n);

        }
    }
}
