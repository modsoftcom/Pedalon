using Pedalon.UI.Models;
using Pedalon.UI.UserControls;

namespace Pedalon.UI.Views
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.anamenu = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnAddNew = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnDetails = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.btnDestinations = new DevExpress.XtraBars.BarButtonItem();
            this.btnActList = new DevExpress.XtraBars.BarButtonItem();
            this.btnFeeStatus = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgMemberRecords = new Pedalon.UI.UserControls.CustomRecordTools();
            this.rpgMemberExTools = new Pedalon.UI.UserControls.CustomExportTools();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgFeeRecs = new Pedalon.UI.UserControls.CustomRecordTools();
            this.rpgFeeExTools = new Pedalon.UI.UserControls.CustomExportTools();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgSpendingRecs = new Pedalon.UI.UserControls.CustomRecordTools();
            this.rpgSpendingExTools = new Pedalon.UI.UserControls.CustomExportTools();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgDonationRecs = new Pedalon.UI.UserControls.CustomRecordTools();
            this.rpgDonationExTools = new Pedalon.UI.UserControls.CustomExportTools();
            this.ribbonPage5 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgActRecs = new Pedalon.UI.UserControls.CustomRecordTools();
            this.rpgActExTools = new Pedalon.UI.UserControls.CustomExportTools();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage6 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgTodoRecs = new Pedalon.UI.UserControls.CustomRecordTools();
            this.rpgTodoExTools = new Pedalon.UI.UserControls.CustomExportTools();
            this.ribbonPage7 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.recordTools = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.content = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.membersPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.feesPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.spendingsPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.donationsPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.actsPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.todosPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.toolsPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.placesPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnGetMemberList = new DevExpress.XtraBars.BarButtonItem();
            this.btnGetFeeList = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.anamenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.content)).BeginInit();
            this.content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // anamenu
            // 
            this.anamenu.ExpandCollapseItem.Id = 0;
            this.anamenu.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.anamenu.ExpandCollapseItem,
            this.btnAddNew,
            this.btnDelete,
            this.btnEdit,
            this.btnDetails,
            this.btnRefresh,
            this.barButtonItem6,
            this.barButtonItem7,
            this.barButtonItem8,
            this.barButtonItem9,
            this.btnDestinations,
            this.btnActList,
            this.btnFeeStatus,
            this.btnGetMemberList,
            this.btnGetFeeList});
            this.anamenu.Location = new System.Drawing.Point(0, 0);
            this.anamenu.MaxItemId = 16;
            this.anamenu.Name = "anamenu";
            this.anamenu.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3,
            this.ribbonPage4,
            this.ribbonPage5,
            this.ribbonPage6,
            this.ribbonPage7});
            this.anamenu.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.anamenu.Size = new System.Drawing.Size(735, 149);
            this.anamenu.StatusBar = this.ribbonStatusBar1;
            this.anamenu.SelectedPageChanged += new System.EventHandler(this.anamenu_SelectedPageChanged);
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
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Önizleme";
            this.barButtonItem6.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.Glyph")));
            this.barButtonItem6.Id = 7;
            this.barButtonItem6.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.LargeGlyph")));
            this.barButtonItem6.Name = "barButtonItem6";
            this.barButtonItem6.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Yazdır";
            this.barButtonItem7.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.Glyph")));
            this.barButtonItem7.Id = 8;
            this.barButtonItem7.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.LargeGlyph")));
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Excel\'e Aktar";
            this.barButtonItem8.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem8.Glyph")));
            this.barButtonItem8.Id = 9;
            this.barButtonItem8.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem8.LargeGlyph")));
            this.barButtonItem8.Name = "barButtonItem8";
            this.barButtonItem8.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "PDF\'e Aktar";
            this.barButtonItem9.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem9.Glyph")));
            this.barButtonItem9.Id = 10;
            this.barButtonItem9.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem9.LargeGlyph")));
            this.barButtonItem9.Name = "barButtonItem9";
            this.barButtonItem9.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnDestinations
            // 
            this.btnDestinations.Caption = "Durak Listesi";
            this.btnDestinations.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDestinations.Glyph")));
            this.btnDestinations.Id = 11;
            this.btnDestinations.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnDestinations.LargeGlyph")));
            this.btnDestinations.Name = "btnDestinations";
            this.btnDestinations.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDestinations.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDestinations_ItemClick);
            // 
            // btnActList
            // 
            this.btnActList.Caption = "Etkinlik Listesi";
            this.btnActList.Glyph = ((System.Drawing.Image)(resources.GetObject("btnActList.Glyph")));
            this.btnActList.Id = 12;
            this.btnActList.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnActList.LargeGlyph")));
            this.btnActList.Name = "btnActList";
            this.btnActList.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnActList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnActList_ItemClick);
            // 
            // btnFeeStatus
            // 
            this.btnFeeStatus.Caption = "Son Durum";
            this.btnFeeStatus.Glyph = ((System.Drawing.Image)(resources.GetObject("btnFeeStatus.Glyph")));
            this.btnFeeStatus.Id = 13;
            this.btnFeeStatus.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnFeeStatus.LargeGlyph")));
            this.btnFeeStatus.Name = "btnFeeStatus";
            this.btnFeeStatus.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnFeeStatus.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFeeStatus_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgMemberRecords,
            this.rpgMemberExTools});
            this.ribbonPage1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage1.Image")));
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Tag = "members";
            this.ribbonPage1.Text = "Üyeler";
            // 
            // rpgMemberRecords
            // 
            this.rpgMemberRecords.AllowTextClipping = false;
            this.rpgMemberRecords.Name = "rpgMemberRecords";
            this.rpgMemberRecords.Text = "Kayıt İşlemleri";
            this.rpgMemberRecords.AddButtonClick += new System.EventHandler(this.rpgMemberRecords_AddButtonClick);
            this.rpgMemberRecords.DeleteButtonClick += new System.EventHandler(this.rpgMemberRecords_DeleteButtonClick);
            this.rpgMemberRecords.EditButtonClick += new System.EventHandler(this.rpgMemberRecords_EditButtonClick);
            this.rpgMemberRecords.RefreshButtonClick += new System.EventHandler(this.rpgMemberRecords_RefreshButtonClick);
            this.rpgMemberRecords.DetailsButtonClick += new System.EventHandler(this.rpgMemberRecords_DetailsButtonClick);
            // 
            // rpgMemberExTools
            // 
            this.rpgMemberExTools.AllowTextClipping = false;
            this.rpgMemberExTools.Name = "rpgMemberExTools";
            this.rpgMemberExTools.Text = "Çıktı İşlemleri";
            this.rpgMemberExTools.PreviewButtonClick += new System.EventHandler(this.rpgMemberExTools_PreviewButtonClick);
            this.rpgMemberExTools.PrintButtonClick += new System.EventHandler(this.rpgMemberExTools_PrintButtonClick);
            this.rpgMemberExTools.ExportToExcelButtonClick += new System.EventHandler(this.rpgMemberExTools_ExportToExcelButtonClick);
            this.rpgMemberExTools.ExportToPDFButtonClick += new System.EventHandler(this.rpgMemberExTools_ExportToPDFButtonClick);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgFeeRecs,
            this.rpgFeeExTools,
            this.ribbonPageGroup2});
            this.ribbonPage2.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage2.Image")));
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Tag = "fees";
            this.ribbonPage2.Text = "Aidatlar";
            // 
            // rpgFeeRecs
            // 
            this.rpgFeeRecs.AllowTextClipping = false;
            this.rpgFeeRecs.Name = "rpgFeeRecs";
            this.rpgFeeRecs.Text = "Kayıt İşlemleri";
            // 
            // rpgFeeExTools
            // 
            this.rpgFeeExTools.AllowTextClipping = false;
            this.rpgFeeExTools.Name = "rpgFeeExTools";
            this.rpgFeeExTools.Text = "Çıktı İşlemleri";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.btnFeeStatus);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Raporlar";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgSpendingRecs,
            this.rpgSpendingExTools});
            this.ribbonPage3.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage3.Image")));
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Tag = "spendings";
            this.ribbonPage3.Text = "Harcamalar";
            // 
            // rpgSpendingRecs
            // 
            this.rpgSpendingRecs.AllowTextClipping = false;
            this.rpgSpendingRecs.Name = "rpgSpendingRecs";
            this.rpgSpendingRecs.Text = "Kayıt İşlemleri";
            // 
            // rpgSpendingExTools
            // 
            this.rpgSpendingExTools.AllowTextClipping = false;
            this.rpgSpendingExTools.Name = "rpgSpendingExTools";
            this.rpgSpendingExTools.Text = "Çıktı İşlemleri";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgDonationRecs,
            this.rpgDonationExTools});
            this.ribbonPage4.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage4.Image")));
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Tag = "donations";
            this.ribbonPage4.Text = "Bağışlar";
            // 
            // rpgDonationRecs
            // 
            this.rpgDonationRecs.AllowTextClipping = false;
            this.rpgDonationRecs.Name = "rpgDonationRecs";
            this.rpgDonationRecs.Text = "Kayıt İşlemleri";
            // 
            // rpgDonationExTools
            // 
            this.rpgDonationExTools.AllowTextClipping = false;
            this.rpgDonationExTools.Name = "rpgDonationExTools";
            this.rpgDonationExTools.Text = "Çıktı İşlemleri";
            // 
            // ribbonPage5
            // 
            this.ribbonPage5.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgActRecs,
            this.rpgActExTools,
            this.ribbonPageGroup1});
            this.ribbonPage5.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage5.Image")));
            this.ribbonPage5.Name = "ribbonPage5";
            this.ribbonPage5.Tag = "acts";
            this.ribbonPage5.Text = "Etkinlikler";
            // 
            // rpgActRecs
            // 
            this.rpgActRecs.AllowTextClipping = false;
            this.rpgActRecs.Name = "rpgActRecs";
            this.rpgActRecs.Text = "Kayıt İşlemleri";
            this.rpgActRecs.AddButtonClick += new System.EventHandler(this.rpgActRecs_AddButtonClick);
            this.rpgActRecs.DeleteButtonClick += new System.EventHandler(this.rpgActRecs_DeleteButtonClick);
            this.rpgActRecs.EditButtonClick += new System.EventHandler(this.rpgActRecs_EditButtonClick);
            this.rpgActRecs.RefreshButtonClick += new System.EventHandler(this.rpgActRecs_RefreshButtonClick);
            this.rpgActRecs.DetailsButtonClick += new System.EventHandler(this.rpgActRecs_DetailsButtonClick);
            // 
            // rpgActExTools
            // 
            this.rpgActExTools.AllowTextClipping = false;
            this.rpgActExTools.Name = "rpgActExTools";
            this.rpgActExTools.Text = "Çıktı İşlemleri";
            this.rpgActExTools.PreviewButtonClick += new System.EventHandler(this.rpgActExTools_PreviewButtonClick);
            this.rpgActExTools.PrintButtonClick += new System.EventHandler(this.rpgActExTools_PrintButtonClick);
            this.rpgActExTools.ExportToExcelButtonClick += new System.EventHandler(this.rpgActExTools_ExportToExcelButtonClick);
            this.rpgActExTools.ExportToPDFButtonClick += new System.EventHandler(this.rpgActExTools_ExportToPDFButtonClick);
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDestinations);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnActList);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Gezinme";
            // 
            // ribbonPage6
            // 
            this.ribbonPage6.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgTodoRecs,
            this.rpgTodoExTools});
            this.ribbonPage6.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage6.Image")));
            this.ribbonPage6.Name = "ribbonPage6";
            this.ribbonPage6.Tag = "todos";
            this.ribbonPage6.Text = "Yapılacak İşler";
            // 
            // rpgTodoRecs
            // 
            this.rpgTodoRecs.AllowTextClipping = false;
            this.rpgTodoRecs.Name = "rpgTodoRecs";
            this.rpgTodoRecs.Text = "Kayıt İşlemleri";
            // 
            // rpgTodoExTools
            // 
            this.rpgTodoExTools.AllowTextClipping = false;
            this.rpgTodoExTools.Name = "rpgTodoExTools";
            this.rpgTodoExTools.Text = "Çıktı İşlemleri";
            // 
            // ribbonPage7
            // 
            this.ribbonPage7.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage7.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage7.Image")));
            this.ribbonPage7.Name = "ribbonPage7";
            this.ribbonPage7.Tag = "tools";
            this.ribbonPage7.Text = "Araçlar";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 457);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.anamenu;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(735, 21);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // recordTools
            // 
            this.recordTools.AllowTextClipping = false;
            this.recordTools.ItemLinks.Add(this.btnAddNew);
            this.recordTools.ItemLinks.Add(this.btnDelete);
            this.recordTools.ItemLinks.Add(this.btnEdit);
            this.recordTools.ItemLinks.Add(this.btnDetails);
            this.recordTools.ItemLinks.Add(this.btnRefresh);
            this.recordTools.Name = "recordTools";
            this.recordTools.Text = "Kayıt İşlemleri";
            // 
            // content
            // 
            this.content.Controls.Add(this.membersPage);
            this.content.Controls.Add(this.feesPage);
            this.content.Controls.Add(this.spendingsPage);
            this.content.Controls.Add(this.donationsPage);
            this.content.Controls.Add(this.actsPage);
            this.content.Controls.Add(this.todosPage);
            this.content.Controls.Add(this.toolsPage);
            this.content.Controls.Add(this.placesPage);
            this.content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content.Location = new System.Drawing.Point(0, 149);
            this.content.Name = "content";
            this.content.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.membersPage,
            this.feesPage,
            this.spendingsPage,
            this.donationsPage,
            this.actsPage,
            this.todosPage,
            this.toolsPage,
            this.placesPage});
            this.content.SelectedPage = this.membersPage;
            this.content.Size = new System.Drawing.Size(735, 308);
            this.content.TabIndex = 2;
            this.content.Text = "navigationFrame1";
            this.content.TransitionAnimationProperties.FrameCount = 500;
            this.content.TransitionType = DevExpress.Utils.Animation.Transitions.Push;
            // 
            // membersPage
            // 
            this.membersPage.Name = "membersPage";
            this.membersPage.Size = new System.Drawing.Size(735, 308);
            // 
            // feesPage
            // 
            this.feesPage.Name = "feesPage";
            this.feesPage.Size = new System.Drawing.Size(735, 308);
            // 
            // spendingsPage
            // 
            this.spendingsPage.Name = "spendingsPage";
            this.spendingsPage.Size = new System.Drawing.Size(735, 308);
            // 
            // donationsPage
            // 
            this.donationsPage.Name = "donationsPage";
            this.donationsPage.Size = new System.Drawing.Size(735, 308);
            // 
            // actsPage
            // 
            this.actsPage.Name = "actsPage";
            this.actsPage.Size = new System.Drawing.Size(735, 308);
            // 
            // todosPage
            // 
            this.todosPage.Name = "todosPage";
            this.todosPage.Size = new System.Drawing.Size(735, 308);
            // 
            // toolsPage
            // 
            this.toolsPage.Name = "toolsPage";
            this.toolsPage.Size = new System.Drawing.Size(735, 308);
            // 
            // placesPage
            // 
            this.placesPage.Name = "placesPage";
            this.placesPage.Size = new System.Drawing.Size(735, 308);
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataSource = typeof(Pedalon.UI.Models.Member);
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.AllowTextClipping = false;
            this.ribbonPageGroup3.ItemLinks.Add(this.btnGetMemberList);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnGetFeeList);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Veri Transferi";
            // 
            // btnGetMemberList
            // 
            this.btnGetMemberList.Caption = "Üye Listesini Al";
            this.btnGetMemberList.Glyph = ((System.Drawing.Image)(resources.GetObject("btnGetMemberList.Glyph")));
            this.btnGetMemberList.Id = 14;
            this.btnGetMemberList.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnGetMemberList.LargeGlyph")));
            this.btnGetMemberList.Name = "btnGetMemberList";
            this.btnGetMemberList.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnGetMemberList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGetMemberList_ItemClick);
            // 
            // btnGetFeeList
            // 
            this.btnGetFeeList.Caption = "Aidat Listesini Al";
            this.btnGetFeeList.Glyph = ((System.Drawing.Image)(resources.GetObject("btnGetFeeList.Glyph")));
            this.btnGetFeeList.Id = 15;
            this.btnGetFeeList.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnGetFeeList.LargeGlyph")));
            this.btnGetFeeList.Name = "btnGetFeeList";
            this.btnGetFeeList.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnGetFeeList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGetFeeList_ItemClick);
            // 
            // MainForm
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 478);
            this.Controls.Add(this.content);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.anamenu);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Ribbon = this.anamenu;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "PEDALON BALIKESİR BİSİKLET DERNEĞİ YÖNETİM PANELİ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.anamenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.content)).EndInit();
            this.content.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl anamenu;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage5;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage6;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage7;
        private DevExpress.XtraBars.BarButtonItem btnAddNew;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.XtraBars.BarButtonItem btnDetails;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup recordTools;
        private CustomRecordTools rpgMemberRecords;
        private DevExpress.XtraBars.Navigation.NavigationFrame content;
        private DevExpress.XtraBars.Navigation.NavigationPage membersPage;
        public DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Navigation.NavigationPage feesPage;
        private DevExpress.XtraBars.Navigation.NavigationPage spendingsPage;
        private DevExpress.XtraBars.Navigation.NavigationPage donationsPage;
        private DevExpress.XtraBars.Navigation.NavigationPage actsPage;
        private DevExpress.XtraBars.Navigation.NavigationPage todosPage;
        private DevExpress.XtraBars.Navigation.NavigationPage toolsPage;

        private CustomRecordTools rpgFeeRecs;
        private CustomRecordTools rpgMemberRecs;
        private CustomRecordTools rpgSpendingRecs;
        private CustomRecordTools rpgDonationRecs;
        private CustomRecordTools rpgActRecs;
        private CustomRecordTools rpgTodoRecs;

        private CustomExportTools rpgMemberExTools;
        private CustomExportTools rpgFeeExTools;
        private CustomExportTools rpgSpendingExTools;
        private CustomExportTools rpgDonationExTools;
        private CustomExportTools rpgActExTools;
        private CustomExportTools rpgTodoExTools;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private DevExpress.XtraBars.BarButtonItem btnDestinations;
        private DevExpress.XtraBars.BarButtonItem btnActList;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Navigation.NavigationPage placesPage;
        private DevExpress.XtraBars.BarButtonItem btnFeeStatus;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnGetMemberList;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnGetFeeList;
    }
}