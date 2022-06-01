using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //public Prodcuto producto { get; set; }
        public double Futuro { get; set; }
        public double presente { get; set; }
        public double nominal { get; set; }
        public double producto { get; set; }
        public double producto2 { get; set; }
        public double periodo { get; set; }
        double pres = 0;
        double perio =0;
        double No = 0;
        public Double GetPresente(double presente)
        {
            nominal = nominal / 100 * -1 ;
            
            presente = Futuro * Math.Pow(1 + nominal / producto, nominal * periodo);
            return presente;
        }
        public double  GeTPeriodo(double periodo)
        {
            nominal = nominal / 100;
            periodo = (Math.Log(Futuro / presente)) / (producto * Math.Log(1 + nominal / producto));
            return periodo;
        }
        //metodos para convertir un tasa efectiva a tasa nominal//
        public double ConvertNominal(double ominal)
        {
            nominal = nominal / 100;
            ominal = Math.Pow((Math.Sqrt(1 + nominal) - 1) ,producto ) * producto;
            return ominal;
        }
        public Double ConvetNOminal (double monal)
        {
            nominal = nominal / 100;
            monal = Math.Pow(1 + nominal / producto, producto / producto2) - 1 * producto2;
            return monal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Futuro = double.Parse(textBox1.Text);
            nominal = double.Parse(textBox2.Text);
            producto = double.Parse(textBox3.Text);
            producto2 = double.Parse(textBox4.Text);
            label1.Text = ConvertNominal(No).ToString();
        }
    }
}
