using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedalon.UI.Models
{
    public class Base
    {

        [Display(Name = "Oluşturan", AutoGenerateField = false)]
        public User CreatedBy { get; set; }

        [Display(Name = "Oluşturma Tarihi", AutoGenerateField = false)]
        public DateTime DateCreated { get; set; }

        [Display(Name = "Düzenleyen", AutoGenerateField = false)]
        public User ModifiedBy { get; set; }

        [Display(Name = "Düzenlenme Tarihi", AutoGenerateField = false)]
        public DateTime DateModified { get; set; }
    }
}
