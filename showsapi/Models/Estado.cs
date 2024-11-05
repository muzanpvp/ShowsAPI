using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace showsapi.Models
{
    [Table("estado")]
    public class Estado
    {
        [Key]
        public int Id { get; set;}
        public string Nome { get; set;}
    }
}