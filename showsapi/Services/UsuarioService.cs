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

        public async Task<Usuario> create(Usuario usuario){
            _showapicontext.Usuario.Add(usuario);
            await _showapicontext.SaveChangesAsync();
            return usuario;
        }
        public async Task<Usuario> update(Usuario usuario,int id){
            usuario.Id = id;
            if(usuario == null){
            throw new Exception("Usuario não existe");
            }
            _showapicontext.Usuario.Update(usuario);   
            await _showapicontext.SaveChangesAsync();
            return usuario;
            
        }  
        public async Task<bool> delete(int id){
            var usuario = await _showapicontext.Usuario.FindAsync(id);
            if(usuario == null){
            throw new Exception("Usuario não existe");
            }
            _showapicontext.Usuario.Remove(usuario);
            await _showapicontext.SaveChangesAsync();
            return false;
        }
        public async Task<Usuario> get(int id){
            var usuario =  _showapicontext.Usuario.Find(id);
            if(usuario == null){
                throw new Exception("O usuário não existe");
            }
            return usuario;
        }
        public async Task<IEnumerable<Usuario>> getAll(){
            return _showapicontext.Usuario.AsNoTracking().ToList();
        }
    }
    }