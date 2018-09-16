using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.Entities;

namespace Udemy.core
{
    public class DatabaseLogicLayer
    {

        //DLL bu bölümde data kontrolü yapılmaz .


        private List<RehberKayit> Kayitlarim;//Kayitlari listelemek için bir lsite oluşturuldu 

            //ctor  tab ile kurucu metot açılabilir
        public DatabaseLogicLayer()
        {

            Kayitlarim = new List<RehberKayit>();//rehber kayit genericlist örneklendi 

            veriTabaniKontrol();


        }

        private void veriTabaniKontrol()
        {

            bool klasorKontrol=Directory.Exists(@"c:\Uygulamalar\TelefonRehberiDB\");//json  işlmelerinin kayıt edileceği dosya varmı yokmu kontrol ediliyor.

            if (!klasorKontrol)//dosya yok ise buraya girildi
            {

                Directory.CreateDirectory(@"c:\Uygulamalar\TelefonRehberiDB\");//dosya yok ise oluşturuldu.
                Kullanici demo =new Kullanici();//ilk kayıt için udemy.entities de kullnici tipinde class açıldı ve örneklendi 

                demo.ID = Guid.NewGuid();
                                              //ilk giriş için kayıtlar oluşturuldu.
                demo.KullaniciAdi = "Demo";
                demo.Sifre = "Demo";



             string jsonKullanicitext=Newtonsoft.Json.JsonConvert.SerializeObject(demo); //demo adındanki nesne json a çevrildi .
                



                File.WriteAllText(@"c:\Uygulamalar\TelefonRehberiDB\kullanici.json",jsonKullanicitext);//çevrilen verilen json dosyasına kaydediliyor.


            }



        }

        public int YeniKayit(RehberKayit K)
        {
            int sonuc = 0;
            try
            {
                RehberKayitlariGetir();//class seviyesinde oluştumuş olduğum koleksiyonum içerisine datamı doldurdum(varsa ) yok ise zaten bellek de hiçbir değeri yoktu yeni değer eklenmek üzere bekliyor.
                Kayitlarim.Add(K);//Koleksiyonumuza yeni değr ekledim.

                JsonDBGuncelle();//var ise üzerine yazdı ,yoksa yeni json oluşturdu.
                sonuc = 1;
            }
            catch (Exception e)
            {
//log

                sonuc = 0;
            }

            return sonuc;
        }


        public int KayitGuncelle(RehberKayit K)
        {
            int sonuc = 0;

            try
            {
                RehberKayitlariGetir();

                int Index = Kayitlarim.FindIndex(x => x.ID == K.ID);

                if (Index>-1)
                {

                    Kayitlarim[Index].Isim = K.Isim;
                    Kayitlarim[Index].Soyisim = K.Soyisim;
                    Kayitlarim[Index].Telefon1 = K.Telefon1;
                    Kayitlarim[Index].Telefon2 = K.Telefon2;
                    Kayitlarim[Index].Telefon3 = K.Telefon3;
                    Kayitlarim[Index].WebAdres = K.WebAdres;
                    Kayitlarim[Index].Adres = K.Adres;
                    Kayitlarim[Index].Aciklama = K.Aciklama;
                    Kayitlarim[Index].EmailAdres = K.EmailAdres;
                }
                JsonDBGuncelle();
                sonuc = 1;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }




            return sonuc;
        }





        public int KayitSil(Guid Id)
        {
            int sonuc = 0;


            try
            {
                RehberKayitlariGetir();
             RehberKayit SilinecekDeger=Kayitlarim.Find(x=>x.ID==Id);


                if (SilinecekDeger!=null)
                {

                    Kayitlarim.Remove(SilinecekDeger);
                


                }
                JsonDBGuncelle();
                sonuc = 1;



            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }


            return sonuc;
        }


        public List<RehberKayit> RehberKayitlariGetir()
        {


            if (File.Exists(@"c:\Uygulamalar\TelefonRehberiDB\Rehber.json"))
            {

            string JsonDbTExt=File.ReadAllText(@"c:\Uygulamalar\TelefonRehberiDB\Rehber.json");


                Kayitlarim = Newtonsoft.Json.JsonConvert.DeserializeObject<List<RehberKayit>>(JsonDbTExt);//json tipindeki veriler dönüştürülüp tekrar rehberkayit tipindeki genericliste ekleniyor.



            }


            return Kayitlarim;
        }


        public int KullaniciKontrol(Kullanici kullanici)
        {
            int kullaniciSonuc = 0;//kullanıcı yok ise 0 dönücek var ise 0 dan farklı bir değer dönücek
            if (File.Exists(@"c:\Uygulamalar\TelefonRehberiDB\kullanici.json"))//Dosyanın var olup olmadığını kontrol ediyor.
            {
                string KullaniciText = File.ReadAllText(@"c:\Uygulamalar\TelefonRehberiDB\kullanici.json");//dosyadan veriler okunuyor.

                List<Kullanici> Kullanicilar =Newtonsoft.Json.JsonConvert.DeserializeObject<List<Kullanici>>(KullaniciText);//dosyadan okunan veriler  DeserializeObject ile list generic  e dönüştürülüyor
                kullaniciSonuc =Kullanicilar.FindAll(x => x.KullaniciAdi == kullanici.KullaniciAdi && x.Sifre == kullanici.Sifre).ToList().Count();//Alınan veriler içerisinde arama işlemi yapılıyor gelen veriler ile karşlaştırma yapılıyor.


            }

            return kullaniciSonuc;

        }
        #region Yardimci Metotlar

        private void JsonDBGuncelle()
        {

            if (Kayitlarim!=null &&Kayitlarim.Count>0)
            {
                string jsonDB = Newtonsoft.Json.JsonConvert.SerializeObject(Kayitlarim);

                File.WriteAllText(@"c:\Uygulamalar\TelefonRehberiDB\Rehber.json",jsonDB);
            }

        }





        #endregion


    }
}
