using AbcYazilim.OgrenciTakip.UI.Win.Interfaces;
using DevExpress.XtraEditors;
using System.ComponentModel;

namespace AbcYazilim.OgrenciTakip.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyMemoEdit:MemoEdit, IStatusBarAciklama
    {
        public MyMemoEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.MaxLength = 500;
        }
        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarAciklama { get; set; } = "Açıklama giriniz.";
    }
}
