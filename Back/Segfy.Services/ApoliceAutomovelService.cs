using Segfy.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using Segfy.Domain;
using Segfy.Domain.Entities;
using Segfy.Domain.Interfaces;

namespace Segfy.Services
{
    public class ApoliceAutomovelService : IApoliceAutomovelService
    {

            private readonly IApoliceAutomovelRepository _apoliceAutomovelRepository;

            public ApoliceAutomovelService(IApoliceAutomovelRepository apoliceAutomovelRepository)
            {
            _apoliceAutomovelRepository = apoliceAutomovelRepository;
            }

        public async Task<ApoliceAutomovel> Add(ApoliceAutomovel apoliceAutomovel)
        {
            return await _apoliceAutomovelRepository.Add(apoliceAutomovel);
        }

        public async Task<ApoliceAutomovel> Update(ApoliceAutomovel apoliceAutomovel)
        {
            return await _apoliceAutomovelRepository.Update(apoliceAutomovel);
        }

        public Task<IEnumerable<ApoliceAutomovel>> Get()
        {
            return _apoliceAutomovelRepository.Get();
        }

        public Task<ApoliceAutomovel> Get(int apoliceAutomovelId)
        {
            return _apoliceAutomovelRepository.Get(apoliceAutomovelId);
        }

        public Task<ApoliceAutomovel> Delete(int apoliceAutomovelId)
        {
            return _apoliceAutomovelRepository.Delete(apoliceAutomovelId);
        }
    }
}
