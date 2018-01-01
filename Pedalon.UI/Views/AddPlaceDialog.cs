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

namespace Pedalon.UI.Views
{
    public partial class AddPlaceDialog : DevExpress.XtraEditors.XtraForm
    {
        public Place Place { get; set; }
        public AddPlaceDialog()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(Utils.Utilities.areNotNull(txtTitle.Text, txtProvince.Text)){
                Place = new Place();
                Place.Title = txtTitle.Text;
                Place.Province = txtProvince.Text;
                try
                {
                    Place.Latitute = Utils.Utilities.Ondalik(txtLatitude.EditValue);
                    Place.Longitute = Utils.Utilities.Ondalik(txtLongitude.EditValue);
                }
                catch (Exception)
                {

                }
                Service<Place>.AddOrUpdate(Place);
                Close();
            }
            else
            {
                MessageBox.Show("Yer ismi ve bulunduğu ili doldurmalısınız.", "Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}