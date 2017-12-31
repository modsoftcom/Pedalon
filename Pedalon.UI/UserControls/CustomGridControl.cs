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
using Pedalon.UI.Utils;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid;
using Pedalon.UI.Models;

namespace Pedalon.UI.UserControls
{
    public partial class CustomGridControl<T> : DevExpress.XtraEditors.XtraUserControl
    {
        public T Entity { get; set; }
        public List<T> Entities { get; set; }
        DevExpress.XtraEditors.Repository.RepositoryItemComboBox genderCombo;
        DevExpress.XtraEditors.Repository.RepositoryItemComboBox nationalityCombo;
        DevExpress.XtraEditors.Repository.RepositoryItemComboBox bloodCombo;
        DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit bikesCombo;
        DevExpress.XtraEditors.Repository.RepositoryItemComboBox membersCombo;
        DevExpress.XtraEditors.Repository.RepositoryItemComboBox feeType;
        DevExpress.XtraEditors.Repository.RepositoryItemComboBox donationType;
        DevExpress.XtraEditors.Repository.RepositoryItemComboBox placesCombo;

        public CustomGridControl(bool ColumnAutoWidth = true)
        {
            this.Tag = typeof(T).Name;
            InitializeComponent();
            items.OptionsView.ColumnAutoWidth = ColumnAutoWidth;
            if (DesignMode == false)
                this.Dock = System.Windows.Forms.DockStyle.Fill;
            bindingSource.DataSource = Service<T>.toBindingList;
            items.BestFitColumns();
            items.FocusedRowHandle = -1;
            generateCombos();
            setViews();
        }

        private void setViews()
        {
            switch (typeof(T).Name)
            {
                case "Member":
                    items.OptionsBehavior.Editable = false;
                    break;
                case "Fee":
                    items.Columns[0].ColumnEdit = membersCombo;
                    items.Columns[1].ColumnEdit = feeType;
                    break;
                case "Spending":
                    items.Columns[0].ColumnEdit = membersCombo;
                    break;
                case "Donation":
                    items.Columns[1].ColumnEdit = membersCombo;
                    items.Columns[2].ColumnEdit = donationType;
                    break;
                case "Act":
                    items.OptionsBehavior.Editable = false;
                    break;
                case "Todo":
                    //items.Columns[5].ColumnEdit = placesCombo;
                    //items.Columns[7].ColumnEdit = usersCombo;
                    //items.Columns[8].ColumnEdit = usersCombo;
                    break;
                default:
                    break;
            }
        }

        private void generateCombos()
        {
            genderCombo =  new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            genderCombo.AutoHeight = false;
            genderCombo.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            genderCombo.Name = "genderCombo";
            genderCombo.NullText = "Seçiniz";
            genderCombo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;


            nationalityCombo = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            nationalityCombo.AutoHeight = false;
            nationalityCombo.Items.AddRange(new object[] {
            "TC",
            "Diğer"});
            nationalityCombo.Name = "nationalityCombo";
            nationalityCombo.NullText = "Seçiniz";
            nationalityCombo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;


            bloodCombo = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            bloodCombo.AutoHeight = false;
            bloodCombo.Items.AddRange(new object[] {
            "A Rh (+)",
            "A Rh (-)",
            "B Rh (+)",
            "B Rh (-)",
            "AB Rh (+)",
            "AB Rh (-)",
            "0 Rh (+)",
            "0 Rh (-)",});
            bloodCombo.Name = "bloodCombo";
            bloodCombo.NullText = "Seçiniz";
            bloodCombo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;

            bikesCombo = new DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit();
            bikesCombo.AutoHeight = false;
            bikesCombo.DataSource = Service<Bike>.SelectAll();
            bikesCombo.Name = "bikesCombo";
            bikesCombo.NullText = "Seçiniz";
            bikesCombo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;

            feeType = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            feeType.AutoHeight = false;
            feeType.Items.AddRange(new object[] {
            "Aylık Ödeme",
            "Giriş Aidatı"});
            feeType.Name = "feeType";
            feeType.NullText = "Seçiniz";
            feeType.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;

            membersCombo = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            membersCombo.AutoHeight = false;
            membersCombo.Items.AddRange(Service<Member>.SelectAll());
            membersCombo.Name = "users";
            membersCombo.NullText = "Seçiniz";
            membersCombo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;

            donationType = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            donationType.AutoHeight = false;
            donationType.Items.AddRange(new object[] {
            "Para",
            "Mal",
            "Hizmet"});
            donationType.Name = "donationType";
            donationType.NullText = "Seçiniz";
            donationType.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            

            placesCombo = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            placesCombo.AutoHeight = false;
            placesCombo.Items.AddRange(Service<Place>.SelectAll());
            placesCombo.Name = "users";
            placesCombo.NullText = "Seçiniz";
            placesCombo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
        }

        public void items_RowUpdated(object sender, RowObjectEventArgs e)
        {
            try
            {
                T Entity = (T)e.Row;
                Service<T>.AddOrUpdate(Entity);
                items.RefreshData();
                items.BestFitColumns();
            }
            catch (Exception)
            {

            }
        }

        private void items_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            Entities = new List<T>();
            if (items.SelectedRowsCount > 0)
            {
                Entity = (T)items.GetFocusedRow();
                foreach (int i in items.GetSelectedRows())
                {
                    Entities.Add((T)items.GetRow(i));
                }
            }
        }
        
    }
}
