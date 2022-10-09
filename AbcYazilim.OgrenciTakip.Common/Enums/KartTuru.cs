using System.ComponentModel;

namespace AbcYazilim.OgrenciTakip.Common.Enums
{
    public enum KartTuru:byte
    {
        [Description("Okul Kartı")]
        Okul =1,
        [Description("İl Kartı")]
        Il,
        [Description("İlçe Kartı")]
        Ilce,
        [Description("Filtre Kartı")]
        Filter,
        [Description("Aile Bilgi Kartı")]
        AileBilgi=5,
        [Description("İptal Nedeni Kartı")]
        IptalNedeni =6,
        [Description("Yabancı Dil Kartı")]
        YabanciDil = 7,
        [Description("Teşvik Kartı")]
        Tesvik = 8,
        [Description("Kontenjan Kartı")]
        Kontenjan = 9,
        [Description("Rehber Kartı")]
        Rehber = 10,
        [Description("Sınıf Grup Kartı")]
        SinifGrup =11,
        [Description("Meslek Kartı")]
        Meslek = 12,
        [Description("Yakınlık Kartı")]
        Yakinlik = 13,
        [Description("İş Yeri Kartı")]
        IsYeri = 14,
        [Description("Görev Kartı")]
        Gorev = 15,
        [Description("İndirim Türü Kartı")]
        IndirimTuru = 16,
        [Description("Evrak Kartı")]
        Evrak = 17,
        [Description("Promosyon Kartı")]
        Promosyon = 18,
        [Description("Servis Yeri Kartı")]
        Servis = 19,
        [Description("Sınıf Kartı")]
        Sinif = 20
            
    }
}
