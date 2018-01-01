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
    public partial class FormViewer : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormViewer(Member member)
        {
            InitializeComponent();
            MemberReport report = new MemberReport(member);
            try
            {
                report.CreateDocument();
            }
            catch (Exception ex)
            {
                throw;
            }
            document.DocumentSource = report;
        }
    }
}