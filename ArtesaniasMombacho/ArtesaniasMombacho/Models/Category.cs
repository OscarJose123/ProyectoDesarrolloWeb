using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ArtesaniasMombacho.Models
{
    public class Category
    {

        public string Id { get; set; }
        [DisplayName("Nombre Categoria")]
        [Required(ErrorMessage = "Es requerido ingresar el nombre de la categoria")]
        [StringLength(50, ErrorMessage = "El nombre de la categoria no debe ser mayor a 50 caracteres")]
        public string Name { get; set; }
        
       

    }
}