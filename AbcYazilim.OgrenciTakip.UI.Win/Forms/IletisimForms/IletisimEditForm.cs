using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Common.Functions;
using AbcYazilim.OgrenciTakip.Model.Dto;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;
using DevExpress.XtraEditors;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.IletisimForms
{
    public partial class IletisimEditForm : BaseEditForm
    {
        public IletisimEditForm()
        {
            InitializeComponent(); 
            DataLayoutControl = myDataLayoutControl;
            Bll = new IletisimBll(myDataLayoutControl);
            txtKanGrubu.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<KanGrubu>());
            BaseKartTuru = KartTuru.Iletisim;
            EventsLoad();
        }
        protected internal override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new IletisimS() : ((IletisimBll)Bll).Single(FilterFunctions.Filter<Iletisim>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((IletisimBll)Bll).YeniKodVer();
            txtTcKimlikNo.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (IletisimS)OldEntity;
            txtKod.Text = entity.Kod;
            txtTcKimlikNo.Text = entity.TcKimlikNo;
            txtAdi.Text = entity.Adi;
            txtSoyadi.Text = entity.Soyadi;
            txtEvTel.Text = entity.EvTel;
            txtIsTel1.Text = entity.IsTel1;
            txtDahili1.Text = entity.Dahili1;
            txtIsTel2.Text = entity.Dahili2;
            txtCepTel1.Text = entity.CepTel1;
            txtCepTel2.Text = entity.CepTel2;
            txtWeb.Text = entity.Web;
            txtEmail.Text = entity.Email;
            txtIban.Text = entity.Iban;
            txtKartNo.Text = entity.KartNo;
            txtEvAdresi.Text = entity.EvAdres;
            txtEvAdresIl.Id = entity.EvAdresIlId;
            txtEvAdresIl.Text = entity.EvAdresIlAdi;
            txtEvAdresIlce.Id = entity.EvAdresIlceId;
            txtEvAdresIlce.Text = entity.EvAdresIlceAdi;
            txtIsAdresi.Text = entity.IsAdres;
            txtIsAdresIl.Id = entity.IsAdresIlId;
            txtIsAdresIl.Text = entity.IsAdresIlAdi;
            txtIsAdresIlce.Id = entity.IsAdresIlceId;
            txtIsAdresIlce.Text = entity.IsAdresIlceAdi;
            txtMeslek.Id = entity.MeslekId;
            txtMeslek.Text = entity.MeslekAdi;
            txtIsYeri.Id = entity.IsYeriId;
            txtIsYeri.Text = entity.IsYeriAdi;
            txtGorev.Id = entity.GorevId;
            txtGorev.Text = entity.GorevAdi;
            txtBabaAdi.Text = entity.BabaAdi;
            txtAnaAdi.Text = entity.AnaAdi;
            txtDogumYeri.Text = entity.DogumYeri;
            txtDogumTarihi.EditValue = entity.DogumTarihi;
            txtKanGrubu.SelectedItem = entity.KanGrubu.ToName();
            txtKimlikSeri.Text = entity.KimlikSeri;
            txtKimlikSira.Text = entity.KimlikSiraNo;
            txtKimlikNufusIl.Id = entity.KimlikIlId;
            txtKimlikNufusIl.Text = entity.KimlikIlAdi;
            txtKimlikNufusIlce.Id = entity.KimlikIlceId;
            txtKimlikNufusIlce.Text = entity.KimlikIlceAdi;
            txtKimlikMahalleKoy.Text = entity.KimlikMahalleKoy;
            txtKimlikCiltNo.Text = entity.KimlikCiltNo;
            txtKimlikAileNo.Text = entity.KimlikAileSiraNo;
            txtKimlikBireyNo.Text = entity.KimlikBireySiraNo;
            txtKimlikVerildigiYer.Text = entity.KimlikVerildiğiYer;
            txtKimlikVerilisNedeni.Text = entity.KimlikVerilisNedeni;
            txtKimlikVerilisTarihi.EditValue = entity.KimlikVerilisTarihi;
            txtKimlikKayitNo.Text = entity.KimlikKayitNo;
            txtOzelKod1.Id = entity.OzelKod1Id;
            txtOzelKod1.Text = entity.OzelKod1Adi;
            txtOzelKod2.Id = entity.OzelKod2Id;
            txtOzelKod2.Text = entity.OzelKod2Adi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }
        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Iletisim
            {
                Id = Id,
                Kod = txtKod.Text,
                TcKimlikNo = txtTcKimlikNo.Text,
                Adi = txtAdi.Text,
                Soyadi = txtSoyadi.Text,
                EvTel = txtEvTel.Text,
                IsTel1 = txtIsTel1.Text,
                Dahili1 = txtDahili1.Text,
                IsTel2 = txtIsTel2.Text,
                Dahili2 = txtDahili2.Text,
                CepTel1 = txtCepTel1.Text,
                CepTel2 = txtCepTel2.Text,
                Web = txtWeb.Text,
                Email = txtEmail.Text,
                Iban = txtIban.Text,
                KartNo = txtKartNo.Text,
                EvAdres = txtEvAdresi.Text,
                EvAdresIlId = txtEvAdresIl.Id,
                EvAdresIlceId = txtEvAdresIlce.Id,
                IsAdres = txtIsAdresi.Text,
                IsAdresIlId = txtIsAdresIl.Id,
                IsAdresIlceId = txtIsAdresIlce.Id,
                MeslekId = txtMeslek.Id,
                IsYeriId = txtIsYeri.Id,
                GorevId = txtGorev.Id,
                BabaAdi = txtBabaAdi.Text,
                AnaAdi = txtAnaAdi.Text,
                DogumYeri = txtDogumYeri.Text,
                DogumTarihi = (DateTime?)txtDogumTarihi.EditValue,
                KanGrubu = txtKanGrubu.Text.GetEnum<KanGrubu>(),
                KimlikSeri = txtKimlikSeri.Text,
                KimlikSiraNo = txtKimlikSira.Text,
                KimlikIlId = txtKimlikNufusIl.Id,
                KimlikIlceId = txtKimlikNufusIlce.Id,
                KimlikMahalleKoy = txtKimlikMahalleKoy.Text,
                KimlikCiltNo = txtKimlikCiltNo.Text,
                KimlikAileSiraNo = txtKimlikAileNo.Text,
                KimlikBireySiraNo = txtKimlikBireyNo.Text,
                KimlikVerildiğiYer = txtKimlikVerildigiYer.Text,
                KimlikVerilisNedeni = txtKimlikVerilisNedeni.Text,
                KimlikKayitNo = txtKimlikKayitNo.Text,
                KimlikVerilisTarihi = (DateTime?)txtKimlikVerilisTarihi.EditValue,
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
                if (sender == txtEvAdresIl)
                    sec.Sec(txtEvAdresIl);
                else if (sender == txtEvAdresIlce)
                    sec.Sec(txtEvAdresIlce, txtEvAdresIl);
                else if (sender == txtIsAdresIl)
                    sec.Sec(txtIsAdresIl);
                else if (sender == txtIsAdresIlce)
                    sec.Sec(txtIsAdresIlce, txtIsAdresIl);
                else if (sender == txtMeslek)
                    sec.Sec(txtMeslek);
                else if (sender == txtIsYeri)
                    sec.Sec(txtIsYeri);
                else if (sender == txtGorev)
                    sec.Sec(txtGorev);
                else if (sender == txtKimlikNufusIl)
                    sec.Sec(txtKimlikNufusIl);
                else if (sender == txtKimlikNufusIlce)
                    sec.Sec(txtKimlikNufusIlce, txtKimlikNufusIl);
                else if (sender == txtOzelKod1)
                    sec.Sec(txtOzelKod1, KartTuru.Iletisim);
                else if (sender == txtOzelKod2)
                    sec.Sec(txtOzelKod2, KartTuru.Iletisim);
        }
        protected override void Control_EnabledChange(object? sender, EventArgs e)
        {
            if (sender != txtEvAdresIl && sender != txtIsAdresIl && sender != txtKimlikNufusIl) return;
            if (sender == txtEvAdresIl)
                txtEvAdresIl.ControlEnabledChange(txtEvAdresIlce);
            else if (sender == txtIsAdresIl)
                txtIsAdresIl.ControlEnabledChange(txtIsAdresIlce);
            else if (sender == txtKimlikNufusIl)
                txtKimlikNufusIl.ControlEnabledChange(txtKimlikNufusIlce);
               
        }
    }
}