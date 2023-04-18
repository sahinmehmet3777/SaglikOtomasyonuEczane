using Dapper;
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

namespace SağlıkOtomasyonu
{
    public partial class kullanici_girisi : MaterialForm
    {
        SqlConnection sqlcon = new SqlConnection("Server = DESKTOP-S9I64H7;Initial Catalog = SaglıkOtomasyonu; Trusted_Connection=True");
        public kullanici_girisi()
        {
            InitializeComponent();
        }

        private void kullanici_girisi_Load(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE);
        }

       
        
        private void materialCheckbox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
