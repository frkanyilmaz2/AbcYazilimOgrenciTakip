using AbcYazilim.OgrenciTakip.Common.Messages;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace AbcYazilim.OgrenciTakip.UI.Win.UserControls.UserControl.Base
{
    public partial class BaseTablo : XtraUserControl
    {
        protected GridView Tablo;
        public BaseTablo()
        {
            InitializeComponent();
        }

        protected void EventsLoad()
        {
            //Button Events
            foreach (BarItem button in barManager.Items)
                button.ItemClick += Button_ItemClick;

            //Navigator Events
            instUpNavigator.Navigator.ButtonClick += Navigator_ButtonClick;

            //Table Events
        }
        protected virtual void HareketEkle() { }
        protected virtual void HareketSil() 
        {
            if (Tablo.DataRowCount == 0) return;
            if (Messages.SilMesaj("İşlem Satırı") != DialogResult.Yes) return;
        }
        private void Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (e.Item == btnHareketEkle)
                HareketEkle();
            else if (e.Item == btnHareketSil)
                HareketSil();

            Cursor.Current = DefaultCursor;
        }
        private void Navigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button == instUpNavigator.Navigator.Buttons.Append)
                HareketEkle();
            else if (e.Button == instUpNavigator.Navigator.Buttons.Remove)
                HareketSil();

            if (e.Button == instUpNavigator.Navigator.Buttons.Append || e.Button == instUpNavigator.Navigator.Buttons.Remove)
                e.Handled = true;
        }
    }
}
