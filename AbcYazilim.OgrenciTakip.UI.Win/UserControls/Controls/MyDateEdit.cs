﻿using DevExpress.XtraEditors;
using DevExpress.Utils;
using DevExpress.XtraEditors.Mask;
using AbcYazilim.OgrenciTakip.UI.Win.Interfaces;
using System.ComponentModel;

namespace AbcYazilim.OgrenciTakip.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyDateEdit : DateEdit, IStatusBarKisayol
    {
        public MyDateEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.AllowNullInput = DefaultBoolean.False;
            Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
            Properties.Mask.MaskType = MaskType.DateTimeAdvancingCaret;
        }
        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarKisayol { get; set; } = "F4 :";
        public string StatusBarKisayolAciklama { get; set; } = "Tarih seç.";
        public string StatusBarAciklama { get; set; }
    }
}
