using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace showsapi.Models;

[Table("usuario")]
public class Usuario
{
    [Key]
    public int Id { get; set;}
    [Required]
    public string Nome { get; set;}
    [Required]
    public string Email { get; set;}
    [Required]
    public string Senha { get; set;}
    [Required]
    public DateTime Data_nascimento { get; set;}
}
