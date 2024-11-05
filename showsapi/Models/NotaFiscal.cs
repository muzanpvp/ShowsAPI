using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace showsapi.Models
{
    [Table("notafiscal")]
    public class NotaFiscal
    {
        [Key]
        public int Id { get; set;}
        public Inscricao Id_Inscricao { get; set;}
        public DateTime Data_emissao { get; set;}
        public decimal Valor_Total { get; set;}
        public string Numero { get; set;}
    }
}