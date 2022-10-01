using DevExpress.XtraPrinting;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.GeneralForms
{
    public partial class RaporOnizleme : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public RaporOnizleme(params object[] prm)
        {
            InitializeComponent();

            RaporGosterici.PrintingSystem = (PrintingSystem)prm[0];
            Text = $"{Text} ( {prm[1].ToString()} )";
        }
    }
}