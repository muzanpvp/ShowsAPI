using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using showsapi.Models;

namespace showsapi.Interfaces
{
    public interface IUsuarioInterface
    {
        Task<Usuario> create(Usuario usuario);
        Task<Usuario> update(int id);
        Task<bool> delete(int id);
        Task<Usuario> get(int id);
        Task<IEnumerable<Usuario>> getAll();
    }
}