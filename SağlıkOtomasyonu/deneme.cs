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
    public partial class deneme : Form
    {
        public deneme()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Server=DESKTOP-7EA7R1P;Database=SaglıkOtomasyonu;Trusted_Connection=True;");
        SqlDataAdapter dap;
        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu1 = "select * from Ilaclar";

            SqlCommand cmd1 = new SqlCommand(sorgu1, conn);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();

                SqlDataReader dr = cmd1.ExecuteReader();
                DataTable dt = new DataTable();

                if (dr.HasRows)
                {
                  
                    dt.Load(dr);
                    dataGridView1.DataSource = dt;
                    MessageBox.Show("İşlemBaşarılı");
                }
            }
            else
            {
                conn.Close();
            }

        }
    }
}
