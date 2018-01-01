using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Pedalon.UI.Models;

namespace Pedalon.UI.Views
{
    public partial class MemberReport : DevExpress.XtraReports.UI.XtraReport
    {
        public MemberReport()
        {
            InitializeComponent();
        }
        public MemberReport(Member member)
        {
            InitializeComponent();
            this.bindingSource1.DataSource = member;
            Name.Type = typeof(string);
            Name.Value = member.ToString();
            ApplicationDate.Value = member.ApplicationDate;
            ApprovalNumber.Value = "";
            DecisionDate.Value = "";
            BoardMember.Value = "";
        }
        public MemberReport(Member member, DateTime applicationDate, DateTime approvalDate, string decisionNumber, string boardMember)
        {
            InitializeComponent();
            this.DataSource = member;
            Name.Value = member.ToString();
            ApplicationDate.Value = applicationDate;
            ApprovalNumber.Value = approvalDate.ToString("dd.MM.yyyy");
            DecisionDate.Value = decisionNumber;
            BoardMember.Value = boardMember;
        }

    }
}
