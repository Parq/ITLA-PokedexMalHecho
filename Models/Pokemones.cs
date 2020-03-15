using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PokedexMalHecho.Models
{
    public partial class Pokemones
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Campo Requerido")]
        [StringLength(50)]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        public int Tipo1 { get; set; }
        public int? Tipo2 { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        public int Region { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        [StringLength(50)]
        public string Ataque1 { get; set; }
        [StringLength(50)]
        public string Ataque2 { get; set; }
        [StringLength(50)]
        public string Ataque3 { get; set; }
        [StringLength(50)]
        public string Ataque4 { get; set; }
        [StringLength(100)]
        public string Photo { get; set; }

        public virtual Regiones RegionNavigation { get; set; }
        public virtual Tipos Tipo1Navigation { get; set; }
        public virtual Tipos Tipo2Navigation { get; set; }
    }
}
