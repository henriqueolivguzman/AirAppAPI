using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.CommonClasses;

namespace Business.Models
{
    public class Engine : CommonElement
    {
        public string Name { get; set; }
        public double FuelConsumption { get; set; }
        [ForeignKey("Aircraft")]
        public int AricraftId { get; set; }// Significa que uma engine faz parte de uma aircraft
        public Aircraft Aircraft { get; set; }
    }
}
