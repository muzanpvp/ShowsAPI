using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using showsapi.Models;

namespace showsapi.ViewModels
{
    public class ShowsViewModel
    {
        public int Id { get; set;}
        [Required]
        public string Nome { get; set;}
        public DateTime Data_inicio { get; set;}
        [Required]
        public string Localizacao { get; set;}
        [Required]
        public int Id_Estado { get; set;}
    }
}