using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Models.Enums
{
    public enum EmailStatus
    {
        [Display(Name = "دریافت شد")]
        Delivered = 0,

        [Display(Name = "ناموفق")]
        Failed = 1,

        [Display(Name = "دریافت نشد")]
        NotDelivered = 2,
    }
}
