using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Udemy.Entities;

namespace Udemy.WFUI
{
    public partial class AnaForm : Form
    {
        private Udemy.BLL.BusinessLogicLayer BLL;
        public AnaForm()
        {

            InitializeComponent();
            BLL=new Udemy.BLL.BusinessLogicLayer();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void txt_aciklama_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

          int sonuc=  BLL.Yenikayit(Guid.NewGuid(), txt_isim.Text, txt_soyisim.Text, txt_telefon1.Text, txt_telefon2.Text,
                txt_telefon3.Text, txt_adres.Text, txt_Emailadres.Text, txt_website.Text, txt_aciklama.Text);

            if (sonuc>0)
            {
                MessageBox.Show("Kaydınız Eklendi.");
                Doldur();
            }
            else if (sonuc==-100)
            {
                MessageBox.Show("Eksik parametre hatası");
            }
            else
            {
                MessageBox.Show("KAyit esnasında bir hata oluştu.");
            }

        }

        private void Doldur()
        {


            List<RehberKayit> RehberKayilarim = BLL.RehberKayitlariGetir();
            if (RehberKayilarim!=null && RehberKayilarim.Count>0)
            {
                lst_liste.DataSource = RehberKayilarim;

            }
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        private void lst_liste_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lst_liste_DoubleClick(object sender, EventArgs e)
        {
            ListBox L = (ListBox) sender;
            RehberKayit SecilenDeger = (RehberKayit) L.SelectedItem;

            txt_isim.Text = SecilenDeger.Isim;
            txt_soyisim.Text = SecilenDeger.Soyisim;
            txt_telefon1.Text = SecilenDeger.Telefon1;
            txt_telefon2.Text = SecilenDeger.Telefon2;
            txt_telefon3.Text = SecilenDeger.Telefon3;
            txt_Emailadres.Text = SecilenDeger.EmailAdres;
            txt_adres.Text = SecilenDeger.Adres;
            txt_website.Text = SecilenDeger.WebAdres;
            txt_aciklama.Text = SecilenDeger.Aciklama;

            grtBoxKayit.Text = "Rehber Kayit Güncelle";

        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {



            if (lst_liste.SelectedItem != null)
            {

                //((RehberKayit) lst_liste.SelectedItem).ID; Kısa kullanımı
                RehberKayit K= (RehberKayit) lst_liste.SelectedItem;
               int sonuc=BLL.KayitGuncelle(K.ID,txt_isim.Text,txt_soyisim.Text,txt_telefon1.Text,txt_telefon2.Text,txt_telefon3.Text,txt_adres.Text,txt_Emailadres.Text,txt_website.Text,txt_aciklama.Text);

                if (sonuc>0)
                {
                    MessageBox.Show("Kaydınız başarılı bir şekilde güncellendi.");
                    Doldur();
                    
                }else if (sonuc==-100)
                {
                    MessageBox.Show("Eksik Paremtre hatası");
                }
                else
                {
                    MessageBox.Show("kayıt ekleme işlemi esnasında hata oluştu");
                }






            }
        }

        private void btn_KayitSil_Click(object sender, EventArgs e)
        {

            Guid SilinecekId = ((RehberKayit) lst_liste.SelectedItem).ID;

            int sonuc = BLL.KayitSil(SilinecekId);
            if (sonuc>0)
            {
                MessageBox.Show("Kaydınız başarı ile silindi");
                Doldur();
                

            }
            else
            {
                MessageBox.Show("kaydınız silinirken bie hata oluştu");
            }

        }

        private void btn_xmlVer_Click(object sender, EventArgs e)
        {
          int sonuc=BLL.XmlVer();


            if (sonuc>0)
            {
                MessageBox.Show("Xml dataları başarılı bir çıkartıldı.");
                lbl_dataDurum.Text = "Xml data verme işlemi Tamamlandı";
            }
            else
            {
                MessageBox.Show("Hata oluştu.");
            }
        }

        private void lbl_dataDurum_Click(object sender, EventArgs e)
        {

        }

        private void btn_jsonver_Click(object sender, EventArgs e)
        {
          int sonuc=BLL.JsonVer();

            if (sonuc>0)
            {
                MessageBox.Show("Json data verme işlemi tamamlandı.");
                lbl_dataDurum.Text = "Json data verme işlemi tamamlandı.";
            }
            else
            {
                MessageBox.Show("İşlem sırasında bir hata oluştu.");
            }
        }
    }
}
