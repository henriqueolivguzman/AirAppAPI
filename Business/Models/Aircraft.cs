using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Models.Enums;
using Business.CommonClasses;

namespace Business.Models
{
    public class Aircraft : CommonElement
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public AircraftType AircraftType { get; set; }
        public IEnumerable<Engine> Engines { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; } // é necessario a relação de um usuario criar uma aeronave, chave estrangeira
        public User User { get; set; }
    }
}
