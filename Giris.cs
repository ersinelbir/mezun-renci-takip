using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MznTkp
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
            textBox2.MaxLength = 15;
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-GNK4VP1;Initial Catalog=Giris;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from Giris where kullaniciadi='" + textBox1.Text + "' AND sifre='" + textBox2.Text + "'", baglanti);

            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                MezunTakip mt = new MezunTakip();
                mt.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ya da şifre yanlış");
            }

            baglanti.Close();
        }
    }
}
