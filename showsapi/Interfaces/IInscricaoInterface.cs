using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using showsapi.Models;

namespace showsapi.Interfaces
{
    public interface IInscricaoInterface 
    {
        Task<Inscricao> create(Inscricao inscricao);
        Task<Inscricao> update(int id);
        Task<bool> delete(int id);
        Task<Inscricao> get(int id);
        Task<IEnumerable<Inscricao>> getAll();
    }
}