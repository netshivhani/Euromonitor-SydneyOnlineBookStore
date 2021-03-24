using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SydneyOnlineBookStore.Models;
namespace SydneyOnlineBookStore.Repository
{
    public interface ILanguageRepository
    {
        Task<List<LanguageModel>> GetLanguages();
    }
}
