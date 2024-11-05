using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using showsapi.Models;

namespace showsapi.Context
{
    public class ShowAPIContext : DbContext
    {

        public ShowAPIContext(){

        }

        public ShowAPIContext(DbContextOptions<ShowAPIContext> options) : base(options){

        }


        public DbSet<Usuario> Usuario { get; set;}
        public DbSet<Shows> Shows { get; set;}
        public DbSet<NotaFiscal> NotaFiscal { get; set;}
        public DbSet<Inscricao> Inscricao { get; set;}
        public DbSet<Estado> Estado { get; set;}

      
        
    }
}