using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.UI.Win.Show;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;
using AbcYazilim.OgrenciTakip.Model.Entities;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.KontenjanForms
{
    public partial class KontenjanListForm : BaseListForm 
    { 
        public KontenjanListForm()
        {
            InitializeComponent();
            Bll = new KontenjanBll();
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Kontenjan;
            FormShow = new ShowEditForms<KontenjanEditForm>();
            Navigator = longNavigator.Navigator;
        }
        protected override void Listele()
        {
            tablo.GridControl.DataSource = ((KontenjanBll)Bll).List(FilterFunctions.Filter<Kontenjan>(AktifKartlariGoster));
        }
    }
}