using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using showsapi.Models;

namespace showsapi.Interfaces
{
    public interface IShowsInterface
    {
        Task<Shows> create(Shows shows);
        Task<Shows> update(Shows shows,int id);
        Task<bool> delete(int id);
        Task<Shows> get(int id);
        Task<IEnumerable<Shows>> getAll();
    }
}