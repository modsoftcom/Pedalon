using Pedalon.UI.Properties;
using Pedalon.UI.Views;

namespace Pedalon.UI.UserControls
{
    partial class CustomRecordTools
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));

            this.btnAddNew = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnDetails = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();

            // 
            // btnAddNew
            // 
            this.btnAddNew.Caption = "Yeni";
            this.btnAddNew.Glyph = ((System.Drawing.Image)(resources.GetObject("btnAddNew.Glyph")));
            this.btnAddNew.Id = 2;
            this.btnAddNew.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnAddNew.LargeGlyph")));
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Sil";
            this.btnDelete.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDelete.Glyph")));
            this.btnDelete.Id = 3;
            this.btnDelete.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnDelete.LargeGlyph")));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnEdit
            // 
            this.btnEdit.Caption = "Düzenle";
            this.btnEdit.Glyph = ((System.Drawing.Image)(resources.GetObject("btnEdit.Glyph")));
            this.btnEdit.Id = 4;
            this.btnEdit.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnEdit.LargeGlyph")));
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnDetails
            // 
            this.btnDetails.Caption = "Görüntüle";
            this.btnDetails.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDetails.Glyph")));
            this.btnDetails.Id = 5;
            this.btnDetails.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnDetails.LargeGlyph")));
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Yenile";
            this.btnRefresh.Glyph = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Glyph")));
            this.btnRefresh.Id = 6;
            this.btnRefresh.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnRefresh.LargeGlyph")));
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;

            this.AllowTextClipping = false;
            this.ItemLinks.Add(this.btnAddNew);
            this.ItemLinks.Add(this.btnEdit);
            this.ItemLinks.Add(this.btnDetails);
            this.ItemLinks.Add(this.btnDelete);
            this.ItemLinks.Add(this.btnRefresh);
            this.Name = "recordTools";
            this.Text = "Kayıt İşlemleri";
        }

        #endregion
        private DevExpress.XtraBars.BarButtonItem btnAddNew;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.XtraBars.BarButtonItem btnDetails;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
    }
}
