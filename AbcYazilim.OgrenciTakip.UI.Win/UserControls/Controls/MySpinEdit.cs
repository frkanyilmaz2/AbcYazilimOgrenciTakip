﻿using DevExpress.XtraEditors;
using DevExpress.Utils;
using AbcYazilim.OgrenciTakip.UI.Win.Interfaces;
using System.ComponentModel;

namespace AbcYazilim.OgrenciTakip.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MySpinEdit : SpinEdit, IStatusBarAciklama
    {
        public MySpinEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.AllowNullInput = DefaultBoolean.False;
            Properties.EditMask = "d";
        }
        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarAciklama { get; set; }
    }
}
