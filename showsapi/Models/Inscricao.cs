using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace showsapi.Models
{
    [Table("inscricao")]
    public class Inscricao
    {
      [Key]
      public int Id { get; set;}
      public DateTime Data_Inscricao { get; set;}
      public decimal Valor { get; set;}
      public Shows Id_Show { get; set;}
      public Usuario Id_Usuario { get; set;} 
    }
}