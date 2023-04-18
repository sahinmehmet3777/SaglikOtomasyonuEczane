using Dapper;
using MaterialSkin;
using MaterialSkin.Controls;
using SağlıkOtomasyonu.Sınıflar;
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

namespace SağlıkOtomasyonu
{

    public partial class tıbbi : MaterialForm
    {
        public tıbbi()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Server=DESKTOP-7EA7R1P;Database=SaglıkOtomasyonu;Trusted_Connection=True;");
        SqlDataAdapter dap;
        DataTable tablo = new DataTable();

        private void tıbbi_Load(object sender, EventArgs e)
        {
            
            dap = new SqlDataAdapter("select t.UrunAdi,t.UrunGrubu,t.UrunKullanımAlanı,t.Menşei,t.Imal_Ital,t.Fiyat from TıbbiUrun t;select TıbbiUrunReceteID,DoktorID,Tarih,HastaAd,UrunAdi from TıbbiUrunRecete Where HastaID is null;select *from Hastalar", conn);
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

        private void materialButton1_Click(object sender, EventArgs e)// sepete ekle
        {
            tablo.Rows.Add(dataGridtıbbi.CurrentRow.Cells[0].Value.ToString(), 1, dataGridtıbbi.CurrentRow.Cells[5].Value.ToString());
        }

        private void materialButton2_Click(object sender, EventArgs e) // sepet tutarı hesapla
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
            tablo.Rows.Add(a.ToString(), null, b.ToString());
        }

        private void tıbbiuruntxt_Click(object sender, EventArgs e)
        {

        }

        private void tıbbiuruntxt_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridtıbbi.DataSource;
            bs.Filter = string.Format("CONVERT({0},System.String) LIKE '%{1}%' and CONVERT({2},System.String) LIKE '%{3}' ", dataGridtıbbi.Columns[0].DataPropertyName, tıbbiuruntxt.Text, dataGridtıbbi.Columns[5].DataPropertyName, isyeritxt.Text);
        }

        private void isyeritxt_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridtıbbi.DataSource;
            bs.Filter = string.Format("CONVERT({0},System.String) LIKE '%{1}%' and CONVERT({2},System.String) LIKE '%{3}' ", dataGridtıbbi.Columns[0].DataPropertyName, tıbbiuruntxt.Text, dataGridtıbbi.Columns[5].DataPropertyName, isyeritxt.Text);
        }
    }
    
}
