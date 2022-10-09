using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.IlForms;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;
using AbcYazilim.OgrenciTakip.UI.Win.Navigators;
using AbcYazilim.OgrenciTakip.UI.Win.Show;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.AileBilgiForms
{
    public partial class AileBilgiListForm : BaseListForm
    {
        public AileBilgiListForm()
        {
            InitializeComponent();
            Bll = new AileBilgiBll();
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.AileBilgi;
            FormShow = new ShowEditForms<AileBilgiEditForm>();
            Navigator = longNavigator.Navigator;
        }
        protected override void Listele()
        {
            tablo.GridControl.DataSource = ((AileBilgiBll)Bll).List(FilterFunctions.Filter<AileBilgi>(AktifKartlariGoster));
        }
    }
}