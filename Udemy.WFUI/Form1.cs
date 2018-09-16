using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Udemy.BLL;

namespace Udemy.WFUI
{
    public partial class Form1 : Form
    {
        private Udemy.BLL.BusinessLogicLayer BLL;

        public Form1()
        {
            InitializeComponent();
            BLL=new BusinessLogicLayer();
            
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {

         int sonuc=BLL.KullaniciKontrol(txt_KullaniciAdi.Text, txtSifre.Text);

            if (sonuc>0)
            {
                AnaForm Form=new AnaForm();
                Form.Show();


            }else if (sonuc==-100)
            {
                MessageBox.Show("Form alanalarını Eksiksiz oalrak doldrunuz .");
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı");
            }


        }
    }
}
