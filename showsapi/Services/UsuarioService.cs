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
    public class UsuarioService : IUsuarioInterface
    {
         private readonly ShowAPIContext _showapicontext;

        public UsuarioService(ShowAPIContext showapicontext){
            _showapicontext = showapicontext;
        }

        public async Task<Usuario> create(Usuario Usuario){
            _showapicontext.Usuario.Add(Usuario);
            await _showapicontext.SaveChangesAsync();
            return Usuario;
        }
        public async Task<Usuario> update(int id){
            var Usuario = await _showapicontext.Usuario.FindAsync(id);
            if(Usuario == null){
            throw new Exception("Usuario não existe");
            }
            _showapicontext.Usuario.Update(Usuario);   
            await _showapicontext.SaveChangesAsync();
            return Usuario;
            
        }  
        public async Task<bool> delete(int id){
            var Usuario = await _showapicontext.Usuario.FindAsync(id);
            if(Usuario == null){
            throw new Exception("Usuario não existe");
            }
            _showapicontext.Usuario.Remove(Usuario);
            await _showapicontext.SaveChangesAsync();
            return false;
        }
        public async Task<Usuario> get(int id){
            return _showapicontext.Usuario.Find(id);
        }
        public async Task<IEnumerable<Usuario>> getAll(){
            return _showapicontext.Usuario.AsNoTracking().ToList();
        }
    }
    }