using AbcYazilim.OgrenciTakip.Bll.Interfaces;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.Model.Entities.Base;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.FilterForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.GeneralForms;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;
using AbcYazilim.OgrenciTakip.UI.Win.Show;
using AbcYazilim.OgrenciTakip.UI.Win.Show.Interfaces;
using AbcYazilimOgrenciTakip.Bll.Interfaces;
using DevExpress.Mvvm.Native;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms
{
    public partial class BaseListForm : RibbonForm
    {
        private long _filterId;
        private bool _formSablonKayitEdilecek;
        private bool _tabloSablonKayitEdilecek;
        protected IBaseFormShow FormShow;
        protected KartTuru BaseKartTuru;
        protected internal GridView Tablo;
        protected bool AktifKartlariGoster = true;
        protected internal bool MultiSelect;
        protected internal BaseEntity SelectedEntity;
        protected IBaseBll Bll;
        protected ControlNavigator Navigator;
        protected internal bool AktifPasifButonGoster = false;
        protected internal long? SeciliGelecekId;
        protected BarItem[] ShowItems;
        protected BarItem[] HideItems;

        public BaseListForm()
        {
            InitializeComponent();
        }

        private void EventsLoad()
        {
            //Button events
            foreach (BarItem button in ribbonControl.Items)
                        button.ItemClick += Button_ItemClick;

            //table events
            Tablo.DoubleClick += Tablo_DoubleClick;
            Tablo.KeyDown += Tablo_KeyDown;
            Tablo.MouseUp += Tablo_MouseUp;
            Tablo.ColumnWidthChanged += Tablo_ColumnWidthChanged;
            Tablo.ColumnPositionChanged += Tablo_ColumnPositionChanged;
            Tablo.EndSorting += Tablo_EndSorting;
            Tablo.FilterEditorCreated += Tablo_FilterEditorCreated;
            Tablo.ColumnFilterChanged += Tablo_ColumnFilterChanged;

            //form events

            Shown += BaseListForm_Shown;
            Load += BaseListForm_Load;
            FormClosing += BaseListForm_FormClosing;
            LocationChanged += BaseListForm_LocationChanged;
            SizeChanged += BaseListForm_SizeChanged;
        }

        private void Tablo_ColumnFilterChanged(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Tablo.ActiveFilterString))
                _filterId = 0;
        }

        private void Tablo_FilterEditorCreated(object sender, DevExpress.XtraGrid.Views.Base.FilterControlEventArgs e)
        {
            e.ShowFilterEditor = false;
            ShowEditForms<FilterEditForm>.ShowDialogEditForm(KartTuru.Filter,_filterId,BaseKartTuru, Tablo.GridControl);
        }

        private void BaseListForm_SizeChanged(object? sender, EventArgs e)
        {
            if(!IsMdiChild) 
                _formSablonKayitEdilecek = true;
        }
        private void BaseListForm_LocationChanged(object? sender, EventArgs e)
        {
            if (!IsMdiChild)
                _formSablonKayitEdilecek = true;
        }
        private void Tablo_EndSorting(object? sender, EventArgs e)
        {
            _tabloSablonKayitEdilecek = true;
        }
        private void Tablo_ColumnPositionChanged(object? sender, EventArgs e)
        {
            _tabloSablonKayitEdilecek = true;
        }
        private void Tablo_ColumnWidthChanged(object sender, DevExpress.XtraGrid.Views.Base.ColumnEventArgs e)
        {
            _tabloSablonKayitEdilecek = true;
        }
        private void BaseListForm_FormClosing(object? sender, FormClosingEventArgs e)
        {
            SablonKaydet();
        }

        private void BaseListForm_Load(object? sender, EventArgs e)
        {
            SablonYukle();
        }

        private void Tablo_MouseUp(object? sender, MouseEventArgs e)
        {
            e.SagMenuGoster(sagMenu);
        }

        private void BaseListForm_Shown(object? sender, EventArgs e)
        {
            Tablo.Focus();
            ButonGizleGoster();
           // SutunGizleGoster();

            if (IsMdiChild || !SeciliGelecekId.HasValue) return; //SeciliGelecekId == null) return;
            Tablo.RowFocus("Id",SeciliGelecekId);
        }
        private void SutunGizleGoster()
        {
            throw new NotImplementedException();
        }
        private void SablonKaydet()
        {
            if (_formSablonKayitEdilecek)
                Name.FormSablonKaydet(Left, Top, Width, Height, WindowState);

            if (_tabloSablonKayitEdilecek)
                Tablo.TabloSablonKaydet(IsMdiChild ? Name + " Tablosu" : Name + " TablosuMDI");
        }
        private void SablonYukle()
        {
            if (IsMdiChild)
                Tablo.TabloSablonYukle(Name + " Tablosu");
            else
            {
                Name.FormSablonYukle(this);
                Tablo.TabloSablonYukle(Name + " TablosuMDI");
            }
        }
        private void ButonGizleGoster()
        {
            btnSec.Visibility = AktifPasifButonGoster ? BarItemVisibility.Never : IsMdiChild ? BarItemVisibility.Never : BarItemVisibility.Always;
            barEnter.Visibility = IsMdiChild?BarItemVisibility.Never : BarItemVisibility.Always;
            barEnterAciklama.Visibility = IsMdiChild ? BarItemVisibility.Never : BarItemVisibility.Always;
            btnAktifPasifKartlar.Visibility = AktifPasifButonGoster ? BarItemVisibility.Always : !IsMdiChild ? BarItemVisibility.Never : BarItemVisibility.Always;

            ShowItems?.ForEach(x => x.Visibility = BarItemVisibility.Always);
            /*            I
                          V
            foreach (BarItem item in ShowItems)
            {
                item.Visibility = BarItemVisibility.Always;
            }
            */
            HideItems?.ForEach(x => x.Visibility = BarItemVisibility.Never);
        }

        protected internal void Yukle()
        {
            DegiskenleriDoldur();
            EventsLoad();

            Tablo.OptionsSelection.MultiSelect = MultiSelect;
            Navigator.NavigatableControl = Tablo.GridControl;

            Cursor.Current = Cursors.WaitCursor;
            Listele();
            Cursor.Current = DefaultCursor;
            
            //Güncellenecek
        }

        protected virtual void DegiskenleriDoldur()
        {
            
        }

        protected virtual void ShowEditForm(long id)
        {
            var result = FormShow.ShowDialogEditForm(BaseKartTuru,id);
            ShowEditFormDefault(result);
        }
        protected void ShowEditFormDefault(long id)
        {
            if(id<=0) return;
            AktifKartlariGoster = true;
            FormCaptionAyarla();
            Tablo.RowFocus("Id", id);
        }
        protected virtual void EntityDelete()
        {
            var entity = Tablo.GetRow<BaseEntity>();
            if(entity == null) return;
            if (!((IBaseCommonBll)Bll).Delete(entity)) return;

            Tablo.DeleteSelectedRows();
            Tablo.RowFocus(Tablo.FocusedRowHandle);
        }
        private void SelectEntity()
        {
            if (MultiSelect)
            {
                //Güncellenecek
            }
            else SelectedEntity = Tablo.GetRow<BaseEntity>();

            DialogResult = DialogResult.OK;
            Close();
        }
        protected virtual void Listele() 
        {
            //Tablo.GridControl.DataSource = ((OkulBll)Bll).List(FilterFunctions.Filter<Okul>(AktifKartlariGoster));
        }

        private void FiltreSec()
        {
            var entity = (Filter)ShowListForms<FilterListForm>.ShowDialogListForm(KartTuru.Filter,_filterId,BaseKartTuru,Tablo.GridControl);
            if (entity == null) return;

            _filterId = entity.Id;
            Tablo.ActiveFilterString = entity.FilterMetni;
        }
        protected virtual void Yazdir()
        {
            TablePrintingFunctions.Yazdir(Tablo, Tablo.ViewCaption, AnaForm.SubeAdi);
        }
        private void FormCaptionAyarla()
        {
            if(btnAktifPasifKartlar == null)
            {
                Listele();
                return;
            }

            if (AktifKartlariGoster)
            {
                btnAktifPasifKartlar.Caption = "PasifKartlar";
                Tablo.ViewCaption = Text;
            }
            else
            {
                btnAktifPasifKartlar.Caption = "Aktif Kartlar";
                Tablo.ViewCaption = Text + " - Pasif Kartlar";
            }
            Listele();
        }
        private void IslemTuruSec()
        {
            if (!IsMdiChild)
            {
                //Güncellenecek
                SelectEntity();
            }
            else 
                btnDuzelt.PerformClick();
        }



        private void Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (e.Item == btnGonder)
            {
                var link = (BarSubItemLink)e.Item.Links[0];
                link.Focus();
                link.OpenMenu();
                link.Item.ItemLinks[0].Focus();
            }
            else if (e.Item == btnStandartExcellDosyasi) Tablo.TabloDisariAktar(DosyaTuru.ExcellStandart, e.Item.Caption, Text);
            else if (e.Item == btnFormatliExcellDosyasi) Tablo.TabloDisariAktar(DosyaTuru.ExcellFormatli, e.Item.Caption, Text);
            else if (e.Item == btnFormatsizExcellDosyasi) Tablo.TabloDisariAktar(DosyaTuru.ExcellFormatsiz, e.Item.Caption);
            else if (e.Item == btnWordDosyasi) Tablo.TabloDisariAktar(DosyaTuru.WordDosyasi, e.Item.Caption);
            else if (e.Item == btnPdfDosyasi) Tablo.TabloDisariAktar(DosyaTuru.PdfDosyasi, e.Item.Caption);
            else if (e.Item == btnTextDosyasi) Tablo.TabloDisariAktar(DosyaTuru.TextDosyasi, e.Item.Caption);

            else if (e.Item == btnYeni)
            {
                //yetki kontrolü
                ShowEditForm(-1);
            }
            else if (e.Item == btnDuzelt)
                ShowEditForm(Tablo.GetRowId());
            else if (e.Item == btnSil)
            {
                //yetki kontrolü
                EntityDelete();
            }
            else if (e.Item == btnSec)
            {
                SelectEntity();
            }
            else if (e.Item == btnYenile)
            {
                Listele();
            }
            else if (e.Item == btnFiltrele)
                FiltreSec();
            else if (e.Item == btnKolonlar)
            {
                if (Tablo.CustomizationForm == null)
                    Tablo.ShowCustomization();
                else Tablo.HideCustomization();
            }
            else if (e.Item == btnBagliKartlar)
                BagliKartAc();
            else if (e.Item == btnYazdir) Yazdir();
            else if (e.Item == btnCikis) Close();
            else if (e.Item == btnAktifPasifKartlar)
            {
                AktifKartlariGoster = !AktifKartlariGoster;
                FormCaptionAyarla();
            }

            Cursor.Current = DefaultCursor;
        }

        protected virtual void BagliKartAc() { }
        private void Tablo_DoubleClick(object? sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            IslemTuruSec();
            Cursor.Current = DefaultCursor;
        }
        private void Tablo_KeyDown(object? sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    IslemTuruSec();
                    break;
                
                case Keys.Escape:
                    Close();
                    break;
            }
        }
    }
}