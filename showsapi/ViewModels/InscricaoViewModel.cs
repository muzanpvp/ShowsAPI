using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using showsapi.Models;

namespace showsapi.ViewModels
{
    public class InscricaoViewModel
    {
      [Key]
      public int Id { get; set;}
      [Required]
      public DateTime Data_Inscricao { get; set;}
      [Required]
      public decimal Valor { get; set;}
      [Required]
      public Shows Id_Show { get; set;}
      [Required]
      public Usuario Id_Usuario { get; set;} 
    }
}