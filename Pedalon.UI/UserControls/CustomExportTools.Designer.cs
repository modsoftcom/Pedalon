using Pedalon.UI.Properties;
using Pedalon.UI.Views;

namespace Pedalon.UI.UserControls
{
    partial class CustomExportTools
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

            this.btnPreview = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrint = new DevExpress.XtraBars.BarButtonItem();
            this.btnExportToExcel = new DevExpress.XtraBars.BarButtonItem();
            this.btnExportToPDF = new DevExpress.XtraBars.BarButtonItem();

            // 
            // btnAddNew
            // 
            this.btnPreview.Caption = "Çıktı Önizleme";
            this.btnPreview.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.Glyph")));
            this.btnPreview.Id = 2;
            this.btnPreview.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.LargeGlyph")));
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnDelete
            // 
            this.btnPrint.Caption = "Çıktı Al";
            this.btnPrint.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.Glyph")));
            this.btnPrint.Id = 3;
            this.btnPrint.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.LargeGlyph")));
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnEdit
            // 
            this.btnExportToExcel.Caption = "Excel'e Aktar";
            this.btnExportToExcel.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem8.Glyph")));
            this.btnExportToExcel.Id = 4;
            this.btnExportToExcel.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem8.LargeGlyph")));
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnDetails
            // 
            this.btnExportToPDF.Caption = "PDF'e Aktar";
            this.btnExportToPDF.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem9.Glyph")));
            this.btnExportToPDF.Id = 5;
            this.btnExportToPDF.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem9.LargeGlyph")));
            this.btnExportToPDF.Name = "btnExportToPDF";
            this.btnExportToPDF.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;

            this.AllowTextClipping = false;
            this.ItemLinks.Add(this.btnPreview);
            this.ItemLinks.Add(this.btnPrint);
            this.ItemLinks.Add(this.btnExportToExcel);
            this.ItemLinks.Add(this.btnExportToPDF);
            this.Name = "recordTools";
            this.Text = "Çıktı İşlemleri";
        }

        #endregion
        private DevExpress.XtraBars.BarButtonItem btnPreview;
        private DevExpress.XtraBars.BarButtonItem btnPrint;
        private DevExpress.XtraBars.BarButtonItem btnExportToExcel;
        private DevExpress.XtraBars.BarButtonItem btnExportToPDF;
    }
}
