using MaterialSkin;
using MaterialSkin.Controls;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SağlıkOtomasyonu
{
    public partial class doktor : MaterialForm
    {
        public doktor()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Server=DESKTOP-7EA7R1P;Database=SaglıkOtomasyonu;Trusted_Connection=True;");
        SqlDataAdapter dap;
        private void doktor_Load(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE);
            
            dap = new SqlDataAdapter("select UrunAdi,EtkinMadde,ReceteTuru,KullanımYaşı from Ilaclar; select IReceteID,DoktorID,Tarih,HastaAd,ilacAd from IlacRecete where HastaID is null;select *from Hastalar;", conn);
            DataSet ds = new DataSet();
            dap.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView2.DataSource = ds.Tables[1];
            dataGridView3.DataSource = ds.Tables[2];

            textBox2.Text = DateTime.Today.ToShortDateString();
            textBox3.Text = "5";
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void materialTabControl1_Click(object sender, EventArgs e)
        {
            //string sorgu1 = "select * from Ilaclar";

            //SqlCommand cmd1 = new SqlCommand(sorgu1, conn);
            //if (conn.State == ConnectionState.Closed)
            //{
            //    conn.Open();

            //    SqlDataReader dr = cmd1.ExecuteReader();
            //    DataTable dt = new DataTable();

            //    if (dr.HasRows)
            //    {

            //        dt.Load(dr);
            //        dataGridView1.DataSource = dt;
            //        MessageBox.Show("İşlemBaşarılı");
            //    }
            //}
            //else
            //{
            //    conn.Close();
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string sorgu1 = "select * from Ilaclar";

            //SqlCommand cmd1 = new SqlCommand(sorgu1, conn);
            //if (conn.State == ConnectionState.Closed)
            //{
            //    conn.Open();

            //    SqlDataReader dr = cmd1.ExecuteReader();
            //    DataTable dt = new DataTable();

            //    if (dr.HasRows)
            //    {

            //        dt.Load(dr);
            //        dataGridView1.DataSource = dt;
            //        MessageBox.Show("İşlemBaşarılı");
            //    }
            //}
            //else
            //{
            //    conn.Close();
            //}

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            //string sorgu1 = "select * from Ilaclar";

            //SqlCommand cmd1 = new SqlCommand(sorgu1, conn);
            //if (conn.State == ConnectionState.Closed)
            //{
            //    conn.Open();

            //    SqlDataReader dr = cmd1.ExecuteReader();
            //    DataTable dt = new DataTable();

            //    if (dr.HasRows)
            //    {

            //        dt.Load(dr);
            //        dataGridView1.DataSource = dt;
            //        MessageBox.Show("İşlemBaşarılı");
            //    }
            //}
            //else
            //{
            //    conn.Close();
            //}
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

        }

        private void materialTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string sorgu1 = "select * from Ilaclar";

            //SqlCommand cmd1 = new SqlCommand(sorgu1, conn);
            //if (conn.State == ConnectionState.Closed)
            //{
            //    conn.Open();

            //    SqlDataReader dr = cmd1.ExecuteReader();
            //    DataTable dt = new DataTable();

            //    if (dr.HasRows)
            //    {

            //        dt.Load(dr);
            //        dataGridView1.DataSource = dt;
            //        MessageBox.Show("İşlemBaşarılı");
            //    }
            //}
            //else
            //{
            //    conn.Close();
            //}
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            
        }

        private void dataGridView3_DoubleClick(object sender, EventArgs e)
        {
            textBox4.Text = dataGridView3.CurrentRow.Cells[1].Value.ToString()+" "+ dataGridView3.CurrentRow.Cells[2].Value.ToString();
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            //insert IlacRecete(DoktorID, Tarih, HastaAd, ilacAd) values(@doktor, @tarih, @ad, @ilac)
            string sorgu2 = "insert IlacRecete(DoktorID, Tarih, HastaAd, ilacAd) values(@doktor, @tarih, @ad, @ilac)";
            string sorgu1 = "select IReceteID,DoktorID,Tarih,HastaAd,ilacAd from IlacRecete where HastaID is null";
            

            SqlCommand cmd1 = new SqlCommand(sorgu1, conn);
            SqlCommand cmd2 = new SqlCommand(sorgu2, conn);

            cmd2.Parameters.AddWithValue("@doktor", textBox3.Text);
            cmd2.Parameters.AddWithValue("@tarih", textBox2.Text);
            cmd2.Parameters.AddWithValue("@ad", textBox4.Text);
            cmd2.Parameters.AddWithValue("@ilac", textBox1.Text);

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                cmd2.ExecuteNonQuery();

                SqlDataReader dr = cmd1.ExecuteReader();
                DataTable dt = new DataTable();

                if (dr.HasRows)
                {
                   
                    dt.Load(dr);
                    dataGridView2.DataSource = dt;
                    MessageBox.Show("İşlemBaşarılı");
                }
            }
            else
            {
                conn.Close();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
