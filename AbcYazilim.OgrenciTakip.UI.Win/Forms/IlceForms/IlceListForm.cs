﻿using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Navigators;
using AbcYazilim.OgrenciTakip.UI.Win.Show;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.IlceForms
{
    public partial class IlceListForm : BaseListForm
    {
        #region variables
        private readonly long _ilId;
        private readonly string _ilAdi; 
        #endregion
        public IlceListForm(params object[] prm)
        {
            InitializeComponent();
            Bll = new IlceBll();

            _ilId = (long)prm[0];
            _ilAdi = prm[1].ToString();
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Il;
            Navigator = longNavigator.Navigator;
        }
        protected override void Listele()
        {
            tablo.GridControl.DataSource = ((IlceBll)Bll).List(x=>x.Durum == AktifKartlariGoster && x.IlId == _ilId);
        }
        protected override void ShowEditForm(long id)
        {
            var result = new ShowEditForms<IlceEditForm>().ShowDialogEditForm(KartTuru.Ilce,id,_ilId,_ilAdi);
            // işlem yapılacak.

        }
    }
}