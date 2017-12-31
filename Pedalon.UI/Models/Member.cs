using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedalon.UI.Models
{
    public class Member:Base
    {
        public Member()
        {
            this.Bikes = new List<Bike>();
        }
        [Key, Display(AutoGenerateField = false)]
        public long Id { get; set; }
        
        [Display(Name = "TC Kimlik", GroupName = "<TC|>")]
        public string CitizenNumber { get; set; }

        [Display(Name = "Adı", GroupName = "{Tabs}/Temel Bilgiler", Order = 1)]
        public string Name { get; set; }

        [Display(Name = "Soyadı", GroupName = "{Tabs}/Temel Bilgiler", Order = 2)]
        public string Lastname { get; set; }
        
        [Display(Name = "Uyruğu", GroupName = "{Tabs}/Temel Bilgiler", Order = 3)]
        public string Nationality { get; set; }

        [Display(Name = "Anne Adı", GroupName = "{Tabs}/Temel Bilgiler", Order = 4)]
        public string MotherName { get; set; }

        [DisplayFormat(DataFormatString = "dd.MM.yyyy"), Display(Name = "Doğum Tarihi", GroupName = "{Tabs}/Temel Bilgiler", Order = 5)]
        public DateTime Birth { get; set; }
        
        [Display(Name = "Cinsiyet", GroupName = "{Tabs}/Temel Bilgiler", Order = 6)]
        public string Gender { get; set; }

        [Display(Name = "Kan Gr.", GroupName = "{Tabs}/Temel Bilgiler", Order = 7)]
        public string BloodType { get; set; }

        [Display(Name = "Meslek", GroupName = "{Tabs}/Temel Bilgiler", Order = 8)]
        public string Job { get; set; }

        [Display(Name = "E-Posta", GroupName = "{Tabs}/İletişim Bilgileri", Order = 9)]
        [DataType(DataType.EmailAddress)]
        public string Mail { get; set; }

        [Display(Name = "Telefon", GroupName = "{Tabs}/İletişim Bilgileri", Order = 10)]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [Display(Name = "Adres", GroupName = "{Tabs}/İletişim Bilgileri", Order = 11), DataType(DataType.MultilineText)]
        public string Address { get; set; }

        [Display(Name = "Üyelik Başvuru Tarihi", GroupName = "{Tabs}/Üyelik Bilgileri", Order = 12)]
        public DateTime ApplicationDate { get; set; }

        [Display(Name = "Üyeliğe Kabul Tarihi", GroupName = "{Tabs}/Üyelik Bilgileri", Order = 13)]
        public DateTime ApprovalDate { get; set; }

        [Display(Name = "Üyelik Red Tarihi", AutoGenerateField = false)]
        public DateTime RejectionDate { get; set; }

        [Display(Name = "Üyelikten Ayrılma Tarihi", AutoGenerateField = false)]
        public DateTime AbortDate { get; set; }

        [Display(Name = "Giriş Aidatı", AutoGenerateField = false)]
        public decimal EntranceFee { get; set; }

        [Display(Name = "Aylık Aidat", AutoGenerateField = false)]
        public decimal MonthlyFee { get; set; }

        [Display(Name = "Bisikletleri", GroupName = "{Tabs}/Üyelik Bilgileri", Order = 14)]
        public List<Bike> Bikes { get; set; }

        public override string ToString()
        {
            return Name + " " + Lastname;
        }
    }
    
}
