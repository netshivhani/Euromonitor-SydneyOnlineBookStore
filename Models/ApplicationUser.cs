using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SydneyOnlineBookStore.Models
{
    public class ApplicationUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
    }
}
