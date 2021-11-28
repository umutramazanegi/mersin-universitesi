using System;

namespace AskeriPersonelKayit
{
    class Program
    {
        static void Main(string[] args)
        {
            ///---> C# Nesne Tanımlama İşlemleri <---\\\
            AskeriPersonel mehmet = new AskeriPersonel();
            AskeriPersonel ali = new AskeriPersonel();
            AskeriPersonel mustafa = new AskeriPersonel();
            AskeriPersonel murat = new AskeriPersonel(); ///---> Personel bilgisi girişi yapmadığımız için ekrana yazdırırken uyarı verecektir.
                                                         ///---> Personel Bilgilerini Oluşturalım <---\\\
            mehmet.setAskeriPersonelBilgileri("Mehmet", "Aslantürk", 2500);
            ali.setAskeriPersonelBilgileri("Ali", "Yurt", 3750);
            mustafa.setAskeriPersonelBilgileri("Mustafa", "Korkmaz", 7000);
            ///---> Oluşturmuş Olduğumuz Personellerin Bilgisini Yazdıralım <---\\\
            Console.WriteLine(mehmet.getAskeriPersonelBilgileri());
            Console.WriteLine(ali.getAskeriPersonelBilgileri());
            Console.WriteLine(mustafa.getAskeriPersonelBilgileri());
            Console.WriteLine(murat.getAskeriPersonelBilgileri());
        }
    }
}
