using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoProject
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            
            Board okay = new Board();
            Console.WriteLine("*******************************************");
            Console.WriteLine("******-ToDo Uygulamasına Hoşgeldiniz.-*****");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(L) Board Listelemek");
            Console.WriteLine("(Y) Board'a Kart Eklemek");
            Console.WriteLine("(S) Board'dan Kart Silmek");
            Console.WriteLine("(T) Kart Taşımak");
            Console.WriteLine("(K) Kişi Listele");
            Console.WriteLine("(X) Çıkış");
            while (true)
            {
                Console.WriteLine("Yapmak İstediğiniz İşlemi Seçiniz.");
                string secim = okay.StringControl("Seçiminiz: ");
                switch (secim.ToUpper())
                {
                    case "L":
                        okay.BoardListele();
                        break;
                    case "K":
                        okay.KisiListele();
                        break;
                    case "Y":
                        okay.KartEkle();
                        break;
                    case "S":
                        okay.KartSil();
                        break;
                    case "T":
                        okay.KartTasima();
                        break;
                    case "X":
                        Console.WriteLine("Çıkış yapılıyor. Hoşçakalın.");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Hatalı tuşladınız.");
                        break;
                }
            }
            
            






        }
    }
}
