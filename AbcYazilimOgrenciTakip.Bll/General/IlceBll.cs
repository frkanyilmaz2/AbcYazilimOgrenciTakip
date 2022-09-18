using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.Model.Entities.Base;
using AbcYazilimOgrenciTakip.Bll.Base;
using AbcYazilimOgrenciTakip.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using AbcYazilim.OgrenciTakip.Common.Enums;
using System.Windows.Forms;
using System.Linq.Expressions;
using AbcYazilim.OgrenciTakip.Bll.Interfaces;

namespace AbcYazilim.OgrenciTakip.Bll.General
{
    public class IlceBll : BaseBll<Ilce, OgrenciTakipContext>, IBaseCommonBll
    {
        public IlceBll() { }
        public IlceBll(Control ctrl) : base(ctrl) { }

        public BaseEntity Single(Expression<Func<Ilce, bool>> filter)
        {
            return BaseSingle(filter, x => x);
        }

        public IEnumerable<BaseEntity> List(Expression<Func<Ilce, bool>> filter)
        {
            return BaseList(filter, x => x).OrderBy(x => x.Kod).ToList();
        }

        public bool Insert(BaseEntity entity, Expression<Func<Ilce, bool>> filter)
        {
            return BaseInsert(entity, filter);
        }

        public bool Update(BaseEntity oldEntity, BaseEntity currentEntity, Expression<Func<Ilce, bool>> filter)
        {
            return BaseUpdate(oldEntity, currentEntity, filter);
        }

        public bool Delete(BaseEntity entity)
        {
            return BaseDelete(entity, KartTuru.Ilce);
        }

        public string YeniKodVer(Expression<Func<Ilce, bool>> filter)
        {
            return BaseYeniKodVer(KartTuru.Ilce, x => x.Kod, filter);
        }

    }
}
