using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText += "1";
            textBox2.SelectedText += "1";

        }

        private void CiktiEkrani_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText += "2";
            textBox2.SelectedText += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText += "3";
            textBox2.SelectedText += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText += "4";
            textBox2.SelectedText += "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText += "5";
            textBox2.SelectedText += "5";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText += "6";
            textBox2.SelectedText += "6";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText += "7";
            textBox2.SelectedText += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText += "8";
            textBox2.SelectedText += "8";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText += "9";
            textBox2.SelectedText += "9";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText += "0";
            textBox2.SelectedText += "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text) && (String.IsNullOrEmpty(textBox2.Text)))
            {
                MessageBox.Show("Lütfen 2 kutucuğa da sayı giriniz!", "Hata!");
            }
            else
            {
                if (radioButton1.Checked)
                {
                    textBox3.Text = (Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text)).ToString();
                    MessageBox.Show("Başarıyla 2 sayı toplandı!", "Bilgi");
                    button12.Hide();
                    button13.Show();
                    textBox3.Show();
                    textBox1.Hide();
                    textBox2.Hide();
                    label1.Hide();
                    label2.Hide();
                    label3.Show();
                }
                else if (radioButton2.Checked)
                {
                    textBox3.Text = (Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text)).ToString();
                    MessageBox.Show("Başarıyla 2 sayı çarpıldı!", "Bilgi");
                    button12.Hide();
                    button13.Show();
                    textBox3.Show();
                    textBox1.Hide();
                    textBox2.Hide();
                    label1.Hide();
                    label2.Hide();
                    label3.Show();
                }
                else if (radioButton3.Checked)
                {
                    textBox3.Text = (Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text)).ToString();
                    MessageBox.Show("Başarıyla 2 sayı çıkarıldı!", "Bilgi");
                    button12.Hide();
                    button13.Show();
                    textBox3.Show();
                    textBox1.Hide();
                    textBox2.Hide();
                    label1.Hide();
                    label2.Hide();
                    label3.Show();
                }
                else if (radioButton4.Checked)
                {
                    textBox3.Text = (Convert.ToDouble(textBox1.Text) / Convert.ToDouble(textBox2.Text)).ToString();
                    MessageBox.Show("Başarıyla 2 sayı bölündü!", "Bilgi");
                    button12.Hide();
                    button13.Show();
                    textBox3.Show();
                    textBox1.Hide();
                    textBox2.Hide();
                    label1.Hide();
                    label2.Hide();
                    label3.Show();
                }
                else
                {
                    MessageBox.Show("Aşağıdan herhangi bir method seçmediniz.", "Hata!");
                }
            }
            Console.Write("Program Başarıyla Açıldı. Panele Girildi.");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button12.Show();
            button13.Hide();
            textBox3.Hide();
            textBox1.Show();
            textBox2.Show();
            label1.Show();
            label2.Show();
            label3.Hide();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.github.com/ziksthemw");
        }
    }
}
