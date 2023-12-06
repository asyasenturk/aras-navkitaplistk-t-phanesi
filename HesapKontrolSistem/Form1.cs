using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HesapKontrolSistem
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;

#nullable disable
        public Form1()
        {
            InitializeComponent();
        }
        void KitapGetir()
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-F5B7PAA\\SQLEXPRESS; Initial Catalog=library; Integrated Security=True");


            baglanti.Open();
            da = new SqlDataAdapter("SELECT *FROM kutup_table2", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KitapGetir();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtKno.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtYazar.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtKategori.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtTarih.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtBarcode.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO kutup_table2(KitapAdi,YazarAdi,Kategori,YayinTarihi,Barkod) VALUES  (@KitapAdi,@YazarAdi,@Kategori,@YayinTarihi,@Barkod)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@KitapAdi", txtKno.Text);
            komut.Parameters.AddWithValue("@YazarAdi", txtYazar.Text);
            komut.Parameters.AddWithValue("@Kategori", txtKategori.Text);
            komut.Parameters.AddWithValue("@YayinTarihi", txtTarih.Text);
            komut.Parameters.AddWithValue("@Barkod", txtBarcode.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            KitapGetir();


        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM kutup_table2 WHERE KitapNo=@KitapNo";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@KitapNo", Convert.ToInt32(txtKno.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            KitapGetir();



        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE kutup_table2 SET KitapAdi=@KitapAdi, YazarAdi=@YazarAdi, Kategori=@Kategori, YayinTarihi=@YayinTarihi , Barkod=@Barkod WHERE KitapNo=@KitapNo";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@KitapNo", Convert.ToInt32(txtKno.Text));
            komut.Parameters.AddWithValue("@KitapAdi", txtAd.Text);
            komut.Parameters.AddWithValue("@YazarAdi", txtYazar.Text);
            komut.Parameters.AddWithValue("@Kategori", txtKategori.Text);
            komut.Parameters.AddWithValue("@YayinTarihi",Convert.ToInt32(txtTarih.Text));
            komut.Parameters.AddWithValue("@Barkod", Convert.ToInt32(txtBarcode.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            KitapGetir();


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
