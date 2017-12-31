using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using Pedalon.UI.UserControls;
using Pedalon.UI.Models;
using DevExpress.XtraBars.Ribbon;
using Pedalon.UI.Utils;
using System.IO;

namespace Pedalon.UI.Views
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        string[] pages = { "members", "fees", "spendings", "donations", "acts", "todos", "tools" };

        CustomGridControl<Member> memberList;
        CustomGridControl<Fee> feeList;
        CustomGridControl<Spending> spendingList;
        CustomGridControl<Donation> donationList;
        CustomGridControl<Act> actList;
        CustomGridControl<Todo> todoList;
        CustomGridControl<Place> placesList;
        public MainForm()
        {
            InitializeComponent();
            membersPage.Controls.Add(memberList = new CustomGridControl<Member>(false));
        }

        private void anamenu_SelectedPageChanged(object sender, EventArgs e)
        {
            try
            {
                RibbonControl ribbon = sender as RibbonControl;
                content.SelectedPageIndex = pages.ToList().IndexOf(ribbon.SelectedPage.Tag.ToString());
                switch (anamenu.SelectedPage.PageIndex)
                {
                    case 0:
                        membersPage.Controls.Clear();
                        membersPage.Controls.Add(memberList = new CustomGridControl<Member>(false));
                        break;
                    case 1:
                        feesPage.Controls.Clear();
                        feesPage.Controls.Add(feeList = new CustomGridControl<Fee>());
                        break;
                    case 2:
                        spendingsPage.Controls.Clear();
                        spendingsPage.Controls.Add(spendingList = new CustomGridControl<Spending>());
                        break;
                    case 3:
                        donationsPage.Controls.Clear();
                        donationsPage.Controls.Add(donationList = new CustomGridControl<Donation>());
                        break;
                    case 4:
                        actsPage.Controls.Clear();
                        actsPage.Controls.Add(actList = new CustomGridControl<Act>());
                        break;
                    case 5:
                        todosPage.Controls.Clear();
                        todosPage.Controls.Add(todoList = new CustomGridControl<Todo>());
                        break;
                    default:
                        break;
                }
            }
            catch (Exception)
            {

            }
        }

        #region Members Page
        private void rpgMemberRecords_AddButtonClick(object sender, EventArgs e)
        {
            MemberForm memberDialog = new MemberForm();
            if (memberDialog.ShowDialog() == DialogResult.OK && memberDialog.Member != null)
            {
                List<Bike> bikes = new List<Bike>();
                foreach (Bike bike in memberDialog.Member.Bikes)
                {
                    long id = Service<Bike>.AddOrUpdate(bike);
                    bike.Id = id;
                    bikes.Add(bike);
                }
                memberDialog.Member.Bikes = bikes;
                Service<Member>.AddOrUpdate(memberDialog.Member);

                memberList.bindingSource.DataSource = Service<Member>.toBindingList;
                memberList.items.BestFitColumns();
            }
        }

        private void rpgMemberRecords_EditButtonClick(object sender, EventArgs e)
        {
            int index = memberList.items.FocusedRowHandle;
            if (index != -1 && memberList.items.RowCount > 0)
            {
                Member entity = (Member)memberList.items.GetRow(index);
                MemberForm memberDialog = new MemberForm(entity);
                if (memberDialog.ShowDialog() == DialogResult.OK && memberDialog.Member != null)
                {
                    List<Bike> bikes = new List<Bike>();
                    foreach (Bike bike in memberDialog.Member.Bikes)
                    {
                        long id = Service<Bike>.AddOrUpdate(bike);
                        bike.Id = id;
                        bikes.Add(bike);
                    }
                    memberDialog.Member.Bikes = bikes;
                    Service<Member>.AddOrUpdate(memberDialog.Member);

                    memberList.bindingSource.DataSource = Service<Member>.toBindingList;
                    memberList.items.BestFitColumns();
                }
            }
        }

        private void rpgMemberRecords_DetailsButtonClick(object sender, EventArgs e)
        {
            int index = memberList.items.FocusedRowHandle;
            if (index != -1 && memberList.items.RowCount > 0)
            {
                Member entity = (Member)memberList.items.GetRow(index);
                MemberForm memberDialog = new MemberForm(entity, true);
                memberDialog.ShowDialog();
            }
        }

        private void rpgMemberRecords_DeleteButtonClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bu kaydı silmek istediğinize emin misiniz? İşlem geri çevrilemez.", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int index = memberList.items.FocusedRowHandle;
                if (index != -1 && memberList.items.RowCount > 0)
                {
                    Member entity = (Member)memberList.items.GetRow(index);
                    Service<Member>.Delete(entity);
                    memberList.items.DeleteRow(memberList.items.FocusedRowHandle);
                }
            }
        }

        private void rpgMemberRecords_RefreshButtonClick(object sender, EventArgs e)
        {
            memberList.bindingSource.DataSource = Service<Member>.toBindingList;
            memberList.items.BestFitColumns();
        }

        private void rpgMemberExTools_PreviewButtonClick(object sender, EventArgs e)
        {
            memberList.itemGrid.ShowPrintPreview();
        }

        private void rpgMemberExTools_PrintButtonClick(object sender, EventArgs e)
        {
            memberList.itemGrid.PrintDialog();
        }

        private void rpgMemberExTools_ExportToExcelButtonClick(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = string.Format("Kaydedeceğiniz Dosya Adını Yazınız");
            sfd.InitialDirectory = Properties.Settings.Default.ExportInitialDir;
            sfd.Filter = "Excel Dosyası (*.xls)|*.xls";
            if (sfd.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(sfd.FileName))
            {
                Properties.Settings.Default.ExportInitialDir = Path.GetDirectoryName(sfd.FileName);
                Properties.Settings.Default.Save();
                memberList.items.ExportToXls(sfd.FileName);
            }
        }

        private void rpgMemberExTools_ExportToPDFButtonClick(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = string.Format("Kaydedeceğiniz Dosya Adını Yazınız");
            sfd.InitialDirectory = Properties.Settings.Default.ExportInitialDir;
            sfd.Filter = "PDF Dosyası (*.pdf)|*.pdf";
            if (sfd.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(sfd.FileName))
            {
                Properties.Settings.Default.ExportInitialDir = Path.GetDirectoryName(sfd.FileName);
                Properties.Settings.Default.Save();
                memberList.items.ExportToPdf(sfd.FileName);
            }
        }
        #endregion

        #region Activities
        private void rpgActRecs_AddButtonClick(object sender, EventArgs e)
        {
            ActForm actDialog = new ActForm();
            if (actDialog.ShowDialog() == DialogResult.OK && actDialog.Act != null)
            {
                Service<Act>.AddOrUpdate(actDialog.Act);
                actList.bindingSource.DataSource = Service<Act>.toBindingList;
                actList.items.BestFitColumns();
            }
        }

        private void rpgActRecs_DeleteButtonClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bu kaydı silmek istediğinize emin misiniz? İşlem geri çevrilemez.", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int index = actList.items.FocusedRowHandle;
                if (index != -1 && actList.items.RowCount > 0)
                {
                    Act entity = (Act)actList.items.GetRow(index);
                    Service<Act>.Delete(entity);
                    actList.items.DeleteRow(actList.items.FocusedRowHandle);
                }
            }
        }

        private void rpgActRecs_DetailsButtonClick(object sender, EventArgs e)
        {
            int index = actList.items.FocusedRowHandle;
            if (index != -1 && actList.items.RowCount > 0)
            {
                Act entity = (Act)actList.items.GetRow(index);
                ActForm actDialog = new ActForm(entity, true);
                actDialog.ShowDialog();
            }
        }

        private void rpgActRecs_EditButtonClick(object sender, EventArgs e)
        {
            int index = actList.items.FocusedRowHandle;
            if (index != -1 && actList.items.RowCount > 0)
            {
                Act entity = (Act)actList.items.GetRow(index);
                ActForm actDialog = new ActForm(entity);
                if (actDialog.ShowDialog() == DialogResult.OK && actDialog.Act != null)
                {
                    Service<Act>.AddOrUpdate(actDialog.Act);

                    actList.bindingSource.DataSource = Service<Act>.toBindingList;
                    actList.items.BestFitColumns();
                }
            }
        }

        private void rpgActRecs_RefreshButtonClick(object sender, EventArgs e)
        {
            actList.bindingSource.DataSource = Service<Act>.toBindingList;
            actList.items.BestFitColumns();
        }

        private void rpgActExTools_PreviewButtonClick(object sender, EventArgs e)
        {
            actList.itemGrid.ShowPrintPreview();
        }

        private void rpgActExTools_PrintButtonClick(object sender, EventArgs e)
        {
            actList.itemGrid.PrintDialog();
        }

        private void rpgActExTools_ExportToExcelButtonClick(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = string.Format("Kaydedeceğiniz Dosya Adını Yazınız");
            sfd.InitialDirectory = Properties.Settings.Default.ExportInitialDir;
            sfd.Filter = "Excel Dosyası (*.xls)|*.xls";
            if (sfd.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(sfd.FileName))
            {
                Properties.Settings.Default.ExportInitialDir = Path.GetDirectoryName(sfd.FileName);
                Properties.Settings.Default.Save();
                actList.items.ExportToXls(sfd.FileName);
            }
        }

        private void rpgActExTools_ExportToPDFButtonClick(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = string.Format("Kaydedeceğiniz Dosya Adını Yazınız");
            sfd.InitialDirectory = Properties.Settings.Default.ExportInitialDir;
            sfd.Filter = "PDF Dosyası (*.pdf)|*.pdf";
            if (sfd.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(sfd.FileName))
            {
                Properties.Settings.Default.ExportInitialDir = Path.GetDirectoryName(sfd.FileName);
                Properties.Settings.Default.Save();
                actList.items.ExportToPdf(sfd.FileName);
            }
        }

        private void btnDestinations_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            placesPage.Controls.Clear();
            placesPage.Controls.Add(placesList = new CustomGridControl<Place>());
            content.SelectedPageIndex = 7;
        }

        private void btnActList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            content.SelectedPageIndex = 4;
        }
        #endregion

        private void btnFeeStatus_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new FeeStatusForm().ShowDialog();
        }

        private void btnGetMemberList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string fname = Utilities.OpenFile();
            if (fname != null)
                DataGenerator.GetMembers(fname);
        }

        private void btnGetFeeList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string fname = Utilities.OpenFile();
            if (fname != null)
                DataGenerator.GetFees(fname);
        }
    }
}