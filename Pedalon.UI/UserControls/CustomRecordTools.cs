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
    public partial class CustomRecordTools : DevExpress.XtraBars.Ribbon.RibbonPageGroup
    {
        public CustomRecordTools()
        {
            InitializeComponent();
            btnAddNew.ItemClick += AddItemClick;
            btnDelete.ItemClick += DeleteItemClick;
            btnEdit.ItemClick += EditItemClick;
            btnRefresh.ItemClick += RefreshItemClick;
            btnDetails.ItemClick += DetailsItemClick;  
        }

        private void DetailsItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DetailsButtonClick_Click(sender, e);
        }

        private void RefreshItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RefreshButtonClick_Click(sender, e);
        }

        private void EditItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditButtonClick_Click(sender, e);
        }

        private void DeleteItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeleteButtonClick_Click(sender, e);
        }

        private void AddItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddButtonClick_Click(sender, e);
        }

        public event EventHandler AddButtonClick;
        protected void AddButtonClick_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.AddButtonClick != null)
                this.AddButtonClick(this, e);
        }

        public event EventHandler DeleteButtonClick;
        protected void DeleteButtonClick_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.DeleteButtonClick != null)
                this.DeleteButtonClick(this, e);
        }

        public event EventHandler EditButtonClick;
        protected void EditButtonClick_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.EditButtonClick != null)
                this.EditButtonClick(this, e);
        }

        public event EventHandler RefreshButtonClick;
        protected void RefreshButtonClick_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.RefreshButtonClick != null)
                this.RefreshButtonClick(this, e);
        }

        public event EventHandler DetailsButtonClick;
        protected void DetailsButtonClick_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.DetailsButtonClick != null)
                this.DetailsButtonClick(this, e);
        }
    }
}
