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
using Pedalon.UI.Utils;
using DevExpress.XtraEditors.Controls;

namespace Pedalon.UI.Views
{
    public partial class ActForm : DevExpress.XtraEditors.XtraForm
    {
        public Act Act;
        public ActForm()
        {
            InitializeComponent();
            Act = new Act();

            cmbPlaces.DataSource = Service<Place>.SelectAll();

            plannerList.Properties.DataSource = joinerList.Properties.DataSource = Service<Member>.SelectAll();

            txtPlannedStart.DateTime = txtStartTime.DateTime = DateTime.Now.AddHours(6);
            txtPlannedFinish.DateTime = txtEndTime.DateTime = DateTime.Now.AddHours(8);
        }

        public ActForm(Act act, bool read = false)
        {
            InitializeComponent();
            Act = act;

            cmbPlaces.DataSource = Service<Place>.SelectAll();
            cmbPlaces.Sorted = true;

            plannerList.Properties.DataSource = joinerList.Properties.DataSource = Service<Member>.SelectAll();

            txtTitle.Text = act.Title;
            txtPlannedStart.DateTime = act.PlannedStartTime;
            txtStartTime.DateTime = act.StartTime;
            txtPlannedFinish.DateTime = act.PlannedFinishTime;
            txtEndTime.DateTime = act.FinishTime;

            txtTitle.ReadOnly = read;
            txtPlannedStart.ReadOnly = read;
            txtStartTime.ReadOnly = read;
            txtPlannedFinish.ReadOnly = read;
            txtEndTime.ReadOnly = read;
            if(read)
            {
                btnSave.DialogResult = DialogResult.Cancel;
                btnSave.Text = "TAMAM";
            }

            foreach (Place place in act.Destinations)
            {
                ListViewItem item = new ListViewItem();
                item.Text = place.Title;
                item.SubItems.Add(place.Province);
                item.Tag = place;
                destinationList.Items.Add(item);
            }
            foreach (CheckedListBoxItem item in plannerList.Properties.Items)
            {
                Member member = (Member)item.Value;
                if (act.Planners.Count(m => m.Id == member.Id) > 0)
                    item.CheckState = CheckState.Checked;
            }
            foreach (CheckedListBoxItem item in joinerList.Properties.Items)
            {
                Member member = (Member)item.Value;
                if (act.Joiners.Count(m => m.Id == member.Id) > 0)
                    item.CheckState = CheckState.Checked;
            }
            txtDetails.Text = act.Details;
            txtDetails.ReadOnly = read;
        }

        private void btnAddDestination_Click(object sender, EventArgs e)
        {
            Place place = (Place)cmbPlaces.SelectedItem;
            ListViewItem item = new ListViewItem();
            item.Text = place.Title;
            item.SubItems.Add(place.Province);
            item.Tag = place;
            Act.Destinations.Add(place);
            destinationList.Items.Add(item);
        }

        private void destinationList_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Delete)
            {
                ListViewItem item = destinationList.SelectedItems[0];
                Place place = item.Tag as Place;
                Act.Destinations.Remove(place);
                destinationList.SelectedItems[0].Remove();
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Act.Title = txtTitle.Text;
            Act.PlannedStartTime = txtPlannedStart.DateTime;
            Act.PlannedFinishTime = txtPlannedFinish.DateTime;
            Act.StartTime = txtStartTime.DateTime;
            Act.FinishTime = txtEndTime.DateTime;
            Act.Details = txtDetails.Text;
            foreach (CheckedListBoxItem item in plannerList.Properties.Items.Where(x => x.CheckState == CheckState.Checked))
            {
                Act.Planners.Add((Member)item.Value);
            }
            foreach (CheckedListBoxItem item in joinerList.Properties.Items.Where(x => x.CheckState == CheckState.Checked))
            {
                Act.Joiners.Add((Member)item.Value);
            }
            Close();
        }
    }
}