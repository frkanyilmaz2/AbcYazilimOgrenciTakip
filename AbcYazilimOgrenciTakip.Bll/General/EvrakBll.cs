using AbcYazilim.OgrenciTakip.Bll.Base;
using AbcYazilim.OgrenciTakip.Bll.Interfaces;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities;
using System.Windows.Forms;

namespace AbcYazilim.OgrenciTakip.Bll.General
{
    public class EvrakBll : BaseGenelBll<Evrak>, IBaseCommonBll
    {
        public EvrakBll() : base(KartTuru.Evrak) { }
        public EvrakBll(Control ctrl) : base(ctrl, KartTuru.Evrak) { }
    }
}
