using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;
using AbcYazilim.OgrenciTakip.UI.Win.Show;
using AbcYazilim.OgrenciTakip.Common.Enums;
using DevExpress.XtraBars;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.IlceForms;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.IlForms
{
    public partial class IlListForm :BaseListForm
    {
        public IlListForm()
        {
            InitializeComponent();
            Bll = new IlBll();
            btnBagliKartlar.Caption = "İlçe Kartları";
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Il;
            FormShow = new ShowEditForms<IlEditForm>();
            Navigator = longNavigator.Navigator;

            if (IsMdiChild)
                ShowItems = new BarItem[] { btnBagliKartlar } ;
        }
        protected override void Listele()
        {
            tablo.GridControl.DataSource = ((IlBll)Bll).List(FilterFunctions.Filter<Il>(AktifKartlariGoster));
        }

        protected override void BagliKartAc()
        {
            var entity = Tablo.GetRow<Il>();
            if (entity == null) return;
            ShowListForms<IlceListForm>.ShowListForm(KartTuru.Ilce,entity.Id,entity.IlAdi);
        }
    }
}