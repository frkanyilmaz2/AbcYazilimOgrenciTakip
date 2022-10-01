using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using DevExpress.XtraGrid;
using DevExpress.XtraBars;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.FilterForms
{
    public partial class FilterEditForm : BaseEditForm
    {
        private readonly KartTuru _filterKartTuru;
        private readonly GridControl _filterGrid;

        public FilterEditForm(params object[] prm)
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new FilterBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Filter;
            EventsLoad();

            HideItems = new BarItem[] { btnYeni, btnGeriAl };
            ShowItems = new BarItem[] { btnFarkliKaydet, btnUygula };


            _filterKartTuru = (KartTuru)prm[0];
            _filterGrid = (GridControl)prm[1];
        }

        protected internal override void Yukle()
        {
            txtFilterMetni.SourceControl = _filterGrid;
            while (true)
            {
                if (BaseIslemTuru == IslemTuru.EntityInsert)
                {
                    OldEntity = new Filter();
                    Id = BaseIslemTuru.IdOlustur(OldEntity);
                    btnKod.Text = ((FilterBll)Bll).YeniKodVer(x => x.KartTuru == _filterKartTuru);
                }
                else
                {
                    OldEntity = ((FilterBll)Bll).Single(FilterFunctions.Filter<Filter>(Id));
                    if (OldEntity == null)
                    {
                        BaseIslemTuru = IslemTuru.EntityInsert;
                        continue;
                    }
                    NesneyiKontrollereBagla();
                }
                break;
            }
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Filter)OldEntity;

            btnKod.Text = entity.Kod;
            txtFilterAdi.Text = entity.FilterAdi;
            txtFilterMetni.FilterString = entity.FilterMetni;
        }
        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Filter
            {
                Id = Id,
                Kod = btnKod.Text,
                FilterAdi = txtFilterAdi.Text,
                FilterMetni = txtFilterMetni.FilterString,
                KartTuru = _filterKartTuru
        }; 

        ButonEnabledDurumu();
    
        }
        protected override bool EntityInsert()
        {
            return ((FilterBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.KartTuru == _filterKartTuru);
        }
        protected override bool EntityUpdate()
        {
            return ((FilterBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.KartTuru == _filterKartTuru);
        }
        protected override void FilterUygula()
        {
            txtFilterMetni.Select();
            txtFilterMetni.ApplyFilter();
        }
        protected internal override void ButonEnabledDurumu()
        {
            if (!IsLoaded) return;
            GeneralFunctions.ButtonEnabledDurumu(btnKaydet, btnFarkliKaydet, btnSil, BaseIslemTuru, OldEntity, CurrentEntity);
        }
    }
}