using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerverwaltung.Models
{
    public class Artikelgruppe
    {
        [Key]
        public uint Id { get; set; }
        public string? Name { get; set; }

    }
}
