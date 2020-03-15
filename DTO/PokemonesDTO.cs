using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
//Agregar esto para poder utilizar iformfile
using Microsoft.AspNetCore.Http;

namespace PokedexMalHecho.DTO
{
    public class PokemonesDTO
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }
        [Required]
        public int Tipo1 { get; set; }
        public int? Tipo2 { get; set; }
        public int Region { get; set; }
        [Required]
        [StringLength(15)]
        public string Ataque1 { get; set; }
        [StringLength(15)]
        public string Ataque2 { get; set; }
        [StringLength(15)]
        public string Ataque3 { get; set; }
        [StringLength(15)]
        public string Ataque4 { get; set; }
        [StringLength(100)]
        public IFormFile Photo { get; set; }
    }
}
