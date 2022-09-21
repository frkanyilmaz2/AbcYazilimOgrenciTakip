using AbcYazilim.OgrenciTakip.Bll.Interfaces;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.Model.Entities.Base;
using AbcYazilimOgrenciTakip.Bll.Base;
using AbcYazilimOgrenciTakip.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace AbcYazilim.OgrenciTakip.Bll.General
{
    public class FilterBll : BaseBll<Filter, OgrenciTakipContext>, IBaseCommonBll
    {
        public FilterBll() { }
        public FilterBll(Control ctrl) : base(ctrl) { }
        public BaseEntity Single(Expression<Func<Filter, bool>> filter)
        {
            return BaseSingle(filter, x => x);
        }

        public IEnumerable<BaseEntity> List(Expression<Func<Filter, bool>> filter)
        {
            return BaseList(filter, x => x).OrderBy(x => x.Kod).ToList();
        }

        public bool Insert(BaseEntity entity, Expression<Func<Filter, bool>> filter)
        {
            return BaseInsert(entity, filter);
        }

        public bool Update(BaseEntity oldEntity, BaseEntity currentEntity, Expression<Func<Filter, bool>> filter)
        {
            return BaseUpdate(oldEntity, currentEntity, filter);
        }

        public bool Delete(BaseEntity entity)
        {
            return BaseDelete(entity, KartTuru.Filter);
        }

        public string YeniKodVer(Expression<Func<Filter, bool>> filter)
        {
            return BaseYeniKodVer(KartTuru.Filter, x => x.Kod, filter);
        }

    }
}
