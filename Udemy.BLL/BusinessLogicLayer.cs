using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Udemy.core;
using Udemy.Entities;

namespace Udemy.BLL
{
    public class BusinessLogicLayer
    {

        //BLL
        Udemy.core.DatabaseLogicLayer DLL;


        public BusinessLogicLayer()
        {
            DLL=new DatabaseLogicLayer();
        }



        public int KullaniciKontrol(string KullaniciAdi,string sifre )
        {
            int Sonuc = 0;
            if (!string.IsNullOrEmpty(KullaniciAdi)&&!string.IsNullOrEmpty(sifre))
            {
                Kullanici kullanici=new Kullanici();

                kullanici.KullaniciAdi = KullaniciAdi;
                kullanici.Sifre = sifre;
                Sonuc = DLL.KullaniciKontrol(kullanici);  


            }
            else
            {
                Sonuc = -100;//Eksik Parametre hatası
            }

            return Sonuc;

        }

        public int Yenikayit(Guid ID,string Isim,string Soyisim, string Telefon1, string Telefon2, string Telefon3,string Adres,string EmailAdres,string WebAdres ,string Aciklama)
        {

            int sonuc = 0;
            if (ID!=Guid.Empty&& !string.IsNullOrEmpty(Isim)&&!string.IsNullOrEmpty(Soyisim)&&!string.IsNullOrEmpty(Telefon1))
            {
             RehberKayit Kayit=new RehberKayit();


                Kayit.ID = ID;
                Kayit.Isim = Isim;
                Kayit.Soyisim = Soyisim;
                Kayit.Telefon1 = Telefon1;
                Kayit.Telefon2 = Telefon2;
                Kayit.Telefon3 = Telefon3;
                Kayit.Aciklama = Aciklama;
                Kayit.WebAdres = WebAdres;
                Kayit.EmailAdres = EmailAdres;
                Kayit.Adres = Adres;

               sonuc=DLL.YeniKayit(Kayit);


            }
            else
            {
                sonuc = -100;//Eksik parametre hatası
            }

            return sonuc;
        }


        public int KayitSil(Guid Id)
        {

            return  DLL.KayitSil(Id);



        }


        public int KayitGuncelle(Guid ID, string Isim, string Soyisim, string Telefon1, string Telefon2, string Telefon3, string Adres, string EmailAdres, string WebAdres, string Aciklama)
        {
            int sonuc = 0;


            if (ID!=Guid.Empty &&!string.IsNullOrEmpty(Isim)&&!string.IsNullOrEmpty(Soyisim)&&!string.IsNullOrEmpty(Telefon1))
            {
                RehberKayit Kayit = new RehberKayit();


                Kayit.ID = ID;
                Kayit.Isim = Isim;
                Kayit.Soyisim = Soyisim;
                Kayit.Telefon1 = Telefon1;
                Kayit.Telefon2 = Telefon2;
                Kayit.Telefon3 = Telefon3;
                Kayit.Aciklama = Aciklama;
                Kayit.WebAdres = WebAdres;
                Kayit.EmailAdres = EmailAdres;
                Kayit.Adres = Adres;

             sonuc=DLL.KayitGuncelle(Kayit);
            }
          
            else
            {
                sonuc = -100;
            }



            return sonuc;
        }


        public List<RehberKayit> RehberKayitlariGetir()
        {


            return DLL.RehberKayitlariGetir();
        }

        public int XmlVer()
        {

            int sonuc = 0;

            List<RehberKayit> Kayitlarim = DLL.RehberKayitlariGetir();

            try
            {
                XDocument Doc = new XDocument(new XDeclaration("1.0.0.1","UTF-8","yes"),
                    new XElement("RehberKayitlar",Kayitlarim.Select(x=>new XElement("Kayit",
                        new XElement("ID",x.ID),
                        new XElement("Isim",x.Isim),
                        new XElement("SoyIsim", x.Soyisim),
                        new XElement("Telefon1",x.Telefon1),
                        new XElement("Telefon2",x.Telefon2),
                        new XElement("Telefon3",x.Telefon3),
                        new XElement("Adres",x.Adres),
                        new XElement("Aciklama",x.Aciklama),
                        new XElement("WebSite",x.WebAdres),
                        new XElement("EmailAdres",x.EmailAdres)))));

                Doc.Save(@"c:\Uygulamalar\TelefonRehberiDB\Xml.xml");
                sonuc = 1;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }





            return sonuc;
        }


        public int JsonVer()
        {

            int sonuc = 0;

            try
            {
                List<RehberKayit> Kayitlar = DLL.RehberKayitlariGetir();

                string Json = Newtonsoft.Json.JsonConvert.SerializeObject(Kayitlar);

                File.WriteAllText(@"C:\Uygulamalar\TelefonRehberiDB\jsondata.json",Json);
                sonuc = 1;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }


            return sonuc;
        }


    }
}
