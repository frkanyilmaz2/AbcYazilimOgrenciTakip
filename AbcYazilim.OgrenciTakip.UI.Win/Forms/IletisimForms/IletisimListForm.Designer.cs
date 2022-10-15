namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.IletisimForms
{
    partial class IletisimListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IletisimListForm));
            this.longNavigator = new AbcYazilim.OgrenciTakip.UI.Win.Navigators.longNavigator();
            this.grid = new AbcYazilim.OgrenciTakip.UI.Win.Grid.MyBandedGridControl();
            this.tablo = new AbcYazilim.OgrenciTakip.UI.Win.Grid.MyBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colKod = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colTcKimlikNo = new AbcYazilim.OgrenciTakip.UI.Win.Grid.MyBandedGridColumn();
            this.colAdi = new AbcYazilim.OgrenciTakip.UI.Win.Grid.MyBandedGridColumn();
            this.colSoyadi = new AbcYazilim.OgrenciTakip.UI.Win.Grid.MyBandedGridColumn();
            this.colMeslek = new AbcYazilim.OgrenciTakip.UI.Win.Grid.MyBandedGridColumn();
            this.colWeb = new AbcYazilim.OgrenciTakip.UI.Win.Grid.MyBandedGridColumn();
            this.colEmail = new AbcYazilim.OgrenciTakip.UI.Win.Grid.MyBandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colEvTel = new AbcYazilim.OgrenciTakip.UI.Win.Grid.MyBandedGridColumn();
            this.colIsTel1 = new AbcYazilim.OgrenciTakip.UI.Win.Grid.MyBandedGridColumn();
            this.colCepTel1 = new AbcYazilim.OgrenciTakip.UI.Win.Grid.MyBandedGridColumn();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colEvAdresi = new AbcYazilim.OgrenciTakip.UI.Win.Grid.MyBandedGridColumn();
            this.colEvAdresIlAdi = new AbcYazilim.OgrenciTakip.UI.Win.Grid.MyBandedGridColumn();
            this.colEvAdresIlceAdi = new AbcYazilim.OgrenciTakip.UI.Win.Grid.MyBandedGridColumn();
            this.colIsAdres = new AbcYazilim.OgrenciTakip.UI.Win.Grid.MyBandedGridColumn();
            this.colIsAdresIlAdi = new AbcYazilim.OgrenciTakip.UI.Win.Grid.MyBandedGridColumn();
            this.colIsAdresIlceAdi = new AbcYazilim.OgrenciTakip.UI.Win.Grid.MyBandedGridColumn();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colIsYeriAdi = new AbcYazilim.OgrenciTakip.UI.Win.Grid.MyBandedGridColumn();
            this.colGorev = new AbcYazilim.OgrenciTakip.UI.Win.Grid.MyBandedGridColumn();
            this.gridBand5 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colOzelKod1Adi = new AbcYazilim.OgrenciTakip.UI.Win.Grid.MyBandedGridColumn();
            this.colOzelKod2Adi = new AbcYazilim.OgrenciTakip.UI.Win.Grid.MyBandedGridColumn();
            this.gridBand6 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colAciklama = new AbcYazilim.OgrenciTakip.UI.Win.Grid.MyBandedGridColumn();
            this.colId = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colDahili1 = new AbcYazilim.OgrenciTakip.UI.Win.Grid.MyBandedGridColumn();
            this.colDahili2 = new AbcYazilim.OgrenciTakip.UI.Win.Grid.MyBandedGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
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
            this.longNavigator.Location = new System.Drawing.Point(0, 492);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(1036, 24);
            this.longNavigator.TabIndex = 2;
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 109);
            this.grid.MainView = this.tablo;
            this.grid.MenuManager = this.ribbonControl;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(1036, 383);
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
            this.tablo.BandPanelRowHeight = 40;
            this.tablo.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2,
            this.gridBand3,
            this.gridBand4,
            this.gridBand5,
            this.gridBand6});
            this.tablo.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colId,
            this.colKod,
            this.colTcKimlikNo,
            this.colAdi,
            this.colSoyadi,
            this.colMeslek,
            this.colWeb,
            this.colEmail,
            this.colEvTel,
            this.colIsTel1,
            this.colCepTel1,
            this.colDahili1,
            this.colDahili2,
            this.colEvAdresi,
            this.colEvAdresIlAdi,
            this.colEvAdresIlceAdi,
            this.colIsAdres,
            this.colIsAdresIlAdi,
            this.colIsAdresIlceAdi,
            this.colIsYeriAdi,
            this.colGorev,
            this.colOzelKod1Adi,
            this.colOzelKod2Adi,
            this.colAciklama});
            this.tablo.GridControl = this.grid;
            this.tablo.Name = "tablo";
            this.tablo.OptionsMenu.EnableColumnMenu = false;
            this.tablo.OptionsMenu.EnableFooterMenu = false;
            this.tablo.OptionsMenu.EnableGroupPanelMenu = false;
            this.tablo.OptionsNavigation.EnterMoveNextColumn = true;
            this.tablo.OptionsPrint.AutoWidth = false;
            this.tablo.OptionsPrint.PrintFooter = false;
            this.tablo.OptionsPrint.PrintGroupFooter = false;
            this.tablo.OptionsView.ColumnAutoWidth = false;
            this.tablo.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.tablo.OptionsView.RowAutoHeight = true;
            this.tablo.OptionsView.ShowAutoFilterRow = true;
            this.tablo.OptionsView.ShowGroupPanel = false;
            this.tablo.OptionsView.ShowViewCaption = true;
            this.tablo.StatusBarAciklama = null;
            this.tablo.StatusBarKisayol = null;
            this.tablo.StatusBarKisayolAciklama = null;
            this.tablo.ViewCaption = "İletişim Kartları";
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Genel Bilgiler";
            this.gridBand1.Columns.Add(this.colKod);
            this.gridBand1.Columns.Add(this.colTcKimlikNo);
            this.gridBand1.Columns.Add(this.colAdi);
            this.gridBand1.Columns.Add(this.colSoyadi);
            this.gridBand1.Columns.Add(this.colMeslek);
            this.gridBand1.Columns.Add(this.colWeb);
            this.gridBand1.Columns.Add(this.colEmail);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 900;
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
            this.colKod.Width = 120;
            // 
            // colTcKimlikNo
            // 
            this.colTcKimlikNo.AppearanceCell.Options.UseTextOptions = true;
            this.colTcKimlikNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTcKimlikNo.Caption = "TC Kimlik No.";
            this.colTcKimlikNo.FieldName = "TcKimlikNo";
            this.colTcKimlikNo.Name = "colTcKimlikNo";
            this.colTcKimlikNo.OptionsColumn.AllowEdit = false;
            this.colTcKimlikNo.StatusBarAciklama = null;
            this.colTcKimlikNo.StatusBarKisayol = null;
            this.colTcKimlikNo.StatusBarKisayolAciklama = null;
            this.colTcKimlikNo.Visible = true;
            this.colTcKimlikNo.Width = 120;
            // 
            // colAdi
            // 
            this.colAdi.Caption = "Adı";
            this.colAdi.FieldName = "Adi";
            this.colAdi.Name = "colAdi";
            this.colAdi.OptionsColumn.AllowEdit = false;
            this.colAdi.StatusBarAciklama = null;
            this.colAdi.StatusBarKisayol = null;
            this.colAdi.StatusBarKisayolAciklama = null;
            this.colAdi.Visible = true;
            this.colAdi.Width = 120;
            // 
            // colSoyadi
            // 
            this.colSoyadi.Caption = "Soyadı";
            this.colSoyadi.FieldName = "Soyadi";
            this.colSoyadi.Name = "colSoyadi";
            this.colSoyadi.OptionsColumn.AllowEdit = false;
            this.colSoyadi.StatusBarAciklama = null;
            this.colSoyadi.StatusBarKisayol = null;
            this.colSoyadi.StatusBarKisayolAciklama = null;
            this.colSoyadi.Visible = true;
            this.colSoyadi.Width = 120;
            // 
            // colMeslek
            // 
            this.colMeslek.Caption = "Meslek";
            this.colMeslek.FieldName = "MeslekAdi";
            this.colMeslek.Name = "colMeslek";
            this.colMeslek.OptionsColumn.AllowEdit = false;
            this.colMeslek.StatusBarAciklama = null;
            this.colMeslek.StatusBarKisayol = null;
            this.colMeslek.StatusBarKisayolAciklama = null;
            this.colMeslek.Visible = true;
            this.colMeslek.Width = 120;
            // 
            // colWeb
            // 
            this.colWeb.Caption = "Web Adresi";
            this.colWeb.FieldName = "Web";
            this.colWeb.Name = "colWeb";
            this.colWeb.OptionsColumn.AllowEdit = false;
            this.colWeb.StatusBarAciklama = null;
            this.colWeb.StatusBarKisayol = null;
            this.colWeb.StatusBarKisayolAciklama = null;
            this.colWeb.Visible = true;
            this.colWeb.Width = 150;
            // 
            // colEmail
            // 
            this.colEmail.Caption = "E-mail Adresi";
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.OptionsColumn.AllowEdit = false;
            this.colEmail.StatusBarAciklama = null;
            this.colEmail.StatusBarKisayol = null;
            this.colEmail.StatusBarKisayolAciklama = null;
            this.colEmail.Visible = true;
            this.colEmail.Width = 150;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Telefon";
            this.gridBand2.Columns.Add(this.colEvTel);
            this.gridBand2.Columns.Add(this.colIsTel1);
            this.gridBand2.Columns.Add(this.colCepTel1);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 360;
            // 
            // colEvTel
            // 
            this.colEvTel.AppearanceCell.Options.UseTextOptions = true;
            this.colEvTel.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEvTel.Caption = "Ev";
            this.colEvTel.CustomizationCaption = "Ev Telefonu";
            this.colEvTel.FieldName = "EvTel";
            this.colEvTel.Name = "colEvTel";
            this.colEvTel.OptionsColumn.AllowEdit = false;
            this.colEvTel.StatusBarAciklama = null;
            this.colEvTel.StatusBarKisayol = null;
            this.colEvTel.StatusBarKisayolAciklama = null;
            this.colEvTel.Visible = true;
            this.colEvTel.Width = 120;
            // 
            // colIsTel1
            // 
            this.colIsTel1.AppearanceCell.Options.UseTextOptions = true;
            this.colIsTel1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIsTel1.Caption = "İş ";
            this.colIsTel1.CustomizationCaption = "İş Telefonu 1";
            this.colIsTel1.FieldName = "IsTel1";
            this.colIsTel1.Name = "colIsTel1";
            this.colIsTel1.OptionsColumn.AllowEdit = false;
            this.colIsTel1.StatusBarAciklama = null;
            this.colIsTel1.StatusBarKisayol = null;
            this.colIsTel1.StatusBarKisayolAciklama = null;
            this.colIsTel1.Visible = true;
            this.colIsTel1.Width = 120;
            // 
            // colCepTel1
            // 
            this.colCepTel1.AppearanceCell.Options.UseTextOptions = true;
            this.colCepTel1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCepTel1.Caption = "Cep";
            this.colCepTel1.CustomizationCaption = "Cep Telefonu 1";
            this.colCepTel1.FieldName = "CepTel1";
            this.colCepTel1.Name = "colCepTel1";
            this.colCepTel1.OptionsColumn.AllowEdit = false;
            this.colCepTel1.StatusBarAciklama = null;
            this.colCepTel1.StatusBarKisayol = null;
            this.colCepTel1.StatusBarKisayolAciklama = null;
            this.colCepTel1.Visible = true;
            this.colCepTel1.Width = 120;
            // 
            // gridBand3
            // 
            this.gridBand3.Caption = "Adres";
            this.gridBand3.Columns.Add(this.colEvAdresi);
            this.gridBand3.Columns.Add(this.colEvAdresIlAdi);
            this.gridBand3.Columns.Add(this.colEvAdresIlceAdi);
            this.gridBand3.Columns.Add(this.colIsAdres);
            this.gridBand3.Columns.Add(this.colIsAdresIlAdi);
            this.gridBand3.Columns.Add(this.colIsAdresIlceAdi);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 2;
            this.gridBand3.Width = 940;
            // 
            // colEvAdresi
            // 
            this.colEvAdresi.Caption = "Ev";
            this.colEvAdresi.CustomizationCaption = "Ev Adresi";
            this.colEvAdresi.FieldName = "EvAdres";
            this.colEvAdresi.Name = "colEvAdresi";
            this.colEvAdresi.OptionsColumn.AllowEdit = false;
            this.colEvAdresi.StatusBarAciklama = null;
            this.colEvAdresi.StatusBarKisayol = null;
            this.colEvAdresi.StatusBarKisayolAciklama = null;
            this.colEvAdresi.Visible = true;
            this.colEvAdresi.Width = 250;
            // 
            // colEvAdresIlAdi
            // 
            this.colEvAdresIlAdi.Caption = "İl";
            this.colEvAdresIlAdi.CustomizationCaption = "Ev Adresi İl Adı";
            this.colEvAdresIlAdi.FieldName = "EvAdresIlAdi";
            this.colEvAdresIlAdi.Name = "colEvAdresIlAdi";
            this.colEvAdresIlAdi.OptionsColumn.AllowEdit = false;
            this.colEvAdresIlAdi.StatusBarAciklama = null;
            this.colEvAdresIlAdi.StatusBarKisayol = null;
            this.colEvAdresIlAdi.StatusBarKisayolAciklama = null;
            this.colEvAdresIlAdi.Visible = true;
            this.colEvAdresIlAdi.Width = 110;
            // 
            // colEvAdresIlceAdi
            // 
            this.colEvAdresIlceAdi.Caption = "İlçe";
            this.colEvAdresIlceAdi.CustomizationCaption = "Ev Adres İlçe Adı";
            this.colEvAdresIlceAdi.FieldName = "EvAdresIlceAdi";
            this.colEvAdresIlceAdi.Name = "colEvAdresIlceAdi";
            this.colEvAdresIlceAdi.OptionsColumn.AllowEdit = false;
            this.colEvAdresIlceAdi.StatusBarAciklama = null;
            this.colEvAdresIlceAdi.StatusBarKisayol = null;
            this.colEvAdresIlceAdi.StatusBarKisayolAciklama = null;
            this.colEvAdresIlceAdi.Visible = true;
            this.colEvAdresIlceAdi.Width = 110;
            // 
            // colIsAdres
            // 
            this.colIsAdres.Caption = "İş ";
            this.colIsAdres.CustomizationCaption = "İş Adresi";
            this.colIsAdres.FieldName = "IsAdres";
            this.colIsAdres.Name = "colIsAdres";
            this.colIsAdres.OptionsColumn.AllowEdit = false;
            this.colIsAdres.StatusBarAciklama = null;
            this.colIsAdres.StatusBarKisayol = null;
            this.colIsAdres.StatusBarKisayolAciklama = null;
            this.colIsAdres.Visible = true;
            this.colIsAdres.Width = 250;
            // 
            // colIsAdresIlAdi
            // 
            this.colIsAdresIlAdi.Caption = "İl";
            this.colIsAdresIlAdi.CustomizationCaption = "İş Adres İl Adı";
            this.colIsAdresIlAdi.FieldName = "IsAdresIlAdi";
            this.colIsAdresIlAdi.Name = "colIsAdresIlAdi";
            this.colIsAdresIlAdi.OptionsColumn.AllowEdit = false;
            this.colIsAdresIlAdi.StatusBarAciklama = null;
            this.colIsAdresIlAdi.StatusBarKisayol = null;
            this.colIsAdresIlAdi.StatusBarKisayolAciklama = null;
            this.colIsAdresIlAdi.Visible = true;
            this.colIsAdresIlAdi.Width = 110;
            // 
            // colIsAdresIlceAdi
            // 
            this.colIsAdresIlceAdi.Caption = "İlçe";
            this.colIsAdresIlceAdi.CustomizationCaption = "İş Adresi İlçe Adı";
            this.colIsAdresIlceAdi.FieldName = "IsAdresIlceAdi";
            this.colIsAdresIlceAdi.Name = "colIsAdresIlceAdi";
            this.colIsAdresIlceAdi.OptionsColumn.AllowEdit = false;
            this.colIsAdresIlceAdi.StatusBarAciklama = null;
            this.colIsAdresIlceAdi.StatusBarKisayol = null;
            this.colIsAdresIlceAdi.StatusBarKisayolAciklama = null;
            this.colIsAdresIlceAdi.Visible = true;
            this.colIsAdresIlceAdi.Width = 110;
            // 
            // gridBand4
            // 
            this.gridBand4.Caption = "İş Yeri";
            this.gridBand4.Columns.Add(this.colIsYeriAdi);
            this.gridBand4.Columns.Add(this.colGorev);
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.VisibleIndex = 3;
            this.gridBand4.Width = 300;
            // 
            // colIsYeriAdi
            // 
            this.colIsYeriAdi.Caption = "Adı";
            this.colIsYeriAdi.CustomizationCaption = "İş Yeri Adı";
            this.colIsYeriAdi.FieldName = "IsYeriAdi";
            this.colIsYeriAdi.Name = "colIsYeriAdi";
            this.colIsYeriAdi.OptionsColumn.AllowEdit = false;
            this.colIsYeriAdi.StatusBarAciklama = null;
            this.colIsYeriAdi.StatusBarKisayol = null;
            this.colIsYeriAdi.StatusBarKisayolAciklama = null;
            this.colIsYeriAdi.Visible = true;
            this.colIsYeriAdi.Width = 150;
            // 
            // colGorev
            // 
            this.colGorev.Caption = "Görevi";
            this.colGorev.CustomizationCaption = "Görev Adı";
            this.colGorev.FieldName = "GorevAdi";
            this.colGorev.Name = "colGorev";
            this.colGorev.OptionsColumn.AllowEdit = false;
            this.colGorev.StatusBarAciklama = null;
            this.colGorev.StatusBarKisayol = null;
            this.colGorev.StatusBarKisayolAciklama = null;
            this.colGorev.Visible = true;
            this.colGorev.Width = 150;
            // 
            // gridBand5
            // 
            this.gridBand5.Caption = "Özel Kod";
            this.gridBand5.Columns.Add(this.colOzelKod1Adi);
            this.gridBand5.Columns.Add(this.colOzelKod2Adi);
            this.gridBand5.Name = "gridBand5";
            this.gridBand5.VisibleIndex = 4;
            this.gridBand5.Width = 240;
            // 
            // colOzelKod1Adi
            // 
            this.colOzelKod1Adi.Caption = "Özel Kod 1";
            this.colOzelKod1Adi.FieldName = "OzelKod1Adi";
            this.colOzelKod1Adi.Name = "colOzelKod1Adi";
            this.colOzelKod1Adi.OptionsColumn.AllowEdit = false;
            this.colOzelKod1Adi.StatusBarAciklama = null;
            this.colOzelKod1Adi.StatusBarKisayol = null;
            this.colOzelKod1Adi.StatusBarKisayolAciklama = null;
            this.colOzelKod1Adi.Visible = true;
            this.colOzelKod1Adi.Width = 120;
            // 
            // colOzelKod2Adi
            // 
            this.colOzelKod2Adi.Caption = "Özel Kod 2";
            this.colOzelKod2Adi.FieldName = "OzelKod2Adi";
            this.colOzelKod2Adi.Name = "colOzelKod2Adi";
            this.colOzelKod2Adi.OptionsColumn.AllowEdit = false;
            this.colOzelKod2Adi.StatusBarAciklama = null;
            this.colOzelKod2Adi.StatusBarKisayol = null;
            this.colOzelKod2Adi.StatusBarKisayolAciklama = null;
            this.colOzelKod2Adi.Visible = true;
            this.colOzelKod2Adi.Width = 120;
            // 
            // gridBand6
            // 
            this.gridBand6.Caption = "Ek Bilgiler";
            this.gridBand6.Columns.Add(this.colAciklama);
            this.gridBand6.Name = "gridBand6";
            this.gridBand6.VisibleIndex = 5;
            this.gridBand6.Width = 350;
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
            this.colAciklama.Width = 350;
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colDahili1
            // 
            this.colDahili1.AppearanceCell.Options.UseTextOptions = true;
            this.colDahili1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDahili1.Caption = "Dahili 1";
            this.colDahili1.FieldName = "Dahili1";
            this.colDahili1.Name = "colDahili1";
            this.colDahili1.OptionsColumn.AllowEdit = false;
            this.colDahili1.StatusBarAciklama = null;
            this.colDahili1.StatusBarKisayol = null;
            this.colDahili1.StatusBarKisayolAciklama = null;
            this.colDahili1.Visible = true;
            this.colDahili1.Width = 120;
            // 
            // colDahili2
            // 
            this.colDahili2.AppearanceCell.Options.UseTextOptions = true;
            this.colDahili2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDahili2.Caption = "Dahili 2";
            this.colDahili2.FieldName = "Dahili2";
            this.colDahili2.Name = "colDahili2";
            this.colDahili2.OptionsColumn.AllowEdit = false;
            this.colDahili2.StatusBarAciklama = null;
            this.colDahili2.StatusBarKisayol = null;
            this.colDahili2.StatusBarKisayolAciklama = null;
            this.colDahili2.Visible = true;
            this.colDahili2.Width = 120;
            // 
            // IletisimListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 540);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "IletisimListForm";
            this.Text = "İletişim Kartları";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Navigators.longNavigator longNavigator;
        private Grid.MyBandedGridControl grid;
        private Grid.MyBandedGridView tablo;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colKod;
        private Grid.MyBandedGridColumn colTcKimlikNo;
        private Grid.MyBandedGridColumn colAdi;
        private Grid.MyBandedGridColumn colSoyadi;
        private Grid.MyBandedGridColumn colMeslek;
        private Grid.MyBandedGridColumn colWeb;
        private Grid.MyBandedGridColumn colEmail;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private Grid.MyBandedGridColumn colEvTel;
        private Grid.MyBandedGridColumn colIsTel1;
        private Grid.MyBandedGridColumn colCepTel1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private Grid.MyBandedGridColumn colEvAdresi;
        private Grid.MyBandedGridColumn colEvAdresIlAdi;
        private Grid.MyBandedGridColumn colEvAdresIlceAdi;
        private Grid.MyBandedGridColumn colIsAdres;
        private Grid.MyBandedGridColumn colIsAdresIlAdi;
        private Grid.MyBandedGridColumn colIsAdresIlceAdi;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
        private Grid.MyBandedGridColumn colIsYeriAdi;
        private Grid.MyBandedGridColumn colGorev;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand5;
        private Grid.MyBandedGridColumn colOzelKod1Adi;
        private Grid.MyBandedGridColumn colOzelKod2Adi;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand6;
        private Grid.MyBandedGridColumn colAciklama;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colId;
        private Grid.MyBandedGridColumn colDahili1;
        private Grid.MyBandedGridColumn colDahili2;
    }
}