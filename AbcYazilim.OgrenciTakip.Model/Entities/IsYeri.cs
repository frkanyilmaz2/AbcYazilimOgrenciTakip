using AbcYazilim.OgrenciTakip.Model.Attributes;
using AbcYazilim.OgrenciTakip.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbcYazilim.OgrenciTakip.Model.Entities
{
    public class IsYeri: BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }
        [Required, StringLength(50), ZorunluAlan("İş Yeri Adı", "txtIsYeriAdi")]
        public string IsYeriAdi { get; set; }
        [StringLength(500)]
        public string Aciklama { get; set; }
    }
}
