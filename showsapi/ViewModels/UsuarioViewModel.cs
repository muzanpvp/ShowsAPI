using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace showsapi.ViewModels
{
    public class UsuarioViewModel
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
}