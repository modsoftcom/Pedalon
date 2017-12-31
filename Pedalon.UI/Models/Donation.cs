using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedalon.UI.Models
{
    public class Donation:Base
    {
        [Key, Display(AutoGenerateField = false)]
        public long Id { get; set; }

        [Display(Name = "Bağışı Yapan")]
        public string Donater { get; set; }

        [Display(Name = "Bağışı Alan")]
        public Member Taker { get; set; }

        [Display(Name = "Bağış Türü")]
        public string Type { get; set; } // Para, Mal, Hizmet

        [Display(Name = "Miktar(TL)")]
        public decimal Amount { get; set; }

        [Display(Name = "Tarih-Saat")]
        public DateTime Date { get; set; }

        [Display(Name = "Açıklamalar")]
        public string Details { get; set; }
    }
}
