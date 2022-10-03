using AbcYazilim.OgrenciTakip.Bll.Interfaces;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.Common.Enums;
using System.Windows.Forms;
using AbcYazilim.OgrenciTakip.Bll.Base;

namespace AbcYazilim.OgrenciTakip.Bll.General
{
    public class IlBll :BaseGenelBll<Il>, IBaseGenelBll, IBaseCommonBll
    {
        public IlBll():base(KartTuru.Il) { }

        public IlBll(Control ctrl) : base(ctrl,KartTuru.Il) { }

    }
}
