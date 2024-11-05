using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using showsapi.Interfaces;
using showsapi.Context;
using showsapi.Models;
using Microsoft.EntityFrameworkCore;
using showsapi.ViewModels;

namespace showsapi.Services
{
    public class ShowsService : IShowsInterface
    {
        private readonly ShowAPIContext _showapicontext;

        public ShowsService(ShowAPIContext showapicontext){
            _showapicontext = showapicontext;
        }

        public async Task<Shows> create(Shows shows){
             _showapicontext.Shows.Add(shows);
            _showapicontext.SaveChanges();
            return shows;
        }

        public async Task<Shows> update(Shows shows, int id){
            shows.Id = id;
            if(shows == null){
                throw new Exception("Show não encontrado, insira um id válido");
            }
            _showapicontext.Shows.Update(shows);
            await _showapicontext.SaveChangesAsync();
            return shows;
        }

        public async Task<bool> delete(int id){
            var show =_showapicontext.Shows.Find(id);
            if(show == null){
                throw new Exception("Show não encontrado, insira um id válido");
            }
            _showapicontext.Shows.Remove(show);
            await _showapicontext.SaveChangesAsync();
            return true;
        }

        public async Task<Shows> get(int id){
         var show = _showapicontext.Shows.Find(id);
         if(show == null){
            throw new Exception("Show não encontrado, insira um id válido");
         }
          return show;
        }

        public async Task<IEnumerable<Shows>> getAll(){
            return _showapicontext.Shows.AsNoTracking().ToList();
        }
    }
}