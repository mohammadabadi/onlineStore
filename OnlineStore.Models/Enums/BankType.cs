using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Models.Enums
{
    public enum BankType : byte
    {
        [Display(Name = "بانک ملت")]
        Mellat = 1
    }
}
