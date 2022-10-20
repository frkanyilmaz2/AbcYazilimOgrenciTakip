using AbcYazilim.OgrenciTakip.Common.Messages;
using AbcYazilim.OgrenciTakip.UI.Win.UserControls.Controls;
using DevExpress.CodeParser;
using DevExpress.XtraBars;

namespace AbcYazilim.OgrenciTakip.UI.Win.Functions
{
    public static class SelectPictureFunctions //resimleri extension kullanabilmemiz için static ekledik
    {
        #region Variables
        private static MyPictureEdit _pictureEdit;
        private static PopupMenu _popupMenu; 
        #endregion
        private static void RemoveEvents() // += ile event ekledik -= ile çıkardık.
        {
            if (_pictureEdit == null) return;

            _pictureEdit.KeyDown -= PictureEdit_KeyDown;
            _pictureEdit.DoubleClick -= PictureEdit_DoubleClick;
            _pictureEdit.MouseUp -= PictureEdit_MouseUp;
            _popupMenu.Popup -= PopupMenu_Popup;

            foreach (BarItemLink link in _popupMenu.ItemLinks)
            {
                link.Item.ItemClick -= Buttons_ItemClick;
            }
        }
        public static void Sec(this MyPictureEdit pictureEdit,PopupMenu popupMenu)
        {
            RemoveEvents();

            _pictureEdit = pictureEdit;
            _popupMenu = popupMenu;
            _pictureEdit.KeyDown += PictureEdit_KeyDown;
            _pictureEdit.DoubleClick += PictureEdit_DoubleClick;
            _pictureEdit.MouseUp += PictureEdit_MouseUp;
            _popupMenu.Popup += PopupMenu_Popup;

            foreach (BarItemLink link in _popupMenu.ItemLinks)
            {
                link.Item.ItemClick += Buttons_ItemClick;
            }
        }
        private static void ResimSec()
        {
            var Resim = GeneralFunctions.ResimYukle();
            if (Resim == null) return;
            _pictureEdit.EditValue = Resim;
        }
        private static void ResimSil()
        {
            if (_pictureEdit.Image == null) return;
            if (Messages.SilMesaj("Resim") != DialogResult.Yes) return;
            _pictureEdit = null;
        }
        private static void PictureEdit_KeyDown(object? sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Delete:
                    ResimSil();
                    break;
                case Keys.Insert:
                case Keys.F4:
                case Keys.Down when e.Modifiers == Keys.Alt:
                    ResimSec();
                    break;
            }
        }
        private static void PictureEdit_DoubleClick(object? sender, EventArgs e)
        {
            ResimSec();
        }
        private static void PictureEdit_MouseUp(object? sender, MouseEventArgs e)
        {
            e.ShowPopupMenu(_popupMenu);
        }
        private static void PopupMenu_Popup(object? sender, EventArgs e)
        {
            _popupMenu.ItemLinks[1].Item.Enabled = _pictureEdit.Image != null;
        }
        private static void Buttons_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (e.Item == _popupMenu.ItemLinks[0].Item)
                ResimSec();
            else if (e.Item == _popupMenu.ItemLinks[1].Item)
                ResimSil();
        }
    }
}
