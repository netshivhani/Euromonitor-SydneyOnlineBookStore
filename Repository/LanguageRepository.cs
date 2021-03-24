using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SydneyOnlineBookStore.Models;
using SydneyOnlineBookStore.Data;

namespace SydneyOnlineBookStore.Repository
{
    public class LanguageRepository
    {

        private readonly BookStoreContext _context = null;

        public LanguageRepository(BookStoreContext context)
        {
            _context = context;
        }

        public async Task<List<LanguageModel>> GetLanguages()
        {
            return await _context.Language.Select(x => new LanguageModel()
            {
                Id = x.Id,
                Description = x.Description,
                Name = x.Name
            }).ToListAsync();
        }
    }
}
