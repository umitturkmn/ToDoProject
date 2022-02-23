using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoProject
{
    public class Board
    {
        Dictionary<int, string> kisiler = new Dictionary<int, string>();


        List<Card> TODO = new List<Card>();
        List<Card> INPROGRESS = new List<Card>();
        List<Card> DONE = new List<Card>();

        public Board()
        {
            kisiler.Add(0, "Beytullah KALAY");
            kisiler.Add(1, "Kutup YAZAR");
            kisiler.Add(2, "Okan AYDUZ");
            kisiler.Add(3, "Dervis AKKOC");
            kisiler.Add(4, "Refik ACA");
            kisiler.Add(482,"Ümit Türkmen");
            kisiler.Add(234,"Ahmet Türkmen");
            kisiler.Add(34,"Mavera Türkmen");
            kisiler.Add(455,"Selim KocaBıyık");
            kisiler.Add(55,"Çetin Arslan");
            kisiler.Add(622,"Mahmut Sultanoğlu");

            TODO.Add(new Card("Temizlik", "Yerleri Supur", "Beytullah KALAY",Card.Buyukluk.M));
            INPROGRESS.Add(new Card("Temizlik", "Camlari Sil", "Okan AYDUZ",Card.Buyukluk.S));
            DONE.Add(new Card("Spor", "2 Km Kos", "Dervis AKKOC",Card.Buyukluk.L));
            DONE.Add(new Card("Ev", "Alisveris Yap", "Refik ACA",Card.Buyukluk.XL));
            INPROGRESS.Add(new Card("Temizlik", "Toz Al", "Kutup YAZAR",Card.Buyukluk.XS));
            TODO.Add(new Card("Spor Yap","Yüzmeye Git","Ümit Türkmen",Card.Buyukluk.L));
            INPROGRESS.Add(new Card("Spor","Fitnessa git.","Ahmet Türkmen",Card.Buyukluk.M));
            DONE.Add(new Card("Araba Bakımı","Sanayiye Git","Mavera Türkmen",Card.Buyukluk.XL));
            TODO.Add(new Card("Temzilik","Evi temizle","Selim KocaBıyık",Card.Buyukluk.S));
            INPROGRESS.Add(new Card("Markete Git","Alışveriş Yap","Çetin Arslan",Card.Buyukluk.XS));
            DONE.Add(new Card("Eğlen","Film izle","Mahmut Sultanoğlu",Card.Buyukluk.S));
        }


        public void BoardListele()
        {
            Console.WriteLine("*******************************************");
            Console.WriteLine("***************-Listeler-******************");
            Console.WriteLine("*******************************************");
            Console.WriteLine("**************-TODO LINE-******************");
            Console.WriteLine("*******************************************");
            foreach (var Card in TODO)
            {
                Console.WriteLine("Başlık      :{0}",Card.Baslik);
                Console.WriteLine("İçerik      :{0}",Card.Icerik);
                Console.WriteLine("Atanan Kişi :{0}",Card.AtananId);
                Console.WriteLine("Büyüklük    :{0}",Card.Boyut);
                Console.WriteLine("*******************************************");
            }
            Console.WriteLine("*************-IN PROGRESS LINE-************");
            Console.WriteLine("*******************************************");
            foreach (var Card in INPROGRESS)
            {
                Console.WriteLine("Başlık      :{0}",Card.Baslik);
                Console.WriteLine("İçerik      :{0}",Card.Icerik);
                Console.WriteLine("Atanan Kişi :{0}",Card.AtananId);
                Console.WriteLine("Büyüklük    :{0}",Card.Boyut);
                Console.WriteLine("*******************************************");
            }
            Console.WriteLine("***************-DONE LINE-*****************");
            Console.WriteLine("*******************************************");
            foreach (var Card in DONE)
            {
                Console.WriteLine("Başlık      :{0}",Card.Baslik);
                Console.WriteLine("İçerik      :{0}",Card.Icerik);
                Console.WriteLine("Atanan Kişi :{0}",Card.AtananId);
                Console.WriteLine("Büyüklük    :{0}",Card.Boyut);
                Console.WriteLine("*******************************************");
            }
        }
        public void KisiListele()
        {
            Console.WriteLine("*******************************************");
            Console.WriteLine("***************-Kişiler-******************");
            Console.WriteLine("*******************************************");
            foreach (var item in kisiler)
            {
                Console.WriteLine("ID: {0}",item.Key);
                Console.WriteLine("Ad Soyad: {0}",item.Value);
                Console.WriteLine("*******************************************");
            }

        }
        public void KartEkle()
        {
            Console.WriteLine("*******************************************");
            Console.WriteLine("*************-Kart Ekleme-*****************");
            Console.WriteLine("*******************************************");
            string baslik = StringControl("Başlık Giriniz: ");
            string icerik = StringControl("İçerik Giriniz: ");
            Console.Write("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5): ");
            int buyukluk = int.Parse(Console.ReadLine());
            Console.Write("Kişi Id giriniz: ");
            int kisi = int.Parse(Console.ReadLine());
            if (kisiler.ContainsKey(kisi) & buyukluk == 1 )
            {
                TODO.Add(new Card(baslik,icerik,kisiler[kisi],Card.Buyukluk.XS));
                Console.WriteLine("Board Kaydedilmiştir.");
            } 
            else if (kisiler.ContainsKey(kisi) & buyukluk == 2 )
            {
                TODO.Add(new Card(baslik,icerik,kisiler[kisi],Card.Buyukluk.S));
                Console.WriteLine("Board Kaydedilmiştir.");
            }
            else if (kisiler.ContainsKey(kisi) & buyukluk == 3 )
            {
                TODO.Add(new Card(baslik,icerik,kisiler[kisi],Card.Buyukluk.M));
                Console.WriteLine("Board Kaydedilmiştir.");
            }
            else if (kisiler.ContainsKey(kisi) & buyukluk == 4 )
            {
                TODO.Add(new Card(baslik,icerik,kisiler[kisi],Card.Buyukluk.L));
                Console.WriteLine("Board Kaydedilmiştir.");
            }
            else if (kisiler.ContainsKey(kisi) & buyukluk == 5 )
            {
                TODO.Add(new Card(baslik,icerik,kisiler[kisi],Card.Buyukluk.XL));
                Console.WriteLine("Board Kaydedilmiştir.");
            } else
            {
                 Console.WriteLine("Hatalı veya eksik tuşladınız.");
            }

        }
        public string StringControl(string text)
        {
            string str = "";
            bool control = true;
            int num = 1;
            while (control)
            {
                Console.Write(text);
                str = FirstLetterGrowUp(Console.ReadLine());
                string str2 = "1234567890!^+-*/?*.,#%&:;()={}[]-_\"<>'\\~@|";
                foreach (char item in str)
                {
                    if (str2.Contains(str)) 
                    {
                        Console.WriteLine("Hatalı İsim Girdiniz Tekrar Deneyiniz.");
                        break;
                    }
                    if (str.Length == num)
                    {
                        control = false;
                        break;
                    }
                    num++;
                }
            }
            return str;
        }
        public static string FirstLetterGrowUp(string veri)
        {
            if (veri.Length > 0)
            {
                veri = veri.Substring(0, 1).ToUpper() + veri.Substring(1).ToLower();
                return veri;
            }
            return veri;
        }
        
    }
}

    
   
    
   


