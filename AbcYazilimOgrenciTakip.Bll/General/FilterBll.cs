using AbcYazilim.OgrenciTakip.Bll.Base;
using AbcYazilim.OgrenciTakip.Bll.Interfaces;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities;
using System.Windows.Forms;

namespace AbcYazilim.OgrenciTakip.Bll.General
{
    public class FilterBll :BaseGenelBll<Filter>, IBaseCommonBll
    {
        public FilterBll():base(KartTuru.Filter) { }
        public FilterBll(Control ctrl) : base(ctrl,KartTuru.Filter) { }
    }
}