using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.CommonClasses
{
    public abstract class CommonElement
    {
        [Key]
        public int Id { get; set; }
    }
}
