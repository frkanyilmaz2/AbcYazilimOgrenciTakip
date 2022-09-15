namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.OkulForms
{
    partial class OkulEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition2 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition3 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition3 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition4 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition5 = new DevExpress.XtraLayout.RowDefinition();
            this.myDataLayoutControl = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Controls.MyDataLayoutControl();
            this.tglDurum = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Controls.MyToggleSwitch();
            this.txtAciklama = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Controls.MyMemoEdit();
            this.btnIlce = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Controls.MyButtonEdit();
            this.btnIl = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Controls.MyButtonEdit();
            this.txtOkulAdi = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Controls.MyTextEdit();
            this.txtKod = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Controls.MyKodTextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.myKodTextEdit = new DevExpress.XtraLayout.LayoutControlItem();
            this.myTextEdit = new DevExpress.XtraLayout.LayoutControlItem();
            this.myButtonEditIl = new DevExpress.XtraLayout.LayoutControlItem();
            this.myButtonEditIlce = new DevExpress.XtraLayout.LayoutControlItem();
            this.myAciklamaMemoEdit = new DevExpress.XtraLayout.LayoutControlItem();
            this.durumAktifPasif = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).BeginInit();
            this.myDataLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tglDurum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnIlce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnIl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOkulAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myKodTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myButtonEditIl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myButtonEditIlce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myAciklamaMemoEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.durumAktifPasif)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            // 
            // 
            // 
            this.ribbonControl.SearchEditItem.AccessibleName = "Search Item";
            this.ribbonControl.SearchEditItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.ribbonControl.SearchEditItem.EditWidth = 150;
            this.ribbonControl.SearchEditItem.Id = -5000;
            this.ribbonControl.SearchEditItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControl.Size = new System.Drawing.Size(398, 109);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // myDataLayoutControl
            // 
            this.myDataLayoutControl.Controls.Add(this.tglDurum);
            this.myDataLayoutControl.Controls.Add(this.txtAciklama);
            this.myDataLayoutControl.Controls.Add(this.btnIlce);
            this.myDataLayoutControl.Controls.Add(this.btnIl);
            this.myDataLayoutControl.Controls.Add(this.txtOkulAdi);
            this.myDataLayoutControl.Controls.Add(this.txtKod);
            this.myDataLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDataLayoutControl.Location = new System.Drawing.Point(0, 109);
            this.myDataLayoutControl.Name = "myDataLayoutControl";
            this.myDataLayoutControl.OptionsFocus.EnableAutoTabOrder = false;
            this.myDataLayoutControl.Root = this.Root;
            this.myDataLayoutControl.Size = new System.Drawing.Size(398, 166);
            this.myDataLayoutControl.TabIndex = 0;
            this.myDataLayoutControl.Text = "myDataLayoutControl1";
            // 
            // tglDurum
            // 
            this.tglDurum.EnterMoveNextControl = true;
            this.tglDurum.Location = new System.Drawing.Point(291, 12);
            this.tglDurum.MenuManager = this.ribbonControl;
            this.tglDurum.Name = "tglDurum";
            this.tglDurum.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.tglDurum.Properties.Appearance.Options.UseForeColor = true;
            this.tglDurum.Properties.AutoHeight = false;
            this.tglDurum.Properties.AutoWidth = true;
            this.tglDurum.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.tglDurum.Properties.OffText = "Pasif";
            this.tglDurum.Properties.OnText = "Aktif";
            this.tglDurum.Size = new System.Drawing.Size(77, 20);
            this.tglDurum.StatusBarAciklama = "Kartın kullanım durumunu seçiniz.";
            this.tglDurum.StyleController = this.myDataLayoutControl;
            this.tglDurum.TabIndex = 4;
            // 
            // txtAciklama
            // 
            this.txtAciklama.EnterMoveNextControl = true;
            this.txtAciklama.Location = new System.Drawing.Point(63, 108);
            this.txtAciklama.MenuManager = this.ribbonControl;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtAciklama.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtAciklama.Properties.MaxLength = 500;
            this.txtAciklama.Size = new System.Drawing.Size(323, 46);
            this.txtAciklama.StatusBarAciklama = "Açıklama giriniz.";
            this.txtAciklama.StyleController = this.myDataLayoutControl;
            this.txtAciklama.TabIndex = 3;
            // 
            // btnIlce
            // 
            this.btnIlce.EnterMoveNextControl = true;
            this.btnIlce.Id = null;
            this.btnIlce.Location = new System.Drawing.Point(63, 84);
            this.btnIlce.MenuManager = this.ribbonControl;
            this.btnIlce.Name = "btnIlce";
            this.btnIlce.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.btnIlce.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.btnIlce.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnIlce.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.btnIlce.Size = new System.Drawing.Size(145, 20);
            this.btnIlce.StatusBarAciklama = "İlçe seçiniz.";
            this.btnIlce.StatusBarKisayol = "F4 :";
            this.btnIlce.StatusBarKisayolAciklama = "İlçe Seç";
            this.btnIlce.StyleController = this.myDataLayoutControl;
            this.btnIlce.TabIndex = 2;
            // 
            // btnIl
            // 
            this.btnIl.EnterMoveNextControl = true;
            this.btnIl.Id = null;
            this.btnIl.Location = new System.Drawing.Point(63, 60);
            this.btnIl.MenuManager = this.ribbonControl;
            this.btnIl.Name = "btnIl";
            this.btnIl.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.btnIl.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.btnIl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnIl.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.btnIl.Size = new System.Drawing.Size(145, 20);
            this.btnIl.StatusBarAciklama = "İl seçiniz.";
            this.btnIl.StatusBarKisayol = "F4 :";
            this.btnIl.StatusBarKisayolAciklama = "İl Seç";
            this.btnIl.StyleController = this.myDataLayoutControl;
            this.btnIl.TabIndex = 1;
            // 
            // txtOkulAdi
            // 
            this.txtOkulAdi.Location = new System.Drawing.Point(63, 36);
            this.txtOkulAdi.MenuManager = this.ribbonControl;
            this.txtOkulAdi.Name = "txtOkulAdi";
            this.txtOkulAdi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtOkulAdi.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtOkulAdi.Properties.MaxLength = 50;
            this.txtOkulAdi.Size = new System.Drawing.Size(323, 20);
            this.txtOkulAdi.StatusBarAciklama = "Okul adı giriniz.";
            this.txtOkulAdi.StyleController = this.myDataLayoutControl;
            this.txtOkulAdi.TabIndex = 0;
            // 
            // txtKod
            // 
            this.txtKod.Location = new System.Drawing.Point(63, 12);
            this.txtKod.MenuManager = this.ribbonControl;
            this.txtKod.Name = "txtKod";
            this.txtKod.Properties.Appearance.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txtKod.Properties.Appearance.Options.UseBackColor = true;
            this.txtKod.Properties.Appearance.Options.UseTextOptions = true;
            this.txtKod.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtKod.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtKod.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtKod.Properties.MaxLength = 20;
            this.txtKod.Size = new System.Drawing.Size(145, 20);
            this.txtKod.StatusBarAciklama = "Kod giriniz.";
            this.txtKod.StyleController = this.myDataLayoutControl;
            this.txtKod.TabIndex = 5;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.myKodTextEdit,
            this.myTextEdit,
            this.myButtonEditIl,
            this.myButtonEditIlce,
            this.myAciklamaMemoEdit,
            this.durumAktifPasif});
            this.Root.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.Root.Name = "Root";
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition1.Width = 200D;
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition2.Width = 100D;
            columnDefinition3.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition3.Width = 99D;
            this.Root.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1,
            columnDefinition2,
            columnDefinition3});
            rowDefinition1.Height = 24D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition2.Height = 24D;
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition3.Height = 24D;
            rowDefinition3.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition4.Height = 24D;
            rowDefinition4.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition5.Height = 100D;
            rowDefinition5.SizeType = System.Windows.Forms.SizeType.Percent;
            this.Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2,
            rowDefinition3,
            rowDefinition4,
            rowDefinition5});
            this.Root.Size = new System.Drawing.Size(398, 166);
            this.Root.TextVisible = false;
            // 
            // myKodTextEdit
            // 
            this.myKodTextEdit.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.myKodTextEdit.AppearanceItemCaption.Options.UseForeColor = true;
            this.myKodTextEdit.Control = this.txtKod;
            this.myKodTextEdit.Location = new System.Drawing.Point(0, 0);
            this.myKodTextEdit.Name = "myKodTextEdit";
            this.myKodTextEdit.Size = new System.Drawing.Size(200, 24);
            this.myKodTextEdit.Text = "Kod";
            this.myKodTextEdit.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.myKodTextEdit.TextSize = new System.Drawing.Size(41, 13);
            this.myKodTextEdit.TextToControlDistance = 10;
            // 
            // myTextEdit
            // 
            this.myTextEdit.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.myTextEdit.AppearanceItemCaption.Options.UseForeColor = true;
            this.myTextEdit.Control = this.txtOkulAdi;
            this.myTextEdit.Location = new System.Drawing.Point(0, 24);
            this.myTextEdit.Name = "myTextEdit";
            this.myTextEdit.OptionsTableLayoutItem.ColumnSpan = 3;
            this.myTextEdit.OptionsTableLayoutItem.RowIndex = 1;
            this.myTextEdit.Size = new System.Drawing.Size(378, 24);
            this.myTextEdit.Text = "Okul Adı";
            this.myTextEdit.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.myTextEdit.TextSize = new System.Drawing.Size(41, 13);
            this.myTextEdit.TextToControlDistance = 10;
            // 
            // myButtonEditIl
            // 
            this.myButtonEditIl.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.myButtonEditIl.AppearanceItemCaption.Options.UseForeColor = true;
            this.myButtonEditIl.Control = this.btnIl;
            this.myButtonEditIl.Location = new System.Drawing.Point(0, 48);
            this.myButtonEditIl.Name = "myButtonEditIl";
            this.myButtonEditIl.OptionsTableLayoutItem.RowIndex = 2;
            this.myButtonEditIl.Size = new System.Drawing.Size(200, 24);
            this.myButtonEditIl.Text = "İl ";
            this.myButtonEditIl.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.myButtonEditIl.TextSize = new System.Drawing.Size(41, 13);
            this.myButtonEditIl.TextToControlDistance = 10;
            // 
            // myButtonEditIlce
            // 
            this.myButtonEditIlce.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.myButtonEditIlce.AppearanceItemCaption.Options.UseForeColor = true;
            this.myButtonEditIlce.Control = this.btnIlce;
            this.myButtonEditIlce.Location = new System.Drawing.Point(0, 72);
            this.myButtonEditIlce.Name = "myButtonEditIlce";
            this.myButtonEditIlce.OptionsTableLayoutItem.RowIndex = 3;
            this.myButtonEditIlce.Size = new System.Drawing.Size(200, 24);
            this.myButtonEditIlce.Text = "İlçe";
            this.myButtonEditIlce.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.myButtonEditIlce.TextSize = new System.Drawing.Size(41, 13);
            this.myButtonEditIlce.TextToControlDistance = 10;
            // 
            // myAciklamaMemoEdit
            // 
            this.myAciklamaMemoEdit.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.myAciklamaMemoEdit.AppearanceItemCaption.Options.UseForeColor = true;
            this.myAciklamaMemoEdit.Control = this.txtAciklama;
            this.myAciklamaMemoEdit.Location = new System.Drawing.Point(0, 96);
            this.myAciklamaMemoEdit.Name = "myAciklamaMemoEdit";
            this.myAciklamaMemoEdit.OptionsTableLayoutItem.ColumnSpan = 3;
            this.myAciklamaMemoEdit.OptionsTableLayoutItem.RowIndex = 4;
            this.myAciklamaMemoEdit.Size = new System.Drawing.Size(378, 50);
            this.myAciklamaMemoEdit.Text = "Açıklama";
            this.myAciklamaMemoEdit.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.myAciklamaMemoEdit.TextSize = new System.Drawing.Size(41, 13);
            this.myAciklamaMemoEdit.TextToControlDistance = 10;
            // 
            // durumAktifPasif
            // 
            this.durumAktifPasif.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.durumAktifPasif.AppearanceItemCaption.Options.UseForeColor = true;
            this.durumAktifPasif.Control = this.tglDurum;
            this.durumAktifPasif.Location = new System.Drawing.Point(279, 0);
            this.durumAktifPasif.Name = "durumAktifPasif";
            this.durumAktifPasif.OptionsTableLayoutItem.ColumnIndex = 2;
            this.durumAktifPasif.Size = new System.Drawing.Size(99, 24);
            this.durumAktifPasif.TextSize = new System.Drawing.Size(0, 0);
            this.durumAktifPasif.TextVisible = false;
            // 
            // OkulEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 299);
            this.Controls.Add(this.myDataLayoutControl);
            this.IconOptions.ShowIcon = false;
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "OkulEditForm";
            this.Text = "Okul Kartı";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.myDataLayoutControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).EndInit();
            this.myDataLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tglDurum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnIlce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnIl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOkulAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myKodTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myButtonEditIl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myButtonEditIlce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myAciklamaMemoEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.durumAktifPasif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Controls.MyDataLayoutControl myDataLayoutControl;
        private UserControls.Controls.MyToggleSwitch tglDurum;
        private UserControls.Controls.MyMemoEdit txtAciklama;
        private UserControls.Controls.MyButtonEdit btnIlce;
        private UserControls.Controls.MyButtonEdit btnIl;
        private UserControls.Controls.MyTextEdit txtOkulAdi;
        private UserControls.Controls.MyKodTextEdit txtKod;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem myKodTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem myTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem myButtonEditIl;
        private DevExpress.XtraLayout.LayoutControlItem myAciklamaMemoEdit;
        private DevExpress.XtraLayout.LayoutControlItem durumAktifPasif;
        private DevExpress.XtraLayout.LayoutControlItem myButtonEditIlce;
    }
}