﻿using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Common.Functions;
using AbcYazilim.OgrenciTakip.Model.Dto;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.GeneralForms;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;
using DevExpress.XtraEditors;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.BankaHesapForms
{
    public partial class BankaHesapEditForm : BaseEditForm
    {
        public BankaHesapEditForm()
        {
            InitializeComponent(); 
            DataLayoutControl = myDataLayoutControl;
            Bll = new BankaHesapBll(myDataLayoutControl);
            txtHesapTuru.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<BankaHesapTuru>());
            BaseKartTuru = KartTuru.BankaHesap;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new BankaHesapS() : ((BankaHesapBll)Bll).Single(FilterFunctions.Filter<BankaHesap>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((BankaHesapBll)Bll).YeniKodVer(x => x.SubeId == AnaForm.SubeId);
            txtHesapAdi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (BankaHesapS)OldEntity;

            txtKod.Text = entity.Kod;
            txtHesapAdi.Text = entity.HesapAdi;
            txtHesapTuru.SelectedItem = entity.HesapTuru.ToName();
            txtBanka.Id = entity.BankaId;
            txtBanka.Text = entity.BankaAdi;
            txtBankaSube.Id = entity.BankaSubeId;
            txtBankaSube.Text = entity.BankaSubeAdi;
            txtBlokeGunSayisi.Value = entity.BlokeGunSayisi;
            txtIsYeriNo.Text = entity.IsYeriNo;
            txtTerminalNo.Text = entity.TerminalNo;
            txtHesapAcilisTarihi.DateTime = entity.HesapAcilisTarihi;
            txtHesapNo.Text = entity.HesapNo;
            txtIban.Text = entity.Iban;
            txtOzelKod1.Id = entity.OzelKod1Id;
            txtOzelKod1.Text = entity.OzelKod1Adi;
            txtOzelKod2.Id = entity.OzelKod2Id;
            txtOzelKod2.Text = entity.OzelKod2Adi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }
        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new BankaHesap
            {
                Id = Id,
                Kod = txtKod.Text,
                HesapAdi = txtHesapAdi.Text,
                HesapTuru = txtHesapTuru.Text.GetEnum<BankaHesapTuru>(),
                BankaId = Convert.ToInt64(txtBanka.Id),
                BankaSubeId = Convert.ToInt64(txtBankaSube.Id),
                BlokeGunSayisi = (byte)txtBlokeGunSayisi.Value,
                IsYeriNo = txtIsYeriNo.Text,
                TerminalNo = txtTerminalNo.Text,
                HesapAcilisTarihi = txtHesapAcilisTarihi.DateTime.Date,
                HesapNo = txtHesapNo.Text,
                Iban = txtIban.Text,
                OzelKod1Id = txtOzelKod1.Id,
                OzelKod2Id = txtOzelKod2.Id,
                SubeId = AnaForm.SubeId,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn
            };
            ButonEnabledDurumu();
        }
        protected override bool EntityInsert()
        {
            return ((BankaHesapBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId);
        }
        protected override bool EntityUpdate()
        {
            return ((BankaHesapBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId);
        }
        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
                if (sender == txtBanka)
                    sec.Sec(txtBanka);
                else if (sender == txtBankaSube)
                    sec.Sec(txtBankaSube, txtBanka);
                else if (sender == txtOzelKod1)
                    sec.Sec(txtOzelKod1, KartTuru.BankaHesap);
                else if (sender == txtOzelKod2)
                    sec.Sec(txtOzelKod2, KartTuru.BankaHesap);
        }
        protected override void Control_EnabledChange(object? sender, EventArgs e)
        {
            if (sender != txtBanka) return;
            txtBanka.ControlEnabledChange(txtBankaSube);
        }
        protected override void Control_SelectedValueChanged(object? sender, EventArgs e)
        {
            if (!(sender is ComboBoxEdit edt)) return;

            var hesapTuru = edt.Text.GetEnum<BankaHesapTuru>();

            if (hesapTuru == BankaHesapTuru.EposBlokeHesabi || hesapTuru == BankaHesapTuru.OtsBlokeHesabi || hesapTuru == BankaHesapTuru.PosBlokeHesabi)
            {
                txtBlokeGunSayisi.Enabled = true;
                txtIsYeriNo.Enabled = true;
                txtTerminalNo.Enabled = true;
            }else
            {
                txtBlokeGunSayisi.Enabled = false;
                txtIsYeriNo.Enabled =false;
                txtTerminalNo.Enabled = false;
                txtBlokeGunSayisi.Value = 0;
                txtIsYeriNo.Text = null;
                txtTerminalNo.Text = null;
            }   
        }
    }
}