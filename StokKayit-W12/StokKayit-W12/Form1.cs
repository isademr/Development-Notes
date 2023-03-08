using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokKayit_W12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        SqlConnection baglanti = new SqlConnection("Data Source=TRIST-LR90S9GZ5;Initial Catalog=Stok3; Integrated Security=True ");

       
        private void Form1_Load_1(object sender, EventArgs e)
        {
            listele();
        }

        private void listele() // veri tabanındaki güncel kayıtların görüntülenmesi
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select *from Malzemeler", baglanti);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
            baglanti.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

		private void btnEkle_Click(object sender, EventArgs e)
		{
            //EKLE
            String t1 = textBox1.Text;  // MalzemeKodu
            String t2 = textBox2.Text;  //MalzemeAdi
            String t3 = textBox3.Text;  //YillikSatis
            String t4 = textBox4.Text;  //BirimFiyat
            String t5 = textBox5.Text;  //MinStok
            String t6 = textBox6.Text;  //TSuresi

            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO Malzemeler(MalzemeKodu,MalzemeAdi,YillikSatis,BirimFiyat,MinStok,TSuresi)VALUES('" + t1 + "', '" + t2 + "', '" + t3 + "', '" + t4 + "', '" + t5 + "', '" + t6 + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            listele();

        }

		private void btn_Sil_Click(object sender, EventArgs e)
		{
            String t1 = textBox1.Text; //seçilen satırın malzeme kodunu al
            baglanti.Open();
            SqlCommand komut = new SqlCommand("DELETE FROM Malzemeler WHERE MalzemeKodu=('"+t1+"')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            listele();
		}

		private void btn_Guncelle_Click(object sender, EventArgs e)
		{
            String t1 = textBox1.Text;  // MalzemeKodu
            String t2 = textBox2.Text;  //MalzemeAdi
            String t3 = textBox3.Text;  //YillikSatis
            String t4 = textBox4.Text;  //BirimFiyat
            String t5 = textBox5.Text;  //MinStok
            String t6 = textBox6.Text;  //TSuresi

            baglanti.Open();
            SqlCommand komut = new SqlCommand("UPDATE Malzemeler SET MalzemeKodu='"+t1+"', MalzemeAdi ='"+t2+ "', YillikSatis='"+t3+ "', BirimFiyat='"+t4+ "' , MinStok='"+t5+ "',TSuresi='"+t6+"' WHERE MalzemeKodu = '" +t1+"' ", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            listele();
        }
	}
}
