using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using showsapi.Models;

namespace showsapi.Interfaces
{
    public interface INotaFiscalInterface
    {
        Task<NotaFiscal> create(NotaFiscal notafiscal);
        Task<NotaFiscal> update(int id);
        Task<bool> delete(int id);
        Task<NotaFiscal> get(int id);
        Task<IEnumerable<NotaFiscal>> getAll();
    }
}