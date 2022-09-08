using AbcYazilim.OgrenciTakip.Model.Entities.Base;

namespace AbcYazilim.OgrenciTakip.Model.Entities
{
    public class Ilce : BaseEntityDurum
    {
        public string IlceAdi { get; set; }
        public long Ilid { get; set; }
        public string Aciklama { get; set; }
        

        public Il Il { get; set; }
    }
}
