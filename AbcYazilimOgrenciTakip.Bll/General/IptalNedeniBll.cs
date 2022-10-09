using AbcYazilim.OgrenciTakip.Bll.Base;
using AbcYazilim.OgrenciTakip.Bll.Interfaces;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities;
using System.Windows.Forms;

namespace AbcYazilim.OgrenciTakip.Bll.General
{
    public class IptalNedeniBll : BaseGenelBll<IptalNedeni>, IBaseGenelBll, IBaseCommonBll
    {
        public IptalNedeniBll() : base(KartTuru.IptalNedeni) { }
        public IptalNedeniBll(Control ctrl) : base(ctrl, KartTuru.IptalNedeni) { }
    }
}
