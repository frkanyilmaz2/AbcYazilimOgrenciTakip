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

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.RehberForms
{
    public partial class RehberEditForm : BaseEditForm
    {
        public RehberEditForm()
        {
            InitializeComponent();
            DataLayoutControl = myDataLayoutControl;
            Bll = new RehberBll(myDataLayoutControl);
            BaseKartTuru = Common.Enums.KartTuru.Rehber;
            EventsLoad();
        }
        protected internal override void Yukle()
        {

            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new Rehber() : ((RehberBll)Bll).Single(FilterFunctions.Filter<Rehber>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((RehberBll)Bll).YeniKodVer();
            txtAdiSoyadi.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Rehber)OldEntity;
            txtKod.Text = entity.Kod;
            txtAdiSoyadi.Text = entity.AdiSoyadi;
            txtAciklama.Text = entity.Aciklama;
            txtTelefon1.Text = entity.Telefon1;
            txtTelefon2.Text = entity.Telefon2;
            tglDurum.IsOn = entity.Durum;
        }
        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Rehber
            {
                Id = Id,
                Kod = txtKod.Text,
                AdiSoyadi = txtAdiSoyadi.Text,
                Aciklama = txtAciklama.Text,
                Telefon1 = txtTelefon1.Text,
                Telefon2 = txtTelefon2.Text,
                Durum = tglDurum.IsOn
            };
            ButonEnabledDurumu();
        }
    }
}