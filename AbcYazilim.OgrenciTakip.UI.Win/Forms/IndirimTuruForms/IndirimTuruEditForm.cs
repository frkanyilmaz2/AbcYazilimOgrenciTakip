using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.IndirimTuruForms
{
    public partial class IndirimTuruEditForm : BaseEditForm
    {
        public IndirimTuruEditForm()
        {
            InitializeComponent();
            DataLayoutControl = myDataLayoutControl;
            Bll = new IndirimTuruBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.IndirimTuru;
            EventsLoad();
        }
        protected internal override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new IndirimTuru() : ((IndirimTuruBll)Bll).Single(FilterFunctions.Filter<IndirimTuru>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((IndirimTuruBll)Bll).YeniKodVer();
            txtIndirimTuruAdi.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (IndirimTuru)OldEntity;
            txtKod.Text = entity.Kod;
            txtIndirimTuruAdi.Text = entity.IndirimTuruAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }
        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new IndirimTuru
            {
                Id = Id,
                Kod = txtKod.Text,
                IndirimTuruAdi = txtIndirimTuruAdi.Text,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn
            };
            ButonEnabledDurumu();
        }
    }
}