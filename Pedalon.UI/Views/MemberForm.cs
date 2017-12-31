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
using Pedalon.UI.Models;

namespace Pedalon.UI.Views
{
    public partial class MemberForm : DevExpress.XtraEditors.XtraForm
    {
        public Member Member;
        public MemberForm()
        {
            InitializeComponent();
            Member = new Member();
        }
        public MemberForm(Member member, bool read = false)
        {
            this.Member = member;
            InitializeComponent();

            txtCitizenNumber.Text = Member.CitizenNumber;
            txtName.Text = Member.Name;
            txtLastname.Text = Member.Lastname;
            txtBirth.DateTime = Member.Birth;
            txtGender.EditValue = Member.Gender;
            txtBloodType.EditValue = Member.BloodType;
            txtMotherName.Text = Member.MotherName;
            txtNationality.EditValue = Member.Nationality;
            txtJob.Text = Member.Job;
            txtMail.Text = Member.Mail;
            txtPhone.Text = Member.Phone;
            txtAddress.Text = Member.Address;
            txtApplicationDate.DateTime = Member.ApplicationDate;
            txtApprovalDate.DateTime = Member.ApprovalDate;
            txtEntranceFee.Text = Member.EntranceFee.ToString();
            txtMonthlyFee.Text = Member.MonthlyFee.ToString();

            txtCitizenNumber.ReadOnly = read;
            txtName.ReadOnly = read;
            txtLastname.ReadOnly = read;
            txtBirth.ReadOnly = read;
            txtGender.ReadOnly = read;
            txtBloodType.ReadOnly = read;
            txtMotherName.ReadOnly = read;
            txtNationality.ReadOnly = read;
            txtJob.ReadOnly = read;
            txtMail.ReadOnly = read;
            txtPhone.ReadOnly = read;
            txtAddress.ReadOnly = read;
            txtApplicationDate.ReadOnly = read;
            txtApprovalDate.ReadOnly = read;
            txtEntranceFee.ReadOnly = read;
            txtMonthlyFee.ReadOnly = read;
            txtBikeBrand.ReadOnly = read;
            txtBikeModel.ReadOnly = read;
            txtBikeSerial.ReadOnly = read;
            txtBikeColor.ReadOnly = read;
            bikeList.Enabled = !read;
            if (read)
            {
                btnSave.Text = "TAMAM";
            }

            bikeList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            foreach (Bike bike in Member.Bikes)
            {
                ListViewItem item = new ListViewItem();
                item.Text = bike.Brand;
                item.SubItems.Add(bike.Model);
                item.SubItems.Add(bike.Serial);
                item.SubItems.Add(bike.Color.ToString());
                item.Tag = bike;
                bikeList.Items.Add(item);
                bikeList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Member.CitizenNumber = txtCitizenNumber.Text;
            Member.Name = txtName.Text;
            Member.Lastname = txtLastname.Text;
            Member.Birth = txtBirth.DateTime;
            Member.Gender = txtGender.EditValue.ToString();
            Member.BloodType = txtBloodType.EditValue.ToString();
            Member.MotherName = txtMotherName.Text;
            Member.Nationality = txtNationality.EditValue.ToString();
            Member.Job = txtJob.Text;
            Member.Mail = txtMail.Text;
            Member.Phone = txtPhone.Text;
            Member.Address = txtAddress.Text;
            Member.ApplicationDate = txtApplicationDate.DateTime;
            Member.ApprovalDate = txtApprovalDate.DateTime;
            Member.EntranceFee = Convert.ToDecimal(txtEntranceFee.EditValue);
            Member.MonthlyFee = Convert.ToDecimal(txtMonthlyFee.EditValue);
            Close();
        }

        private void btnAddBike_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();
            Bike bike = new Bike();
            bike.Brand = item.Text = txtBikeBrand.Text;
            item.SubItems.Add(bike.Model = txtBikeModel.Text);
            item.SubItems.Add(bike.Serial = txtBikeSerial.Text);
            item.SubItems.Add((bike.Color = txtBikeColor.Color.ToArgb()).ToString());
            Member.Bikes.Add(bike);
            item.Tag = bike;
            bikeList.Items.Add(item);
            txtBikeBrand.Text = "";
            txtBikeModel.Text = "";
            txtBikeSerial.Text = "";
            txtBikeColor.Color = Color.White;
            bikeList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void bikeList_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem item = bikeList.SelectedItems[0];
            Bike bike = item.Tag as Bike;
            txtBikeBrand.Text = bike.Brand;
            txtBikeModel.Text = bike.Model;
            txtBikeSerial.Text = bike.Serial;
            txtBikeColor.Color = Color.FromArgb(bike.Color);
            Member.Bikes.Remove(bike);
            bikeList.SelectedItems[0].Remove();
            if (bikeList.Items.Count > 0)
                bikeList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            else
                bikeList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
    }
}