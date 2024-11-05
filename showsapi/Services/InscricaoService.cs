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
    public class InscricaoService : IInscricaoInterface
    {
        private readonly ShowAPIContext _showapicontext;

        public InscricaoService(ShowAPIContext showapicontext){
            _showapicontext = showapicontext;
        }

        public async Task<Inscricao> create(Inscricao inscricao){
            _showapicontext.Inscricao.Add(inscricao);
            await _showapicontext.SaveChangesAsync();
            return inscricao;
        }
        public async Task<Inscricao> update(int id){
            var inscricao = await _showapicontext.Inscricao.FindAsync(id);
            if(inscricao == null){
            throw new Exception("Inscrição não existe");
            }
            _showapicontext.Inscricao.Update(inscricao);   
            await _showapicontext.SaveChangesAsync();
            return inscricao;
            
        }  
        public async Task<bool> delete(int id){
            var inscricao = await _showapicontext.Inscricao.FindAsync(id);
            if(inscricao == null){
            throw new Exception("Inscrição não existe");
            }
            _showapicontext.Inscricao.Remove(inscricao);
            await _showapicontext.SaveChangesAsync();
            return false;
        }
        public async Task<Inscricao> get(int id){
            return  _showapicontext.Inscricao.Find(id);
        }
        public async Task<IEnumerable<Inscricao>> getAll(){
            return _showapicontext.Inscricao.AsNoTracking().ToList();
        }
    }
}