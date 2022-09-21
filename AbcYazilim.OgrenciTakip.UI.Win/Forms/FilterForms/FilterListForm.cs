using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Navigators;
using AbcYazilim.OgrenciTakip.UI.Win.Show;
using DevExpress.XtraBars;
using DevExpress.XtraGrid;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.FilterForms
{
    public partial class FilterListForm : BaseListForm
    {
        private readonly KartTuru _filterKartTuru;
        private readonly GridControl _filterGrid;
        public FilterListForm(params object[] prm)
        {
            InitializeComponent();
            Bll = new FilterBll();

            _filterKartTuru = (KartTuru)prm[0];
            _filterGrid = (GridControl)prm[1];

            HideItems = new BarItem[] { btnFiltrele, btnKolonlar, btnYazdir, btnGonder, barFiltrele, barFiltreleAciklama, barKolonlar, barKolonlarAciklama, barGonder, barGonderAciklama, barYazdir, barYazdirAciklama };
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Il;
            Navigator = longNavigator.Navigator;
        }
        protected override void Listele()
        {
            tablo.GridControl.DataSource = ((FilterBll)Bll).List(x=>x.KartTuru == _filterKartTuru);
        }
        protected override void ShowEditForm(long id)
        {
            var result = new ShowEditForms<FilterEditForm>().ShowDialogEditForm(KartTuru.Filter, id,_filterKartTuru,_filterGrid);
            ShowEditFormDefault(result);
        }


    }
}