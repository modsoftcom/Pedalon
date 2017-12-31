using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedalon.UI.Models
{
    public class Fee:Base
    {
        [Key, Display(AutoGenerateField = false)]
        public long Id { get; set; }

        [Display(Name = "Üye")]
        public Member Member { get; set; }

        [Display(Name = "Aidat Türü")]
        public string Type { get; set; } // Giriş, Aylık

        [Display(Name = "Miktar (TL)")]
        public decimal Amount { get; set; }

        [Display(Name = "Ödenme Tarihi")]
        public DateTime GivenDate { get; set; }

        [Display(Name = "Makbuz Kesildi Mi?")]
        public bool HasCutReceipt { get; set; }

        [Display(Name = "Makbuz Tarihi")]
        public DateTime ReceiptDate { get; set; }
    }
}
