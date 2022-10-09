﻿using AbcYazilim.OgrenciTakip.Bll.Base;
using AbcYazilim.OgrenciTakip.Bll.Interfaces;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbcYazilim.OgrenciTakip.Bll.General
{
    public class YakinlikBll : BaseGenelBll<Yakinlik>, IBaseGenelBll, IBaseCommonBll
    {
        public YakinlikBll() : base(KartTuru.Yakinlik) { }
        public YakinlikBll(Control ctrl) : base(ctrl, KartTuru.Yakinlik) { }
    }
}
