namespace AbcYazilim.OgrenciTakip.UI.Win.Navigators
{
    partial class InstUpNavigator
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstUpNavigator));
            this.Navigator = new DevExpress.XtraEditors.ControlNavigator();
            this.imageCollection = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            this.SuspendLayout();
            // 
            // Navigator
            // 
            this.Navigator.Buttons.Append.ImageIndex = 6;
            this.Navigator.Buttons.CancelEdit.Visible = false;
            this.Navigator.Buttons.Edit.Visible = false;
            this.Navigator.Buttons.EndEdit.Visible = false;
            this.Navigator.Buttons.First.ImageIndex = 1;
            this.Navigator.Buttons.ImageList = this.imageCollection;
            this.Navigator.Buttons.Last.ImageIndex = 3;
            this.Navigator.Buttons.Next.ImageIndex = 0;
            this.Navigator.Buttons.NextPage.ImageIndex = 4;
            this.Navigator.Buttons.NextPage.Visible = false;
            this.Navigator.Buttons.Prev.ImageIndex = 2;
            this.Navigator.Buttons.PrevPage.ImageIndex = 5;
            this.Navigator.Buttons.PrevPage.Visible = false;
            this.Navigator.Buttons.Remove.ImageIndex = 7;
            this.Navigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Navigator.Location = new System.Drawing.Point(0, -3);
            this.Navigator.Name = "Navigator";
            this.Navigator.Size = new System.Drawing.Size(478, 24);
            this.Navigator.TabIndex = 0;
            this.Navigator.Text = "controlNavigator1";
            // 
            // imageCollection
            // 
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            this.imageCollection.Images.SetKeyName(0, "next_16x16.png");
            this.imageCollection.Images.SetKeyName(1, "first_16x16.png");
            this.imageCollection.Images.SetKeyName(2, "prev_16x16.png");
            this.imageCollection.Images.SetKeyName(3, "last_16x16.png");
            this.imageCollection.Images.SetKeyName(4, "doublenext_16x16.png");
            this.imageCollection.Images.SetKeyName(5, "doubleprev_16x16.png");
            this.imageCollection.Images.SetKeyName(6, "additem_16x16.png");
            this.imageCollection.Images.SetKeyName(7, "deletelist_16x16.png");
            // 
            // InstUpNavigator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Navigator);
            this.Name = "InstUpNavigator";
            this.Size = new System.Drawing.Size(478, 21);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.Utils.ImageCollection imageCollection;
        protected internal DevExpress.XtraEditors.ControlNavigator Navigator;
    }
}
