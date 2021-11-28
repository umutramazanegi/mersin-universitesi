using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AskeriPersonelKayit    //Projenin adını belirledim.
{
    class AskeriPersonel        //AskeriPersonel isminde bir sınıf tanımladım.
    {
        //Sınıf içerisinde kullanacağım özellikler için askeri personel bilgilerinin tutulacağı değişkenler tanımladım.
        string isim, soyisim, rutbe = null, hangikomutanlık = null;
        double maas;
        int izinGunu;
        string ayrac = new string('-', 20);   //20 tane yan yana çizi oluşturdum.

        //Personel kaydı oluşturmak için setAskeriPersonelBilgileri isminde metot tanımlaması yaptım.
        //Metot içerisinde değerlerin güncelleneceği bir if-else kontrol yapısı oluşturdum.
        public void setAskeriPersonelBilgileri(string isim, string soyisim, double maas)
        {
            if (isim.Length > 0 && soyisim.Length > 0)  // Eğer isim uzunluğu 0 dan büyük ve soyisim uznunluğı sıfırdan büyükse bu kod bloğuna gir.                      .                                                                                  

            {
                if (maas >= 2500)                      //Maaşı 2500 den büyük ve eşit olursa bu kod bloğuna gir.
                {
                    this.isim = isim;
                    this.soyisim = soyisim;
                    this.hangikomutanlık = "Kara Kuvvetleri Komutanlığı";
                    this.maas = maas;
                    this.izinGunu = 7;

                    if (maas >= 3000 && maas <= 4000)  //Maaşı 3000 den büyük ve eşit ve 4000 den küçük ve eşit olursa bu kod bloğuna gir.
                    {
                        this.hangikomutanlık = "Hava Kuvvetleri Komutanlığı";
                        this.rutbe = "Kıdemli Askeri Personel";
                        this.izinGunu = 15;
                    }
                    else if (maas >= 4001 && maas <= 5500)  //Maaşı 4001 den büyük ve eşit ve 5500 den küçük ve eşit olursa bu kod bloğuna gir.
                    {
                        this.hangikomutanlık = "Deniz Kuvvetleri Komutanlığı";
                        this.rutbe = "Kıdemli + Personel";
                        this.izinGunu = 20;
                    }
                    else if (maas > 5500)                 //Maaşı 5500 den büyükse bu kod bloğuna gir.
                    {
                        this.hangikomutanlık = "Kara Kuvvetleri Komutanlığı";
                        this.rutbe = "Uzman Askeri Personel";
                        this.izinGunu = 30;
                    }

                    else
                        this.rutbe = "Er Askeri Personel";
                }
                else
                {
                    Console.Clear();                    //Konsolu temizle
                    Console.WriteLine("{0}\n<Askeri Personel Oluşturulamadı>\n{1}\n-> Kışla içerisinde bir askeri personelin en az 2500 TL maaşı olması gerekmektedir.\n{2}", ayrac, ayrac, ayrac);  //Konsola yazdırma işlemini yaptım.
                }
            }
        }//Personel bilgilerini aldıktan sonra, oluşturulan personel bilgilerini göstermek için getPersonelBilgileri isminde geriye değer döndüren bir metot tanımlayarak, oluşturmuş olduğumuz personelin bilgilerini yazdırtıyorum.
        public string getAskeriPersonelBilgileri()
        {
            if (rutbe != null)
                return ayrac + "\n<Askeri Personel Oluşturuldu>\n" + ayrac + "\n-> Askeri Personel İsmi: " + isim + "\n-> Askeri Personel Soyismi: " + soyisim + "\n-> Komutanlık: " + hangikomutanlık + "\n-> Askeri Personel Maaşı: " + maas + " TL\n-> Askeri Personel Rütbesi: " + rutbe + "\n-> Askeri Personel İzin Günü: " + izinGunu + " Gün\n" + ayrac;
            else
                return ayrac + "\n<Askeri Personel Oluşturmanız Gerekiyor>\n" + ayrac + "\n-> Askeri Personel bilgililerine erişilemiyor. Lütfen önce bir askeri personel oluşturun.\n" + ayrac;
        }
    }
}
