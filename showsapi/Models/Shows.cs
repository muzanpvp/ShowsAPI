using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace showsapi.Models
{
    [Table("shows")]
    public class Shows
    {
        [Key]
        public int Id { get; set;}
        public string Nome { get; set;}
        public DateTime Data_inicio { get; set;}
        public string Localizacao { get; set;}
        public int Id_Estado { get; set;}

    }
}