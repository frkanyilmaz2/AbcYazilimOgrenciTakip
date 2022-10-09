using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;
using AbcYazilim.OgrenciTakip.UI.Win.Show;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.IptalNedeniForms
{
    public partial class IptalNedeniListForm : BaseListForm
    {
        public IptalNedeniListForm()
        {
            InitializeComponent();
            Bll = new IptalNedeniBll();
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.IptalNedeni;
            FormShow = new ShowEditForms<IptalNedeniEditForm>();
            Navigator = longNavigator.Navigator;
        }
        protected override void Listele()
        {
            tablo.GridControl.DataSource = ((IptalNedeniBll)Bll).List(FilterFunctions.Filter<IptalNedeni>(AktifKartlariGoster));
        }
    }
}