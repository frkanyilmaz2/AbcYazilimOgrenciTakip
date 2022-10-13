﻿using AbcYazilim.OgrenciTakip.Model.Attributes;
using AbcYazilim.OgrenciTakip.Model.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace AbcYazilim.OgrenciTakip.Model.Entities
{
    public class Avukat:BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }
        [Required, StringLength(50), ZorunluAlan("Avukat Adı", "txtAvukatAdi")]
        public string AvukatAdi { get; set; }
        [StringLength(20)]
        public string SozlesmeNo { get; set; }
        [Column(TypeName = "date")]
        public DateTime? SozlesmeBaslangicTarihi { get; set; }
        [Column(TypeName = "date")]
        public DateTime? SozlesmeBitisTarihi { get; set; }
        public long? OzelKod1Id { get; set; }
        public long? OzelKod2Id { get; set; }
        [StringLength(500)]
        public string Aciklama { get; set; }
        public OzelKod OzelKod1 { get; set; }
        public OzelKod OzelKod2 { get; set; }
    }
}
