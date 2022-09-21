namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.FilterForms
{
    partial class FilterEditForm
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
            DevExpress.XtraLayout.ColumnDefinition columnDefinition3 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition4 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition4 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition5 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition6 = new DevExpress.XtraLayout.RowDefinition();
            this.myDataLayoutControl = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Controls.MyDataLayoutControl();
            this.txtFilterMetni = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Controls.MyFilterControl();
            this.txtFilterAdi = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Controls.MyTextEdit();
            this.btnKod = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Controls.MyKodTextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtFilterAdi1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtFilterMetni1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).BeginInit();
            this.myDataLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFilterAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnKod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFilterAdi1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFilterMetni1)).BeginInit();
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
            this.myDataLayoutControl.Controls.Add(this.txtFilterMetni);
            this.myDataLayoutControl.Controls.Add(this.txtFilterAdi);
            this.myDataLayoutControl.Controls.Add(this.btnKod);
            this.myDataLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDataLayoutControl.Location = new System.Drawing.Point(0, 109);
            this.myDataLayoutControl.Name = "myDataLayoutControl";
            this.myDataLayoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(972, 102, 650, 400);
            this.myDataLayoutControl.OptionsFocus.EnableAutoTabOrder = false;
            this.myDataLayoutControl.Root = this.Root;
            this.myDataLayoutControl.Size = new System.Drawing.Size(398, 116);
            this.myDataLayoutControl.TabIndex = 0;
            this.myDataLayoutControl.Text = "myDataLayoutControl1";
            // 
            // txtFilterMetni
            // 
            this.txtFilterMetni.Location = new System.Drawing.Point(77, 60);
            this.txtFilterMetni.Name = "txtFilterMetni";
            this.txtFilterMetni.NodeSeparatorHeight = 2;
            this.txtFilterMetni.ShowGroupCommandsIcon = true;
            this.txtFilterMetni.Size = new System.Drawing.Size(309, 44);
            this.txtFilterMetni.StatusBarAciklama = "Filtre metni giriniz.";
            this.txtFilterMetni.TabIndex = 1;
            this.txtFilterMetni.Text = "myFilterControl1";
            // 
            // txtFilterAdi
            // 
            this.txtFilterAdi.Location = new System.Drawing.Point(77, 36);
            this.txtFilterAdi.MenuManager = this.ribbonControl;
            this.txtFilterAdi.Name = "txtFilterAdi";
            this.txtFilterAdi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtFilterAdi.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtFilterAdi.Properties.MaxLength = 50;
            this.txtFilterAdi.Size = new System.Drawing.Size(309, 20);
            this.txtFilterAdi.StatusBarAciklama = "Filtre adı giriniz.";
            this.txtFilterAdi.StyleController = this.myDataLayoutControl;
            this.txtFilterAdi.TabIndex = 0;
            // 
            // btnKod
            // 
            this.btnKod.Location = new System.Drawing.Point(77, 12);
            this.btnKod.MenuManager = this.ribbonControl;
            this.btnKod.Name = "btnKod";
            this.btnKod.Properties.Appearance.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnKod.Properties.Appearance.Options.UseBackColor = true;
            this.btnKod.Properties.Appearance.Options.UseTextOptions = true;
            this.btnKod.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnKod.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.btnKod.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.btnKod.Properties.MaxLength = 20;
            this.btnKod.Size = new System.Drawing.Size(131, 20);
            this.btnKod.StatusBarAciklama = "Kod giriniz.";
            this.btnKod.StyleController = this.myDataLayoutControl;
            this.btnKod.TabIndex = 2;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.txtFilterAdi1,
            this.txtFilterMetni1});
            this.Root.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.Root.Name = "Root";
            columnDefinition3.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition3.Width = 200D;
            columnDefinition4.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition4.Width = 100D;
            this.Root.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition3,
            columnDefinition4});
            rowDefinition4.Height = 24D;
            rowDefinition4.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition5.Height = 24D;
            rowDefinition5.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition6.Height = 100D;
            rowDefinition6.SizeType = System.Windows.Forms.SizeType.Percent;
            this.Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition4,
            rowDefinition5,
            rowDefinition6});
            this.Root.Size = new System.Drawing.Size(398, 116);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem1.Control = this.btnKod;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem1.Text = "Kod";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(53, 13);
            // 
            // txtFilterAdi1
            // 
            this.txtFilterAdi1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.txtFilterAdi1.AppearanceItemCaption.Options.UseForeColor = true;
            this.txtFilterAdi1.Control = this.txtFilterAdi;
            this.txtFilterAdi1.Location = new System.Drawing.Point(0, 24);
            this.txtFilterAdi1.Name = "txtFilterAdi1";
            this.txtFilterAdi1.OptionsTableLayoutItem.ColumnSpan = 2;
            this.txtFilterAdi1.OptionsTableLayoutItem.RowIndex = 1;
            this.txtFilterAdi1.Size = new System.Drawing.Size(378, 24);
            this.txtFilterAdi1.Text = "Filtre Adı";
            this.txtFilterAdi1.TextSize = new System.Drawing.Size(53, 13);
            // 
            // txtFilterMetni1
            // 
            this.txtFilterMetni1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.txtFilterMetni1.AppearanceItemCaption.Options.UseForeColor = true;
            this.txtFilterMetni1.Control = this.txtFilterMetni;
            this.txtFilterMetni1.Location = new System.Drawing.Point(0, 48);
            this.txtFilterMetni1.Name = "txtFilterMetni1";
            this.txtFilterMetni1.OptionsTableLayoutItem.ColumnSpan = 2;
            this.txtFilterMetni1.OptionsTableLayoutItem.RowIndex = 2;
            this.txtFilterMetni1.Size = new System.Drawing.Size(378, 48);
            this.txtFilterMetni1.Text = "Filtre Metni";
            this.txtFilterMetni1.TextSize = new System.Drawing.Size(53, 13);
            // 
            // FilterEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 249);
            this.Controls.Add(this.myDataLayoutControl);
            this.IconOptions.ShowIcon = false;
            this.MinimumSize = new System.Drawing.Size(400, 250);
            this.Name = "FilterEditForm";
            this.Text = "Filtre Kartı";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.myDataLayoutControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).EndInit();
            this.myDataLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtFilterAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnKod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFilterAdi1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFilterMetni1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Controls.MyDataLayoutControl myDataLayoutControl;
        private UserControls.Controls.MyFilterControl txtFilterMetni;
        private UserControls.Controls.MyTextEdit txtFilterAdi;
        private UserControls.Controls.MyKodTextEdit btnKod;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem txtFilterAdi1;
        private DevExpress.XtraLayout.LayoutControlItem txtFilterMetni1;
    }
}