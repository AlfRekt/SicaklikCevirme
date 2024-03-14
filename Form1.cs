using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sıcaklık_Değerleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            Secim_Celcius.Visible = true;
            Secim_Fahrenheit.Visible = true;
            Secim_Kelvin.Visible = true;

            Cevir_Kelvin.Visible = true;
            Cevir_Fahrenheit.Visible = true;
            Cevir_Celcius.Visible = true;

            textBox1.Text = null;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            textBox1.Text = "0";
        }

        private void Secim_Celcius_Click(object sender, EventArgs e)
        {
            label1.Text = "Celcius (°C)";
            label1.Visible = true;

            Secim_Celcius.Visible = false;
            Secim_Fahrenheit.Visible = false;
            Secim_Kelvin.Visible = false;

            Cevir_Celcius.Visible = false;
        }

        private void Secim_Fahrenheit_Click(object sender, EventArgs e)
        {
            label1.Text = "Fahrenheit (°F)";
            label1.Visible = true;

            Secim_Celcius.Visible = false;
            Secim_Fahrenheit.Visible = false;
            Secim_Kelvin.Visible = false;

            Cevir_Fahrenheit.Visible = false;
        }

        private void Secim_Kelvin_Click(object sender, EventArgs e)
        {
            label1.Text = "Kelvin (°K)";
            label1.Visible = true;

            Secim_Celcius.Visible = false;
            Secim_Fahrenheit.Visible = false;
            Secim_Kelvin.Visible = false;

            Cevir_Kelvin.Visible = false;
        }

        private void Cevir_Fahrenheit_Click(object sender, EventArgs e)
        {
            try
            {
                int number1 = Convert.ToInt32(textBox1.Text);

                if (label1.Text == "Celcius (°C)")
                {
                    double sonuc = number1 * 1.8 + 32;
                    MessageBox.Show(Convert.ToString(number1) + " Celcius (°C) " + sonuc + " Fahrenheit (°F) etmektedir.");
                }

                if (label1.Text == "Kelvin (°K)")
                {
                    double sonuc = (number1 - 273.15) * 1.8 + 32;
                    MessageBox.Show(Convert.ToString(number1) + " Kelvin (°K) " + sonuc + " Fahrenheit (°F) etmektedir.");
                }

                label1.Visible = false;
                Secim_Celcius.Visible = true;
                Secim_Fahrenheit.Visible = true;
                Secim_Kelvin.Visible = true;

                Cevir_Kelvin.Visible = true;
                Cevir_Fahrenheit.Visible = true;
                Cevir_Celcius.Visible = true;

                textBox1.Text = null;
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Lütfen geçerli bir değer giriniz!!!");
            }           
        }

        private void Cevir_Kelvin_Click(object sender, EventArgs e)
        {
            try
            {
                int number1 = Convert.ToInt32(textBox1.Text);

                if (label1.Text == "Celcius (°C)")
                {
                    double sonuc = number1 + 273.15;
                    MessageBox.Show(Convert.ToString(number1) + " Celcius (°C) " + sonuc + " Kelvin (°K) etmektedir.");
                }

                if (label1.Text == "Fahrenheit (°F)")
                {
                    double sonuc = (number1 - 32) / 1.8 + 273.15;
                    MessageBox.Show(Convert.ToString(number1) + " Fahrenheit (°F) " + sonuc + " Kelvin (°K) etmektedir.");
                }

                label1.Visible = false;
                Secim_Celcius.Visible = true;
                Secim_Fahrenheit.Visible = true;
                Secim_Kelvin.Visible = true;

                Cevir_Kelvin.Visible = true;
                Cevir_Fahrenheit.Visible = true;
                Cevir_Celcius.Visible = true;

                textBox1.Text = null;
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Lütfen geçerli bir değer giriniz!!!");
            }           
        }

        private void Cevir_Celcius_Click(object sender, EventArgs e)
        {
            try
            {
                int number1 = Convert.ToInt32(textBox1.Text);

                if (label1.Text == "Fahrenheit (°F)")
                {
                    double sonuc = (number1 - 32) / 1.8;
                    MessageBox.Show(Convert.ToString(number1) + " Fahrenheit (°F) " + sonuc + " Celcius (°C) etmektedir.");
                }

                if (label1.Text == "Kelvin (°K)")
                {
                    double sonuc = (number1 - 273.15);
                    MessageBox.Show(Convert.ToString(number1) + " Kelvin (°K) " + sonuc + " Celcius (°C) etmektedir.");
                }

                label1.Visible = false;
                Secim_Celcius.Visible = true;
                Secim_Fahrenheit.Visible = true;
                Secim_Kelvin.Visible = true;

                Cevir_Kelvin.Visible = true;
                Cevir_Fahrenheit.Visible = true;
                Cevir_Celcius.Visible = true;

                textBox1.Text = null;
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Lütfen geçerli bir değer giriniz!!!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
