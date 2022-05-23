using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class Instrument
    {
        public int InstrumentId { get; set; }

        [Required]
        public string Name { get; set; }
        public string Categ { get; set; }
        public List<Musician> Musicians { get; set; } = new();
    }
}
