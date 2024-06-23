using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 4;

            dataGridView1.Columns[0].Name = "cinsiyet";
            dataGridView1.Columns[1].Name = "boy";
            dataGridView1.Columns[2].Name = "kilo";
            dataGridView1.Columns[3].Name = "vücut kitle indeksi";

        }


        public void button1_Click(object sender, EventArgs e)
        {
            int  kilo, boy;
            kilo = Convert.ToInt32(textbox1.Text);
            boy = Convert.ToInt32(textbox2.Text);

            if (checkBox1.Checked) {

                if (string.IsNullOrWhiteSpace(textbox1.Text))
                {
                    MessageBox.Show("boyunuzu girmediniz!!!");
                }
                else if (string.IsNullOrWhiteSpace(textbox2.Text))
                {
                    MessageBox.Show("kilonuzu girmediniz!!!");
                }
                else if (string.IsNullOrWhiteSpace(textbox1.Text) || string.IsNullOrWhiteSpace(textbox2.Text))
                {
                    MessageBox.Show("boy ve kilonuzu lütfen giriniz!!!");
                }
                else 
                {
                    int indeks = kilo / (boy * boy);
                    dataGridView1.Rows.Add(checkBox1.Text,kilo, boy, indeks);
                    textbox1.Clear();
                    textbox2.Clear();
                    checkBox1.Checked = false;
                }

            }



            else if (checkBox2.Checked) { 

                if (int.TryParse(textbox2.Text,out kilo))
                {
                    MessageBox.Show("boyunuzu girmediniz!!!");
                }
                else if (string.IsNullOrWhiteSpace(textbox2.Text))
                {
                    MessageBox.Show("kilonuzu girmediniz!!!");
                }
                else if (string.IsNullOrWhiteSpace(textbox1.Text)|| string.IsNullOrWhiteSpace(textbox2.Text))
                {
                    MessageBox.Show("boy ve kilonuzu lütfen giriniz!!!");
                }
                else 
                {
                    int indeks = kilo / (boy * boy);
                    dataGridView1.Rows.Add(checkBox2.Text,kilo, boy, indeks);
                    textbox1.Clear();
                    textbox2.Clear();
                    checkBox2.Checked = false;

                }

            }
            else
            {
                MessageBox.Show("cinsiyet seçiniz lütfen!!!");
            }




        }

     
    }
}
