﻿using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace AbcYazilim.OgrenciTakip.Common.Messages
{
    public class Messages
    {
        public static void HataMesaji (string hataMesaji)
        {
            XtraMessageBox.Show(hataMesaji, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static DialogResult EvetSeciliEvetHayir(string mesaj, string baslik)
        {
            return XtraMessageBox.Show(mesaj,baslik,MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1);
        }

        public static DialogResult HayirSeciliEvetHayir(string mesaj,string baslik)
        {
            return XtraMessageBox.Show(mesaj, baslik, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        }

        public static DialogResult SilMesaj (string kartAdi)
        {
            return HayirSeciliEvetHayir($"Seçilen {kartAdi} silinecektir. Onaylıyor musun keke?", "Silme Onayı");
        }
    }
}
