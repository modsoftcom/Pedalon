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
using System.ComponentModel.DataAnnotations;
using Pedalon.UI.Models;
using Pedalon.UI.Utils;

namespace Pedalon.UI.Views
{
    public partial class FeeStatusForm : DevExpress.XtraEditors.XtraForm
    {
        List<FeeStatus> EntranceList = new List<FeeStatus>();
        List<FeeStatus> MonthlyList = new List<FeeStatus>();
        public FeeStatusForm()
        {
            InitializeComponent();
            List<Fee> fees = Service<Fee>.SelectAll();


            List<Member> entranceMembers = Service<Member>.SelectAll();
            foreach (Fee fee in fees.Where(m => m.Type.Equals("Giriş Aidatı")))
            {
                entranceMembers.Remove(entranceMembers.SingleOrDefault(m => m.Id == fee.Member.Id));
            }
            gridEntrance.DataSource = from mem in entranceMembers
                                      select new FeeStatus
                                      {
                                          Name = mem.Name + " " + mem.Lastname,
                                          Amount = mem.EntranceFee,
                                          MemberDate = mem.ApprovalDate,
                                          MemberDuration = GetDuration(mem)
                                      };

            gridEntrance.RefreshDataSource();
            gridViewEntrance.BestFitColumns();

            List<FeeStatus> monthlyMembers = new List<FeeStatus>();
            List<Fee> allFees = Service<Fee>.SelectAll();
            foreach (Member member in Service<Member>.SelectAll())
            {
                decimal totalFee = ((int)(DateTime.Now - member.ApprovalDate).TotalDays / 30) * member.MonthlyFee;
                decimal remain = totalFee - allFees.Where(f => f.Member.Id == member.Id && f.Type.Equals("Aylık Ödeme")).Sum(f => f.Amount);
                FeeStatus status = new FeeStatus();
                status.Name = member.ToString();
                status.Amount = remain;
                if (allFees.Count(f => f.Member.Id == member.Id) > 0)
                    status.LastPay = allFees.OrderByDescending(f => f.Member.Id == member.Id).ToList()[0].GivenDate;
                status.MemberDate = member.ApprovalDate;
                status.MemberDuration = GetDuration(member);
                monthlyMembers.Add(status);
            }
            gridMonth.DataSource = monthlyMembers;
            gridMonth.RefreshDataSource();
            gridViewMonth.BestFitColumns();

        }

        private static string GetDuration(Member mem)
        {
            return (DateTime.Now - mem.ApprovalDate).TotalDays > 30 ? (int)((DateTime.Now - mem.ApprovalDate).TotalDays / 30) + " ay, " + (int)((DateTime.Now - mem.ApprovalDate).TotalDays / 30) % 30 + " gün" : (int)((DateTime.Now - mem.ApprovalDate).TotalDays / 30) + " gün";
        }

        class FeeStatus
        {
            [Display(Name = "Üye Adı Soyadı")]
            public string Name { get; set; }

            [Display(Name = "Üyelik Başlangıcı")]
            public DateTime MemberDate { get; set; }

            [Display(Name = "Üyelik Süresi")]
            public string MemberDuration { get; set; }

            [Display(Name = "Son Ödeme Tarihi")]
            public DateTime LastPay { get; set; }

            [Display(Name = "Toplam Borç")]
            public decimal Amount { get; set; }
        }
    }
}