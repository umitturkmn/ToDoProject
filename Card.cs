using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoProject
{
    public class Card
    {
        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public string AtananId { get; set; }
        public Buyukluk Boyut { get; set; }

        public enum Buyukluk
        {
            XS,
            S,
            M,
            L,
            XL
        } 

        public Card(string baslik,string icerik,string atananId,Buyukluk boyut)
        {
            Baslik = baslik;
            Icerik = icerik;
            AtananId = atananId;
            Boyut = boyut;
        }
    }
}