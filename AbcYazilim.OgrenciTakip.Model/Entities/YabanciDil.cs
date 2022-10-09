using AbcYazilim.OgrenciTakip.Model.Attributes;
using AbcYazilim.OgrenciTakip.Model.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AbcYazilim.OgrenciTakip.Model.Entities
{
    public class YabanciDil:BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }
        [Required, StringLength(50), ZorunluAlan("Dil Adı", "txtDilAdi")]
        public string DilAdi { get; set; }
        [StringLength(500)]
        public string Aciklama { get; set; }
    }
}
