using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.CommonClasses;

namespace Business.Models
{
    public class User : CommonElement
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public IEnumerable<Aircraft> Aircrafts{ get; set; }
    }
}
