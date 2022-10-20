using AbcYazilim.OgrenciTakip.Bll.Base;
using AbcYazilim.OgrenciTakip.Bll.Interfaces;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Dto;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.Model.Entities.Base;
using System.Collections.Generic;
using System.Linq.Expressions;
using System;
using System.Windows.Forms;
using System.Linq;

namespace AbcYazilim.OgrenciTakip.Bll.General
{
    public class OgrenciBll : BaseGenelBll<Ogrenci>, IBaseGenelBll, IBaseCommonBll
    {
        public OgrenciBll() : base(KartTuru.Ogrenci) { }
        public OgrenciBll(Control ctrl) : base(ctrl, KartTuru.Ogrenci) { }
        public override BaseEntity Single(Expression<Func<Ogrenci, bool>> filter)
        {
            return BaseSingle(filter, x => new OgrenciS
            {
                Id = x.Id,
                Kod = x.Kod,
                TcKimlikNo = x.TcKimlikNo,
                Adi = x.Adi,
                Soyadi = x.Soyadi,
                Cinsiyet = x.Cinsiyet,
                Telefon = x.Telefon,
                BabaAdi = x.BabaAdi,
                AnaAdi = x.AnaAdi,
                DogumTarihi = x.DogumTarihi,
                DogumYeri = x.DogumYeri,
                KanGrubu = x.KanGrubu,
                KimlikAileSiraNo = x.KimlikAileSiraNo,
                KimlikSeri = x.KimlikSeri,
                KimlikBireySiraNo = x.KimlikBireySiraNo,
                KimlikCiltNo = x.KimlikCiltNo,
                KimlikIlId = x.KimlikIlId,
                KimlikIlAdi = x.KimlikIl.IlAdi,
                KimlikIlceId = x.KimlikIlceId,
                KimlikIlceAdi = x.KimlikIlce.IlceAdi,
                KimlikMahalleKoy = x.KimlikMahalleKoy,
                KimlikKayitNo = x.KimlikKayitNo,
                KimlikSiraNo = x.KimlikSiraNo,
                KimlikVerildiğiYer = x.KimlikVerildiğiYer,
                KimlikVerilisNedeni = x.KimlikVerilisNedeni,
                KimlikVerilisTarihi = x.KimlikVerilisTarihi,
                Resim = x.Resim,
                OzelKod1Id = x.OzelKod1Id,
                OzelKod1Adi = x.OzelKod1.OzelKodAdi,
                OzelKod2Id = x.OzelKod2Id,
                OzelKod2Adi = x.OzelKod2.OzelKodAdi,
                OzelKod3Id = x.OzelKod3Id,
                OzelKod3Adi = x.OzelKod3.OzelKodAdi,
                OzelKod4Id = x.OzelKod4Id,
                OzelKod4Adi = x.OzelKod4.OzelKodAdi,
                OzelKod5Id = x.OzelKod5Id,
                OzelKod5Adi = x.OzelKod5.OzelKodAdi,
                Durum = x.Durum,
            });
        }
        public override IEnumerable<BaseEntity> List(Expression<Func<Ogrenci, bool>> filter)
        {
            return BaseList(filter, x => new OgrenciL
            {
                Id = x.Id,
                Kod = x.Kod,
                TcKimlikNo = x.TcKimlikNo,
                Adi = x.Adi,
                Soyadi = x.Soyadi,
                Cinsiyet = x.Cinsiyet,
                Telefon = x.Telefon,
                BabaAdi = x.BabaAdi,
                AnaAdi = x.AnaAdi,
                DogumTarihi = x.DogumTarihi,
                DogumYeri = x.DogumYeri,
                KanGrubu = x.KanGrubu,
                KimlikAileSiraNo = x.KimlikAileSiraNo,
                KimlikSeri = x.KimlikSeri,
                KimlikBireySiraNo = x.KimlikBireySiraNo,
                KimlikCiltNo = x.KimlikCiltNo,
                KimlikIlAdi = x.KimlikIl.IlAdi,
                KimlikIlceAdi = x.KimlikIlce.IlceAdi,
                KimlikMahalleKoy = x.KimlikMahalleKoy,
                KimlikKayitNo = x.KimlikKayitNo,
                KimlikSiraNo = x.KimlikSiraNo,
                KimlikVerildiğiYer = x.KimlikVerildiğiYer,
                KimlikVerilisNedeni = x.KimlikVerilisNedeni,
                KimlikVerilisTarihi = x.KimlikVerilisTarihi,
                OzelKod1Adi = x.OzelKod1.OzelKodAdi,
                OzelKod2Adi = x.OzelKod2.OzelKodAdi,
                OzelKod3Adi = x.OzelKod3.OzelKodAdi,
                OzelKod4Adi = x.OzelKod4.OzelKodAdi,
                OzelKod5Adi = x.OzelKod5.OzelKodAdi,
            }).OrderBy(x => x.Kod).ToList();
        }
    }
}