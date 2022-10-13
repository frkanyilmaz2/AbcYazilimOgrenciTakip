using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Dto;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;
using DevExpress.XtraEditors;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.AvukatForms
{
    public partial class AvukatEditForm : BaseEditForm
    {
        public AvukatEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new AvukatBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Avukat;
            EventsLoad();
        }
        protected internal override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new AvukatS() : ((AvukatBll)Bll).Single(FilterFunctions.Filter<Avukat>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((AvukatBll)Bll).YeniKodVer();
            txtAvukatAdi.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (AvukatS)OldEntity;

            txtKod.Text = entity.Kod;
            txtAvukatAdi.Text = entity.AvukatAdi;
            txtSozlesmeNo.Text = entity.SozlesmeNo;
            txtSozlesmeBaslangicTarihi.EditValue = entity.SozlesmeBaslangicTarihi;
            txtSozlesmeBitisTarihi.EditValue = entity.SozlesmeBitisTarihi;
            txtOzelKod1.Id = entity.OzelKod1Id;
            txtOzelKod1.Text = entity.OzelKod1Adi;
            txtOzelKod2.Id = entity.OzelKod2Id;
            txtOzelKod2.Text = entity.OzelKod2Adi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }
        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Avukat
            {
                Id = Id,
                Kod = txtKod.Text,
                AvukatAdi = txtAvukatAdi.Text,
                SozlesmeNo = txtSozlesmeNo.Text,
                SozlesmeBaslangicTarihi = (DateTime?)txtSozlesmeBaslangicTarihi.EditValue,
                SozlesmeBitisTarihi = (DateTime?)txtSozlesmeBitisTarihi.EditValue,
                OzelKod1Id = txtOzelKod1.Id,
                OzelKod2Id = txtOzelKod2.Id,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn
            };
            ButonEnabledDurumu();
        }
        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
                if (sender == txtOzelKod1)
                    sec.Sec(txtOzelKod1, KartTuru.Avukat);
                else if (sender == txtOzelKod2)
                    sec.Sec(txtOzelKod2, KartTuru.Avukat);
        }
    }
}