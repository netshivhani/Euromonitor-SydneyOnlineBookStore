using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SydneyOnlineBookStore.Enums
{
    public class LanguageEnum
    {
        [Display(Name = "English language")]
        English = 11,
        [Display(Name = "German language")]
        German = 12,
    }
}
