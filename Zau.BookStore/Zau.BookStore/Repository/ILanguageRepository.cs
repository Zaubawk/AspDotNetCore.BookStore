using System.Collections.Generic;
using System.Threading.Tasks;
using Zau.BookStore.Models;

namespace Zau.BookStore.Repository
{
    public interface ILanguageRepository
    {
        Task<List<LanguageModel>> GetLanguages();
    }
}