using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SağlıkOtomasyonu
{
    public partial class Eczane : MaterialForm
    {
        public Eczane()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Server=DESKTOP-7EA7R1P;Database=SaglıkOtomasyonu;Trusted_Connection=True;");
        SqlDataAdapter dap;
        DataTable tablo = new DataTable();

        private void Eczane_Load(object sender, EventArgs e)
        {
            dap = new SqlDataAdapter("select i.IlacID,i.UrunAdi,i.EtkinMadde,i.ReceteTuru,i.KullanımYaşı,i.Fiyat,bb.EczaneId from Ilaclar i inner join IlacStok bb on bb.IlacstokID = i.IlacID ; select IReceteID,DoktorID,Tarih,HastaAd,ilacAd from IlacRecete where HastaID is null;select *from Hastalar", conn);
            DataSet ds = new DataSet();
            dap.Fill(ds);
            dataGridtıbbi.DataSource = ds.Tables[0];
            dataGridView2.DataSource = ds.Tables[1];
            dataGridView1.DataSource = ds.Tables[2];

            //--------------data gfride kolon ekleme
            tablo.Columns.Add("Ürün Adı", typeof(string));
            tablo.Columns.Add("Adet", typeof(int));
            tablo.Columns.Add("Fiyat", typeof(double));
            dataGridView3.DataSource = tablo;

        }

        

        private void materialButton1_Click(object sender, EventArgs e)
        {
            tablo.Rows.Add(dataGridtıbbi.CurrentRow.Cells[1].Value.ToString(), 1, dataGridtıbbi.CurrentRow.Cells[5].Value.ToString());
            //tablo.Rows.Add("Sepet Tutarı"," ", "Dolacak");

        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            double toplam = 0;
            double gtoplam = 0;
            double adet = 0;
            double bfiyat = 0;
            for (int i = 0; i < dataGridView3.Rows.Count; i++)
            {
                adet += Convert.ToDouble(dataGridView3.Rows[i].Cells[1].Value);
                bfiyat += Convert.ToDouble(dataGridView3.Rows[i].Cells[2].Value);
                toplam += bfiyat * adet;
                gtoplam = gtoplam + toplam;
                adet = 0;
                toplam = 0;
                bfiyat = 0;
            }
            toplam = 0;
            //------------------
            string a = "Sepet Tutarı";
            string b = $"{gtoplam}";
            tablo.Rows.Add(a.ToString(),null,b.ToString());

            //---------------------------- inserted yaptırıcaz
            //string sorgu1 = "Select CategoryName,Description from Categories";
            //string sorgu2 = "Insert IlacStok (CategoryName,Description) values (@catName,@desc)";

            //SqlCommand cmd1 = new SqlCommand(sorgu1, conn);
            //SqlCommand cmd2 = new SqlCommand(sorgu2, conn);

            //cmd2.Parameters.AddWithValue("@catName", dataGridtıbbi.CurrentRow.Cells[0].Value.ToString());
            //cmd2.Parameters.AddWithValue("@desc", textBox1.Text);

            //if (conn.State == ConnectionState.Closed)
            //{
            //    conn.Open();
            //    cmd2.ExecuteNonQuery();

            //    SqlDataReader dr = cmd1.ExecuteReader();
            //    DataTable dt = new DataTable();

            //    if (dr.HasRows)
            //    {
            //        //while (dr.Read())
            //        //{
            //        //ödev
            //        //}
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

        private void tıbbiuruntxt_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridtıbbi.DataSource;
            bs.Filter = string.Format("CONVERT({0},System.String) LIKE '%{1}%' and CONVERT({2},System.String) LIKE '%{3}' " , dataGridtıbbi.Columns[0].DataPropertyName, tıbbiuruntxt.Text, dataGridtıbbi.Columns[5].DataPropertyName, isyeritxt.Text);
        }

        private void isyeritxt_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridtıbbi.DataSource;
            bs.Filter = string.Format("CONVERT({0},System.String) LIKE '%{1}%' and CONVERT({2},System.String) LIKE '%{3}' " , dataGridtıbbi.Columns[0].DataPropertyName, tıbbiuruntxt.Text, dataGridtıbbi.Columns[5].DataPropertyName, isyeritxt.Text);
            
        }

        private void dataGridtıbbi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tıbbiuruntxt_Click(object sender, EventArgs e)
        {

        }
    }
}
