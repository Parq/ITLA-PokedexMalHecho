using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PokedexMalHecho.Models
{
    public partial class Regiones
    {
        public Regiones()
        {
            Pokemones = new HashSet<Pokemones>();
        }

        public int Id { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        [StringLength(30)]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        [StringLength(30)]
        public string CodigoRga { get; set; }

        public virtual ICollection<Pokemones> Pokemones { get; set; }
    }
}
