using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;

namespace otomasyon.Fonksyonlar
{
    class mesajlar
    {
        public void YeniKayit(String Mesaj)
        {
            MessageBox.Show(Mesaj, "Yeni Kayit Girişi", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
        public DialogResult Guncelle()
        {
            return MessageBox.Show("Seçili Kalıcı olarak güncellenecektir \n güncelleme işlemini onaylıyormusunuz?", "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


        }
        public DialogResult Sil()
        {
           return  MessageBox.Show("Seçili olan kayıdı silmek istiyor musunuz?", "Kayıt Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


        }

        public void Guncelle(bool Guncelleme)

        {
            MessageBox.Show("Kaydınız Güncellenmiştir","Kayıt Güncelleme",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }
        public void Hata(Exception hata)
        {
            MessageBox.Show(hata.Message, "İşleminiz yapılmadı",MessageBoxButtons.OK, MessageBoxIcon.Error);




        }
    }
}
