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
    public partial class BolumBilgileri : Form
    {
        public BolumBilgileri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-GNK4VP1;Initial Catalog=Giris;Integrated Security=True");
        private void goster2()
        {
            string komut2 = "select *from BolumBilgileri";
            SqlDataAdapter da2 = new SqlDataAdapter(komut2, baglanti);
            DataTable tablo2 = new DataTable();
            da2.Fill(tablo2);
            dataGridView2.DataSource = tablo2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Programı Kapatmak İstediğinize Eminmisiniz ?", "DİKKAT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MezunTakip mt = new MezunTakip();
            mt.Show();
            this.Hide();
        }

        private void BolumBilgileri_Load(object sender, EventArgs e)
        {
            goster2();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
