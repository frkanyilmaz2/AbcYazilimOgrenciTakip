using AbcYazilim.OgrenciTakip.Bll.Base;
using AbcYazilim.OgrenciTakip.Bll.Interfaces;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilimOgrenciTakip.Bll.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbcYazilim.OgrenciTakip.Bll.General
{
    public class IsYeriBll : BaseGenelBll<IsYeri>, IBaseGenelBll, IBaseCommonBll
    {
        public IsYeriBll() : base(KartTuru.IsYeri) { }
        public IsYeriBll(Control ctrl) : base(ctrl, KartTuru.IsYeri) { }
    }
}
