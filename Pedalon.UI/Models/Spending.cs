using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedalon.UI.Models
{
    public class Spending:Base
    {
        [Key, Display(AutoGenerateField = false)]
        public long Id { get; set; }

        [Display(Name = "Harcamayı Yapan")]
        public Member Spender { get; set; }

        [Display(Name = "Harcama Sebebi")]
        public string SpentFor { get; set; }

        [Display(Name = "Miktar (TL)")]
        public decimal Amount { get; set; }

        [Display(Name = "Harcama Tarihi")]
        public DateTime Date { get; set; }

        [Display(Name = "Firma")]
        public string Seller { get; set; }

        [Display(Name = "Fiş/Fatura No")]
        public string ReceiptNumber { get; set; }

    }
}
