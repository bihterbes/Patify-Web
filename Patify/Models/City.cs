using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Patify.Models
{
    public class City
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string CityName { get; set; }
    }
}
