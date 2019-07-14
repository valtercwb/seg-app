using Microsoft.EntityFrameworkCore;
using Segfy.Domain.Entities;
using Segfy.Domain.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Segfy.Domain
{
    public class ApoliceAutomovelRepository : IApoliceAutomovelRepository
    {
        private readonly SegfyContext _context;

        public ApoliceAutomovelRepository(SegfyContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ApoliceAutomovel>> Get()
        {
            var apoliceAutomovel = await _context.ApoliceAutomovel.Include(x => x.Automovel).Include(y => y.Segurado).ToListAsync();
            return apoliceAutomovel;
        }

        public async Task<ApoliceAutomovel> Get(int id)
        {
            var apoliceAutomovel = await _context.ApoliceAutomovel.Include(x => x.Automovel).Include(x => x.Segurado).FirstAsync(x=> x.Id == id);
            return apoliceAutomovel;
        }

        public async Task<ApoliceAutomovel> Delete(int id)
        {
            var apoliceAutomovel = await _context.ApoliceAutomovel.FindAsync(id);
            _context.ApoliceAutomovel.Remove(apoliceAutomovel);
            await _context.SaveChangesAsync();
            return apoliceAutomovel;
        }

        public async Task<ApoliceAutomovel> Add(ApoliceAutomovel apoliceAutomovel)
        {
            _context.ApoliceAutomovel.Add(apoliceAutomovel);
            await _context.SaveChangesAsync();
            return apoliceAutomovel;
        }

        public async Task<ApoliceAutomovel> Update(ApoliceAutomovel apoliceAutomovel)
        {
            _context.Entry(apoliceAutomovel).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return apoliceAutomovel;
        }
    }
}
