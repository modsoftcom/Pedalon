using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Docking2010;

namespace Pedalon.UI.UserControls
{
    public partial class CustomExportTools : DevExpress.XtraBars.Ribbon.RibbonPageGroup
    {
        public CustomExportTools()
        {
            InitializeComponent();
            btnPreview.ItemClick += BtnPreview_ItemClick; ;
            btnPrint.ItemClick += BtnPrint_ItemClick; ;
            btnExportToExcel.ItemClick += BtnExportToExcel_ItemClick; ;
            btnExportToPDF.ItemClick += BtnExportToPDF_ItemClick;
        }

        private void BtnPreview_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PreviewButtonClick_Click(sender, e);
        }

        private void BtnPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PrintButtonClick_Click(sender, e);
        }

        private void BtnExportToExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExportToExcelButtonClick_Click(sender, e);
        }

        private void BtnExportToPDF_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExportToPDFButtonClick_Click(sender, e);
        }

        public event EventHandler PreviewButtonClick;
        protected void PreviewButtonClick_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.PreviewButtonClick != null)
                this.PreviewButtonClick(this, e);
        }

        public event EventHandler PrintButtonClick;
        protected void PrintButtonClick_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.PrintButtonClick != null)
                this.PrintButtonClick(this, e);
        }

        public event EventHandler ExportToExcelButtonClick;
        protected void ExportToExcelButtonClick_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.ExportToExcelButtonClick != null)
                this.ExportToExcelButtonClick(this, e);
        }

        public event EventHandler ExportToPDFButtonClick;
        protected void ExportToPDFButtonClick_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.ExportToPDFButtonClick != null)
                this.ExportToPDFButtonClick(this, e);
        }
    }
}
