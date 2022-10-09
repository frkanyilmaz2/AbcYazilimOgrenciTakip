using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;
using AbcYazilim.OgrenciTakip.UI.Win.Show;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.IndirimTuruForms
{
    public partial class IndirimTuruListForm : BaseListForm
    {
        public IndirimTuruListForm()
        {
            InitializeComponent();  
            Bll = new IndirimTuruBll();
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.IndirimTuru;
            FormShow = new ShowEditForms<IndirimTuruEditForm>();
            Navigator = longNavigator.Navigator;
        }
        protected override void Listele()
        {
            tablo.GridControl.DataSource = ((IndirimTuruBll)Bll).List(FilterFunctions.Filter<IndirimTuru>(AktifKartlariGoster));
        }
    }
}