using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using showsapi.Models;
using showsapi.Interfaces;
using showsapi.Context;
using Microsoft.EntityFrameworkCore;

namespace showsapi.Services
{
    public class NotaFiscalService : INotaFiscalInterface
    {
        private readonly ShowAPIContext _showapicontext;

        public NotaFiscalService(ShowAPIContext showapicontext){
            _showapicontext = showapicontext;
        }

        public async Task<NotaFiscal> create(NotaFiscal NotaFiscal){
            _showapicontext.Add(NotaFiscal);
            _showapicontext.SaveChanges();
            return NotaFiscal;
        }
        public async Task<NotaFiscal> update(int id){
            var notafiscal =_showapicontext.NotaFiscal.Find(id);
            if(notafiscal == null){
                throw new Exception("Nota Fiscal não encontrada, insira um id válido");
            }
            _showapicontext.NotaFiscal.Update(notafiscal);
            return notafiscal;
        }
        public async Task<bool> delete(int id){
            var notafiscal =_showapicontext.NotaFiscal.Find(id);
            if(notafiscal == null){
                throw new Exception("Nota Fiscal não encontrada, insira um id válido");
            }
            _showapicontext.NotaFiscal.Remove(notafiscal);
            return true;
        }
        public async Task<NotaFiscal> get(int id){
         var notafiscal = _showapicontext.NotaFiscal.Find(id);
         if(notafiscal == null){
            throw new Exception("Nota Fiscal não encontrado, insira um id válido");
         }
          return notafiscal;
        }
        public async Task<IEnumerable<NotaFiscal>> getAll(){
            return _showapicontext.NotaFiscal.AsNoTracking().ToList();
        }
    }
}