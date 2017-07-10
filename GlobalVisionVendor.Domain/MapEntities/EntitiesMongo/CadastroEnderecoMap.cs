using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace UsandoMongoDB.Models
{
    public class CadastroEnderecoMap
    {      

        [Required]
        [Display(Name = "Nome")]
        public String Endereco { get; set; }

        [Required]
        [Display(Name = "Latitude")]
        public String Latitude { get; set; }

        [Required]
        [Display(Name = "Longitude")]
        public String Longitude { get; set; }
    }
}