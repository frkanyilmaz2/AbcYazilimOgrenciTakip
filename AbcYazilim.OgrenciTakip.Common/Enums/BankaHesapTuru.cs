using System.ComponentModel;

namespace AbcYazilim.OgrenciTakip.Common.Enums
{
    public enum BankaHesapTuru:byte
    {
        [Description("Vadesiz Mevduat Hesabı")]
        VadesizMevduatHesabi = 1,
        [Description("Vadeli Mevduat Hesabı")]
        VadeliMevduatHesabi = 2,
        [Description("Kredi Hesabı")]
        KrediHesabi = 3,
        [Description("Epos Bloke Hesabı")]
        EposBlokeHesabi  = 4,
        [Description("Ots Bloke Hesabı")]
        OtsBlokeHesabi = 5,
        [Description("Pos Bloke Hesabı")]
        PosBlokeHesabi = 6,
        [Description("Bloke Çözüm Hesabı")]
        BlokeCozumHesabi = 7
    }
}