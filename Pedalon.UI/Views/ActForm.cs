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
using System.Threading;

namespace Pedalon.UI.Views
{
    public partial class ActForm : DevExpress.XtraEditors.XtraForm
    {
        public Act Act;
        public List<Place> Destinations;
        public List<Member> Planners;
        public List<Member> Joiners;

        public ActForm()
        {
            InitializeComponent();
            Act = new Act();
            Destinations = new List<Place>();
            Planners = new List<Member>();
            Joiners = new List<Member>();

            PopulatePlaces();
            foreach (Member member in Service<Member>.SelectAll())
            {
                CheckedListBoxItem item = new CheckedListBoxItem();
                item.Tag = member;
                item.Value = member.ToString();
                plannerList.Items.Add(item);
                joinerList.Items.Add(item);
            }

            txtPlannedStart.DateTime = txtStartTime.DateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month,DateTime.Now.Day, 20,0,0);
            txtPlannedFinish.DateTime = txtEndTime.DateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 22, 0, 0);
        }

        public ActForm(Act act, bool read = false)
        {
            InitializeComponent();
            Act = act;
            Destinations = Act.Destinations;
            Planners = Act.Planners;
            Joiners = Act.Joiners;
            PopulatePlaces();

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
            if (read)
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


            foreach (Member member in Service<Member>.SelectAll())
            {
                CheckedListBoxItem item = new CheckedListBoxItem();
                item.Tag = member;
                item.Value = member.ToString();
                if (Act.Planners.Count(m => m.Id == member.Id) > 0)
                    item.CheckState = CheckState.Checked;
                plannerList.Items.Add(item);


                if (Act.Joiners.Count(m => m.Id == member.Id) > 0)
                    item.CheckState = CheckState.Checked;
                else
                    item.CheckState = CheckState.Unchecked;
                joinerList.Items.Add(item);
            }
            txtDetails.Text = act.Details;
            txtDetails.ReadOnly = read;
        }

        private void PopulatePlaces()
        {
            cmbPlaces.DataSource = null;
            cmbPlaces.DataSource = Service<Place>.SelectAll();
        }

        private void btnAddDestination_Click(object sender, EventArgs e)
        {
            Place place = (Place)cmbPlaces.SelectedItem;
            AddDestination(place);
        }

        private void AddDestination(Place place)
        {
            ListViewItem item = new ListViewItem();
            item.Text = place.Title;
            item.SubItems.Add(place.Province);
            item.Tag = place;
            Destinations.Add(place);
            destinationList.Items.Add(item);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Act.Title = txtTitle.Text;
            Act.PlannedStartTime = txtPlannedStart.DateTime;
            Act.PlannedFinishTime = txtPlannedFinish.DateTime;
            Act.StartTime = txtStartTime.DateTime;
            Act.FinishTime = txtEndTime.DateTime;
            Act.Details = txtDetails.Text;
            Act.Planners.Clear();
            Act.Joiners.Clear();

            foreach (CheckedListBoxItem item in plannerList.Items.Where(x => x.CheckState == CheckState.Checked))
            {
                Planners.Add((Member)item.Tag);
            }
            foreach (CheckedListBoxItem item in joinerList.Items.Where(x => x.CheckState == CheckState.Checked))
            {
                Joiners.Add((Member)item.Tag);
            }
            Close();
        }
        

        private void yeniYerOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPlaceDialog dialog = new AddPlaceDialog();
            if(dialog.ShowDialog() == DialogResult.OK && dialog.Place != null)
            {
                AddDestination(dialog.Place);
            }
        }

        private void durağıSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(destinationList.SelectedItems.Count> 0)
            {
                Place place = destinationList.SelectedItems[0].Tag as Place;
                Destinations.Remove(place);
                destinationList.SelectedItems[0].Remove();
            }
        }
    }
}