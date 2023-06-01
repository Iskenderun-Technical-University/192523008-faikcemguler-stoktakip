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
    public partial class frmürünlistele : Form
    {
        public frmürünlistele()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=Fcmglr\\SQLEXPRESS;Initial Catalog=stok_takip;Integrated Security=True");
       DataSet daset = new DataSet();
        private void kategorigetir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from kategoribilgileri ", baglanti);
            SqlDataReader read = komut.ExecuteReader();

            while (read.Read())
            {
                COMBOKATEGORİ.Items.Add(read["kategori"].ToString());
            }
            baglanti.Close();
        }
        private void frmürünlistele_Load(object sender, EventArgs e)
        {
            ürünlistele();
            kategorigetir();
        }

        private void ürünlistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from ürün", baglanti);
            adtr.Fill(daset, "ürün");
            dataGridView1.DataSource = daset.Tables["ürün"];
            baglanti.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            barkodnotxt.Text = dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString();
            kategoritxt.Text = dataGridView1.CurrentRow.Cells["kategori"].Value.ToString();
            markatxt.Text = dataGridView1.CurrentRow.Cells["marka"].Value.ToString();
            ürünadıtxt.Text = dataGridView1.CurrentRow.Cells["ürünadı"].Value.ToString();
            miktarıtxt.Text = dataGridView1.CurrentRow.Cells["miktarı"].Value.ToString();
            alışfiyatıtxt.Text = dataGridView1.CurrentRow.Cells["alışfiyatı"].Value.ToString();
            satışfiyatıtxt.Text = dataGridView1.CurrentRow.Cells["satışfiyatı"].Value.ToString();
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update ürün set ürünadı=@ürünadı,miktarı=@miktarı,alışfiyatı=@alışfiyatı,satışfiyatı=@satışfiyatı where barkodno=@barkodno",baglanti);
            komut.Parameters.AddWithValue("@barkodno", barkodnotxt.Text);
            komut.Parameters.AddWithValue("@ürünadı", ürünadıtxt.Text);
            komut.Parameters.AddWithValue("@miktarı",int.Parse(miktarıtxt.Text));
            komut.Parameters.AddWithValue("@alışfiyatı",double.Parse(alışfiyatıtxt.Text));
            komut.Parameters.AddWithValue("@satışfiyatı",double.Parse(satışfiyatıtxt.Text));
            komut.ExecuteNonQuery();
             baglanti.Close();
            daset.Tables["ürün"].Clear();
            ürünlistele();
            MessageBox.Show("GÜNCELLEME YAPILDI");
            foreach (Control item in this.Controls )
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btnmarkagüncelle_Click(object sender, EventArgs e)
        {
            if (barkodnotxt.Text!="")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update ürün set kategori=@kategori,marka=@marka where barkodno=@barkodno", baglanti);
                komut.Parameters.AddWithValue("@barkodno", barkodnotxt.Text);
                komut.Parameters.AddWithValue("@kategori", COMBOKATEGORİ.Text);
                komut.Parameters.AddWithValue("@marka", COMBOMARKA.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("GÜNCELLEME YAPILDI");
                daset.Tables["ürün"].Clear();
                ürünlistele();
            }
            else
            {
                MessageBox.Show("BARKOD SEÇİLİ DEĞİL!");
            }
            
            foreach (Control item in this.Controls)
            {
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
        }

        private void COMBOKATEGORİ_SelectedIndexChanged(object sender, EventArgs e)
        {

            COMBOMARKA.Items.Clear();
            COMBOMARKA.Text = "";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from markabilgileri where kategori='" + COMBOKATEGORİ.SelectedItem + "'  ", baglanti);
            SqlDataReader read = komut.ExecuteReader();

            while (read.Read())
            {
                COMBOMARKA.Items.Add(read["marka"].ToString());
            }
            baglanti.Close();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from ürün where barkodno='" + dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["ürün"].Clear();
            ürünlistele();
            MessageBox.Show("KAYIT SİLİNDİ");

        }

        private void txtbarkodara_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from ürün where barkodno like '%" + txtbarkodara.Text + "%' ", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
    }
}
