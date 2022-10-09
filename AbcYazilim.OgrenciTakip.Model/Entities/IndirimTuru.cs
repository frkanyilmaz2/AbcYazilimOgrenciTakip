using AbcYazilim.OgrenciTakip.Model.Attributes;
using AbcYazilim.OgrenciTakip.Model.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AbcYazilim.OgrenciTakip.Model.Entities
{
    public class IndirimTuru:BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }
        [Required, StringLength(50), ZorunluAlan("İndirim Adı", "txtIndirimTuruAdi")]
        public string IndirimTuruAdi { get; set; }
        [StringLength(500)]
        public string Aciklama { get; set; }
    }
}
