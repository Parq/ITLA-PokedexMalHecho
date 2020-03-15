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
        [Required(ErrorMessage = "Campo Requerido")]
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
        public IFormFile Photo { get; set; }
    }
}
