using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedalon.UI.Models
{
    public class Act:Base
    {
        public Act()
        {
            Destinations = new List<Place>();
            Planners = new List<Member>();
            Joiners = new List<Member>();
        }
        [Key, Display(AutoGenerateField = false)]
        public long Id { get; set; }

        [Display(Name = "Başlık")]
        public string Title { get; set; }

        [Display(Name = "Planlanan Başlangıç Zamanı")]
        public DateTime PlannedStartTime { get; set; }

        [Display(Name = "Planlanan Bitiş Zamanı")]
        public DateTime PlannedFinishTime { get; set; }

        [Display(Name = "Başlangıç Zamanı")]
        public DateTime StartTime { get; set; }

        [Display(Name = "Bitiş Zamanı")]
        public DateTime FinishTime { get; set; }

        [Display(Name = "Duraklar")]
        public List<Place> Destinations { get; set; }

        [Display(Name = "Detaylar")]
        public string Details { get; set; }

        [Display(Name = "Planlayanlar")]
        public List<Member> Planners { get; set; }

        [Display(Name = "Katılımcılar")]
        public List<Member> Joiners { get; set; }

    }
}
