using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.Common.Enums;
using System.Windows.Forms;
using AbcYazilim.OgrenciTakip.Bll.Interfaces;
using AbcYazilim.OgrenciTakip.Bll.Base;

namespace AbcYazilim.OgrenciTakip.Bll.General
{
    public class IlceBll : BaseGenelBll<Ilce>, IBaseCommonBll
    {
        public IlceBll():base(KartTuru.Ilce) { }
        public IlceBll(Control ctrl) : base(ctrl,KartTuru.Ilce) { }
        
    }
}