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
namespace stok_takip
{
    public partial class frmürünekle : Form
    {
        public frmürünekle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=Fcmglr\\SQLEXPRESS;Initial Catalog=stok_takip;Integrated Security=True");
        bool durum;
        private void barkodkontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from ürün", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (txtbarkodno.Text == read["barkodno"].ToString() || txtbarkodno.Text=="")
                {
                    durum = false;
                }
            }
            baglanti.Close();

        }

        private void frmmarka_Load(object sender, EventArgs e)
        {
            kategorigetir();

        }

        private void kategorigetir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from kategoribilgileri ", baglanti);
            SqlDataReader read = komut.ExecuteReader();

            while (read.Read())
            {
                combokategori.Items.Add(read["kategori"].ToString());
            }
            baglanti.Close();
        }
        private void frmürünekle_Load(object sender, EventArgs e)
        {
            kategorigetir();

        }

        private void combokategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            combomarka.Items.Clear();
            combomarka.Text = "";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from markabilgileri where kategori='" + combokategori.SelectedItem + "'  ", baglanti);
            SqlDataReader read = komut.ExecuteReader();

            while (read.Read())
            {
                combomarka.Items.Add(read["marka"].ToString());
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            barkodkontrol();
            if (durum==true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into ürün(barkodno,kategori,marka,ürünadı,miktarı,alışfiyatı,satışfiyatı,tarih) values (@barkodno,@kategori,@marka,@ürünadı,@miktarı,@alışfiyatı,@satışfiyatı,@tarih)", baglanti);
                komut.Parameters.AddWithValue("@barkodno", txtbarkodno.Text);
                komut.Parameters.AddWithValue("@kategori", combokategori.Text);
                komut.Parameters.AddWithValue("@marka", combomarka.Text);
                komut.Parameters.AddWithValue("@ürünadı", txtürünadı.Text);
                komut.Parameters.AddWithValue("@miktarı", int.Parse(txtmiktarı.Text));
                komut.Parameters.AddWithValue("@alışfiyatı", double.Parse(txtalışfiyatı.Text));
                komut.Parameters.AddWithValue("@satışfiyatı", double.Parse(txtsatışfiyatı.Text));
                komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("ÜRÜN EKLENDİ");
            }
            else
            {
                MessageBox.Show("BÖYLE BİR BARKOD VARDIR!", "UYARI");
            }
           
            combomarka.Items.Clear();
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }

        }

        private void barkodnotxt_TextChanged(object sender, EventArgs e)
        {
            if (barkodnotxt.Text == "")
            {
                lblmiktarı.Text = "";
                foreach (Control item in groupBox2.Controls)
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select*from ürün where barkodno like '" + barkodnotxt.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                kategoritxt.Text = read["kategori"].ToString();
                markatxt.Text = read["marka"].ToString();
                ürünadıtxt.Text = read["ürünadı"].ToString();
                lblmiktarı.Text = read["miktarı"].ToString();
                alışfiyatıtxt.Text = read["alışfiyatı"].ToString();
                satışfiyatıtxt.Text = read["satışfiyatı"].ToString();

            }
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update ürün set miktarı = miktarı+'" + int.Parse(miktarıtxt.Text) + "' where barkodno='" +barkodnotxt.Text+ "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            foreach (Control item in groupBox2.Controls)
                if (item is TextBox)
                {
                    item.Text = "";
                }
            MessageBox.Show("VAR OLAN ÜRÜN GÜNCELLENDİ");
        }
        
       
    }
}
