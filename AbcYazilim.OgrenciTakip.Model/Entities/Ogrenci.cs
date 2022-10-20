using AbcYazilim.OgrenciTakip.Model.Attributes;
using AbcYazilim.OgrenciTakip.Model.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using AbcYazilim.OgrenciTakip.Common.Enums;
using System;

namespace AbcYazilim.OgrenciTakip.Model.Entities
{
    public class Ogrenci : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }
        [StringLength(15)]
        public string TcKimlikNo { get; set; }
        [Required, StringLength(30), ZorunluAlan("Adı", "txtAdi")]
        public string Adi { get; set; }
        [Required, StringLength(30), ZorunluAlan("Soyadı", "txtSoyadi")]
        public string Soyadi { get; set; }
        public Cinsiyet Cinsiyet { get; set; } = Cinsiyet.Erkek;
        [StringLength(17)]
        public string Telefon { get; set; }
        public KanGrubu KanGrubu { get; set; } = KanGrubu.Bos;
        [StringLength(30)]
        public string BabaAdi { get; set; }
        [StringLength(30)]
        public string AnaAdi { get; set; }
        [StringLength(30)]
        public string DogumYeri { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DogumTarihi { get; set; }
      
        [StringLength(12)]
        public string KimlikSeri { get; set; }
        [StringLength(20)]
        public string KimlikSiraNo { get; set; }
        public long? KimlikIlId { get; set; }
        public long? KimlikIlceId { get; set; }
        [StringLength(30)]
        public string KimlikMahalleKoy { get; set; }
        [StringLength(30)]
        public string KimlikCiltNo { get; set; }
        [StringLength(30)]
        public string KimlikAileSiraNo { get; set; }
        [StringLength(30)]
        public string KimlikBireySiraNo { get; set; }
        [StringLength(30)]
        public string KimlikVerildiğiYer { get; set; }
        [StringLength(30)]
        public string KimlikVerilisNedeni { get; set; }
        [StringLength(30)]
        public string KimlikKayitNo { get; set; }
        [Column(TypeName = "date")]
        public DateTime? KimlikVerilisTarihi { get; set; }
        
        [Column(TypeName ="image")]
        public byte[] Resim { get; set; }
        public long? OzelKod1Id { get; set; }
        public long? OzelKod2Id { get; set; }
        public long? OzelKod3Id { get; set; }
        public long? OzelKod4Id { get; set; }
        public long? OzelKod5Id { get; set; }

        public Il KimlikIl { get; set; }
        public Ilce KimlikIlce { get; set; }
        public OzelKod OzelKod1 { get; set; }
        public OzelKod OzelKod2 { get; set; }
        public OzelKod OzelKod3 { get; set; }
        public OzelKod OzelKod4 { get; set; }
        public OzelKod OzelKod5 { get; set; }

    }
}