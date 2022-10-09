using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.TesvikForms
{
    public partial class TesvikEditForm : BaseEditForm
    {
        public TesvikEditForm()
        {
            InitializeComponent();
            DataLayoutControl = myDataLayoutControl;
            Bll = new TesvikBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Tesvik;
            EventsLoad();
        }
        protected internal override void Yukle()
        {

            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new Tesvik() : ((TesvikBll)Bll).Single(FilterFunctions.Filter<Tesvik>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((TesvikBll)Bll).YeniKodVer();
            txtTesvikAdi.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Tesvik)OldEntity;
            txtKod.Text = entity.Kod;
            txtTesvikAdi.Text = entity.TesvikAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }
        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Tesvik
            {
                Id = Id,
                Kod = txtKod.Text,
                TesvikAdi = txtTesvikAdi.Text,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn
            };
            ButonEnabledDurumu();
        }
    }
}