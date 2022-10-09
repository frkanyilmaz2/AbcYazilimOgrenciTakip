using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.IsYeriForms
{
    public partial class IsYeriEditForm : BaseEditForm
    {
        public IsYeriEditForm()
        {
            InitializeComponent();
            DataLayoutControl = myDataLayoutControl;
            Bll = new IsYeriBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.IsYeri;
            EventsLoad();
        }
        protected internal override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new IsYeri() : ((IsYeriBll)Bll).Single(FilterFunctions.Filter<IsYeri>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((IsYeriBll)Bll).YeniKodVer();
            txtIsYeriAdi.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (IsYeri)OldEntity;
            txtKod.Text = entity.Kod;
            txtIsYeriAdi.Text = entity.IsYeriAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }
        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new IsYeri
            {
                Id = Id,
                Kod = txtKod.Text,
                IsYeriAdi = txtIsYeriAdi.Text,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn
            };
            ButonEnabledDurumu();
        }
    }
}