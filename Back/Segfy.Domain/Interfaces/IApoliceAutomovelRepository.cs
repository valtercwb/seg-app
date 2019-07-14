using Segfy.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Segfy.Domain.Interfaces
{
    public interface IApoliceAutomovelRepository
    {
        Task<IEnumerable<ApoliceAutomovel>> Get();
        Task<ApoliceAutomovel> Get(int apoliceAutomovelId);
        Task<ApoliceAutomovel> Add(ApoliceAutomovel apoliceAutomovel);
        Task<ApoliceAutomovel> Update(ApoliceAutomovel apoliceAutomovel);
        Task<ApoliceAutomovel> Delete(int apoliceAutomovelId);
    }
}
