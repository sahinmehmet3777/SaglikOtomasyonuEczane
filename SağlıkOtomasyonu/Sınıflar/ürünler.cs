using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SağlıkOtomasyonu.Sınıflar
{
    
    abstract class ürünler
        {
    
        public string Barkod
        {
            get;
        }
        public string UrunAdi
        {
            get; set;
        }
        public string UrunGrubu
        {
            get;
        }
        public int TıbbiUrunAdet
        {
            get;
        }

        public int Fiyat
        {
            get;
        }
        public int IsyeriID
        {
            get;set;
        }



         public abstract void Ozellikyaz();



    }

}
