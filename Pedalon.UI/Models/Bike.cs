using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedalon.UI.Models
{
    public class Bike
    {
        [Key, Display(AutoGenerateField = false)]
        public long Id { get; set; }

        [Display(Name = "Markası")]
        public string Brand { get; set; }

        [Display(Name = "Modeli")]
        public string Model { get; set; }

        [Display(Name = "Seri Numarası")]
        public string Serial { get; set; }

        [Display(Name = "Rengi")]
        public int Color { get; set; }
    }
}
