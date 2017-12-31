using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedalon.UI.Models
{
    public class Place:Base
    {
        [Key, Display(AutoGenerateField = false)]
        public long Id { get; set; }

        [Display(Name = "Adı")]
        public string Title { get; set; }

        [Display(Name = "İli")]
        public string Province { get; set; }

        [Display(Name = "Enlem")]
        public double Latitute { get; set; }

        [Display(Name = "Boylam")]
        public double Longitute { get; set; }
        public override string ToString()
        {
            return Title + " (" + Province + ")";
        }
    }
}
