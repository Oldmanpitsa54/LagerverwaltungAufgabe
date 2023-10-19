using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lagerverwaltung.Models
{
    public class Artikel
    {
        [Key]
        public uint Id { get; set; }
        public uint ArtikelgruppeId { get; set; }
        public uint Anzahl { get; set; }
        public string? Name { get; set; }
        public DateTime Eingangsdatum { get; set; }
        public DateTime Ausgangsdatum { get; set; }

    }
}