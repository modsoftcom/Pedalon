using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedalon.UI.Models
{
    public class Todo:Base
    {
        public Todo()
        {
            Planners = new List<Member>();
            Doers = new List<Member>();
        }
        [Key, Display(AutoGenerateField = false)]
        public long Id { get; set; }

        [Display(Name = "Başlık")]
        public string Title { get; set; }

        [Display(Name = "Planlanan Başlangıç Zamanı")]
        public DateTime PlannedStartTime { get; set; }

        [Display(Name = "Planlanan Bitiş Zamanı")]
        public DateTime PlannedFinishTime { get; set; }

        [Display(Name = "Detaylar")]
        public string Details { get; set; }

        [Display(Name = "Planlayanlar")]
        public List<Member> Planners { get; set; }

        [Display(Name = "Yapacaklar")]
        public List<Member> Doers { get; set; }

    }
}
