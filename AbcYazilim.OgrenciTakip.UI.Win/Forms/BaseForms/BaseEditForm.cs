using AbcYazilim.OgrenciTakip.Common.Enums;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms
{
    public partial class BaseEditForm : RibbonForm
    {
        protected internal IslemTuru IslemTuru;
        protected internal long Id;
        protected internal bool RefreshYapilacak;
        public BaseEditForm()
        {
            InitializeComponent();
        }


        protected internal void Yukle()
        {

        }

        private void ribbonStatusBar_Click(object sender, EventArgs e)
        {

        }
    }
}