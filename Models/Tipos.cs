using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PokedexMalHecho.Models
{
    public partial class Tipos
    {
        public Tipos()
        {
            PokemonesTipo1Navigation = new HashSet<Pokemones>();
            PokemonesTipo2Navigation = new HashSet<Pokemones>();
        }

        public int Id { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        [StringLength(30)]
        public string Nombre { get; set; }

        public virtual ICollection<Pokemones> PokemonesTipo1Navigation { get; set; }
        public virtual ICollection<Pokemones> PokemonesTipo2Navigation { get; set; }
    }
}
