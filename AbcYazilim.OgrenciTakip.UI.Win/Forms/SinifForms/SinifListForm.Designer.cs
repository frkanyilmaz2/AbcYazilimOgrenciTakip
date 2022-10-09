namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.SinifForms
{
    partial class SinifListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SinifListForm));
            this.longNavigator = new AbcYazilim.OgrenciTakip.UI.Win.Navigators.longNavigator();
            this.grid = new AbcYazilim.OgrenciTakip.UI.Win.Grid.MyBandedGridControl();
            this.tablo = new AbcYazilim.OgrenciTakip.UI.Win.Grid.MyBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colKod = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colSinifAdi = new AbcYazilim.OgrenciTakip.UI.Win.Grid.MyBandedGridColumn();
            this.colGrupAdi = new AbcYazilim.OgrenciTakip.UI.Win.Grid.MyBandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colHedefOgrenciSayisi = new AbcYazilim.OgrenciTakip.UI.Win.Grid.MyBandedGridColumn();
            this.repositoryItemInt = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colHedefCiro = new AbcYazilim.OgrenciTakip.UI.Win.Grid.MyBandedGridColumn();
            this.repositoryItemDecimal = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colAciklama = new AbcYazilim.OgrenciTakip.UI.Win.Grid.MyBandedGridColumn();
            this.colId = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemInt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDecimal)).BeginInit();
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
            this.ribbonControl.Size = new System.Drawing.Size(1073, 109);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // btnGonder
            // 
            this.btnGonder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGonder.ImageOptions.Image")));
            this.btnGonder.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGonder.ImageOptions.LargeImage")));
            // 
            // longNavigator
            // 
            this.longNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.longNavigator.Location = new System.Drawing.Point(0, 507);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(1073, 24);
            this.longNavigator.TabIndex = 2;
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 109);
            this.grid.MainView = this.tablo;
            this.grid.MenuManager = this.ribbonControl;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDecimal,
            this.repositoryItemInt});
            this.grid.Size = new System.Drawing.Size(1073, 398);
            this.grid.TabIndex = 3;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tablo});
            // 
            // tablo
            // 
            this.tablo.Appearance.BandPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tablo.Appearance.BandPanel.ForeColor = System.Drawing.Color.DarkBlue;
            this.tablo.Appearance.BandPanel.Options.UseFont = true;
            this.tablo.Appearance.BandPanel.Options.UseForeColor = true;
            this.tablo.Appearance.BandPanel.Options.UseTextOptions = true;
            this.tablo.Appearance.BandPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tablo.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tablo.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.tablo.Appearance.FooterPanel.Options.UseFont = true;
            this.tablo.Appearance.FooterPanel.Options.UseForeColor = true;
            this.tablo.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.tablo.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.tablo.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.tablo.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tablo.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.tablo.Appearance.ViewCaption.Options.UseForeColor = true;
            this.tablo.AppearancePrint.FooterPanel.Options.UseTextOptions = true;
            this.tablo.AppearancePrint.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tablo.BandPanelRowHeight = 40;
            this.tablo.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2,
            this.gridBand3});
            this.tablo.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colId,
            this.colKod,
            this.colSinifAdi,
            this.colGrupAdi,
            this.colHedefOgrenciSayisi,
            this.colHedefCiro,
            this.colAciklama});
            this.tablo.GridControl = this.grid;
            this.tablo.Name = "tablo";
            this.tablo.OptionsMenu.EnableColumnMenu = false;
            this.tablo.OptionsMenu.EnableFooterMenu = false;
            this.tablo.OptionsMenu.EnableGroupPanelMenu = false;
            this.tablo.OptionsNavigation.EnterMoveNextColumn = true;
            this.tablo.OptionsPrint.AutoWidth = false;
            this.tablo.OptionsPrint.PrintGroupFooter = false;
            this.tablo.OptionsView.ColumnAutoWidth = false;
            this.tablo.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.tablo.OptionsView.RowAutoHeight = true;
            this.tablo.OptionsView.ShowAutoFilterRow = true;
            this.tablo.OptionsView.ShowFooter = true;
            this.tablo.OptionsView.ShowGroupPanel = false;
            this.tablo.OptionsView.ShowViewCaption = true;
            this.tablo.StatusBarAciklama = null;
            this.tablo.StatusBarKisayol = null;
            this.tablo.StatusBarKisayolAciklama = null;
            this.tablo.ViewCaption = "Sınıf Kartları";
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Sınıf Bilgileri";
            this.gridBand1.Columns.Add(this.colKod);
            this.gridBand1.Columns.Add(this.colSinifAdi);
            this.gridBand1.Columns.Add(this.colGrupAdi);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 500;
            // 
            // colKod
            // 
            this.colKod.AppearanceCell.Options.UseTextOptions = true;
            this.colKod.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKod.Caption = "Kod";
            this.colKod.FieldName = "Kod";
            this.colKod.Name = "colKod";
            this.colKod.OptionsColumn.AllowEdit = false;
            this.colKod.Visible = true;
            this.colKod.Width = 100;
            // 
            // colSinifAdi
            // 
            this.colSinifAdi.Caption = "Sınıf Adı";
            this.colSinifAdi.FieldName = "SinifAdi";
            this.colSinifAdi.Name = "colSinifAdi";
            this.colSinifAdi.OptionsColumn.AllowEdit = false;
            this.colSinifAdi.StatusBarAciklama = null;
            this.colSinifAdi.StatusBarKisayol = null;
            this.colSinifAdi.StatusBarKisayolAciklama = null;
            this.colSinifAdi.Visible = true;
            this.colSinifAdi.Width = 200;
            // 
            // colGrupAdi
            // 
            this.colGrupAdi.Caption = "Grup Adı";
            this.colGrupAdi.FieldName = "GrupAdi";
            this.colGrupAdi.Name = "colGrupAdi";
            this.colGrupAdi.OptionsColumn.AllowEdit = false;
            this.colGrupAdi.StatusBarAciklama = null;
            this.colGrupAdi.StatusBarKisayol = null;
            this.colGrupAdi.StatusBarKisayolAciklama = null;
            this.colGrupAdi.Visible = true;
            this.colGrupAdi.Width = 200;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Hedef Bilgileri";
            this.gridBand2.Columns.Add(this.colHedefOgrenciSayisi);
            this.gridBand2.Columns.Add(this.colHedefCiro);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 238;
            // 
            // colHedefOgrenciSayisi
            // 
            this.colHedefOgrenciSayisi.AppearanceCell.Options.UseTextOptions = true;
            this.colHedefOgrenciSayisi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHedefOgrenciSayisi.Caption = "Öğrenci Sayısı";
            this.colHedefOgrenciSayisi.ColumnEdit = this.repositoryItemInt;
            this.colHedefOgrenciSayisi.CustomizationCaption = "Hedef Öğrenci Sayısı";
            this.colHedefOgrenciSayisi.FieldName = "HedefOgrenciSayisi";
            this.colHedefOgrenciSayisi.Name = "colHedefOgrenciSayisi";
            this.colHedefOgrenciSayisi.OptionsColumn.AllowEdit = false;
            this.colHedefOgrenciSayisi.StatusBarAciklama = null;
            this.colHedefOgrenciSayisi.StatusBarKisayol = null;
            this.colHedefOgrenciSayisi.StatusBarKisayolAciklama = null;
            this.colHedefOgrenciSayisi.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "HedefOgrenciSayisi", "{0:n0}")});
            this.colHedefOgrenciSayisi.Visible = true;
            this.colHedefOgrenciSayisi.Width = 116;
            // 
            // repositoryItemInt
            // 
            this.repositoryItemInt.Appearance.Options.UseTextOptions = true;
            this.repositoryItemInt.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemInt.AutoHeight = false;
            this.repositoryItemInt.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemInt.DisplayFormat.FormatString = "n0";
            this.repositoryItemInt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemInt.MaskSettings.Set("mask", "n0");
            this.repositoryItemInt.Name = "repositoryItemInt";
            // 
            // colHedefCiro
            // 
            this.colHedefCiro.Caption = "Ciro";
            this.colHedefCiro.ColumnEdit = this.repositoryItemDecimal;
            this.colHedefCiro.CustomizationCaption = "Hedef Ciro";
            this.colHedefCiro.FieldName = "HedefCiro";
            this.colHedefCiro.Name = "colHedefCiro";
            this.colHedefCiro.OptionsColumn.AllowEdit = false;
            this.colHedefCiro.StatusBarAciklama = null;
            this.colHedefCiro.StatusBarKisayol = null;
            this.colHedefCiro.StatusBarKisayolAciklama = null;
            this.colHedefCiro.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "HedefCiro", "{0:n2}")});
            this.colHedefCiro.Visible = true;
            this.colHedefCiro.Width = 122;
            // 
            // repositoryItemDecimal
            // 
            this.repositoryItemDecimal.Appearance.Options.UseTextOptions = true;
            this.repositoryItemDecimal.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.repositoryItemDecimal.AutoHeight = false;
            this.repositoryItemDecimal.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDecimal.DisplayFormat.FormatString = "n2";
            this.repositoryItemDecimal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemDecimal.MaskSettings.Set("mask", "n2");
            this.repositoryItemDecimal.Name = "repositoryItemDecimal";
            // 
            // gridBand3
            // 
            this.gridBand3.Caption = "Diğer Bilgiler";
            this.gridBand3.Columns.Add(this.colAciklama);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 2;
            this.gridBand3.Width = 450;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.StatusBarAciklama = null;
            this.colAciklama.StatusBarKisayol = null;
            this.colAciklama.StatusBarKisayolAciklama = null;
            this.colAciklama.Visible = true;
            this.colAciklama.Width = 450;
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // SinifListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 555);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "SinifListForm";
            this.Text = "Sınıf Kartları";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemInt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDecimal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Navigators.longNavigator longNavigator;
        private Grid.MyBandedGridControl grid;
        private Grid.MyBandedGridView tablo;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colKod;
        private Grid.MyBandedGridColumn colSinifAdi;
        private Grid.MyBandedGridColumn colGrupAdi;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private Grid.MyBandedGridColumn colHedefOgrenciSayisi;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemInt;
        private Grid.MyBandedGridColumn colHedefCiro;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemDecimal;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private Grid.MyBandedGridColumn colAciklama;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colId;
    }
}