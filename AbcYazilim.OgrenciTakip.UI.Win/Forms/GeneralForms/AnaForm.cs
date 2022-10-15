﻿using AbcYazilim.OgrenciTakip.UI.Win.Forms.OkulForms;
using AbcYazilim.OgrenciTakip.UI.Win.Show;
using AbcYazilim.OgrenciTakip.Common.Enums;
using DevExpress.XtraBars;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.IlForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.AileBilgiForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.IptalNedeniForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.YabanciDilForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.TesvikForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.KontenjanForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.RehberForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.SinifGrupForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.MeslekForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.YakinlikForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.IsYeriForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.GorevForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.IndirimTuruForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.EvrakForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.Promosyon_Forms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.ServisForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.SinifForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.HizmetTuruForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.HizmetForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.KasaForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BankaForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.AvukatForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.CariForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.OdemeTuruForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BankaHesapForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.IletisimForms;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.GeneralForms
{
    public partial class AnaForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public static long DonemId =1;
        public static string DonemAdi = "Dönem bilgisi bekleniyor...";
        public static long SubeId = 1;
        public static string SubeAdi = "Şube bilgisi bekleniyor...";
        public static DateTime EgitimBaslamaTarihi = new DateTime(2022, 09, 15);
        public static DateTime DönemBitisTarihi = new DateTime(2023, 06, 15);
        public static bool GunTarihininOncesineHizmetBaslamaTarihiGirilebilir = true;
        public static bool GunTarihininSonrasinaHizmetBaslamaTarihiGirilebilir = true;

        public AnaForm()
        {
            InitializeComponent();
            EventsLoad();
        }
        private void EventsLoad()
        {
            foreach (var item in ribbonControl.Items)
            {
                switch (item)
                {
                    case BarButtonItem btn:
                        btn.ItemClick += Butonlar_ItemClick;
                        break;
                    default:
                        break;
                }
            }
        }
        private void Butonlar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (e.Item == btnOkulKartlari)
                ShowListForms<OkulListForm>.ShowListForm(KartTuru.Okul);
            else if (e.Item == btnIlKartlari)
                ShowListForms<IlListForm>.ShowListForm(KartTuru.Il);
            else if (e.Item == btnAileBilgiKartlari)
                ShowListForms<AileBilgiListForm>.ShowListForm(KartTuru.AileBilgi);
            else if (e.Item == btnIptalNedeniKartlari)
                ShowListForms<IptalNedeniListForm>.ShowListForm(KartTuru.IptalNedeni);
            else if (e.Item == btnYabanciDilKartlari)
                ShowListForms<YabanciDilListForm>.ShowListForm(KartTuru.YabanciDil);
            else if (e.Item == btnTesvikKartlari)
                ShowListForms<TesvikListForm>.ShowListForm(KartTuru.Tesvik);
            else if (e.Item == btnKontenjanKartlari)
                ShowListForms<KontenjanListForm>.ShowListForm(KartTuru.Kontenjan);
            else if (e.Item == btnRehberKartlari)
                ShowListForms<RehberListForm>.ShowListForm(KartTuru.Rehber);
            else if (e.Item == btnSinifGrupKartlari)
                ShowListForms<SinifGrupListForm>.ShowListForm(KartTuru.SinifGrup);
            else if (e.Item == btnMeslekKartlari)
                ShowListForms<MeslekListForm>.ShowListForm(KartTuru.Meslek);
            else if (e.Item == btnYakinlikKartlari)
                ShowListForms<YakinlikListForm>.ShowListForm(KartTuru.Yakinlik);
            else if (e.Item == btnIsYeriKartlari)
                ShowListForms<IsYeriListForm>.ShowListForm(KartTuru.IsYeri);
            else if (e.Item == btnGorevKartlari)
                ShowListForms<GorevListForm>.ShowListForm(KartTuru.Gorev);
            else if (e.Item == btnIndirimTuruKartlari)
                ShowListForms<IndirimTuruListForm>.ShowListForm(KartTuru.IndirimTuru);
            else if (e.Item == btnEvrakKartlari)
                ShowListForms<EvrakListForm>.ShowListForm(KartTuru.Evrak);
            else if (e.Item == btnPromosyonKartlari)
                ShowListForms<PromosyonListForm>.ShowListForm(KartTuru.Promosyon);
            else if (e.Item == btnServisYeriKartlari)
                ShowListForms<ServisListForm>.ShowListForm(KartTuru.Servis);
            else if (e.Item == btnSinifKartlari)
                ShowListForms<SinifListForm>.ShowListForm(KartTuru.Sinif);
            else if (e.Item == btnHizmetTuruKartlari)
                ShowListForms<HizmetTuruListForm>.ShowListForm(KartTuru.HizmetTuru);
            else if (e.Item == btnHizmetKartlari)
                ShowListForms<HizmetListForm>.ShowListForm(KartTuru.Hizmet);
            else if (e.Item == btnKasaKartlari)
                ShowListForms<KasaListForm>.ShowListForm(KartTuru.Kasa);
            else if (e.Item == btnBankaKartlari)
                ShowListForms<BankaListForm>.ShowListForm(KartTuru.Banka);
            else if (e.Item == btnAvukatKartlari)
                ShowListForms<AvukatListForm>.ShowListForm(KartTuru.Avukat);
            else if (e.Item == btnCariKartlar)
                ShowListForms<CariListForm>.ShowListForm(KartTuru.Cari);
            else if (e.Item == btnOdemeTuruKartlari)
                ShowListForms<OdemeTuruListForm>.ShowListForm(KartTuru.OdemeTuru);
            else if (e.Item == btnBankaHesapKartlari)
                ShowListForms<BankaHesapListForm>.ShowListForm(KartTuru.BankaHesap);
            else if (e.Item == btnIletisimKartlari)
                ShowListForms<IletisimListForm>.ShowListForm(KartTuru.Iletisim);
        }
    }
}