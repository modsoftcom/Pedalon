using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedalon.UI.Models
{
    public class User
    {
        public User()
        {
            Logins = new List<DateTime>();
        }
        [Key, Display(AutoGenerateField = false)]
        public long Id { get; set; }

        [Display(Name = "Kullanıcı Adı")]
        public string Username { get; set; }

        [Display(Name = "Parola")]
        public string Password { get; set; }

        [Display(Name = "Sisteme Girişler")]
        public List<DateTime> Logins { get; set; }
    }
}
