using Mail.Search.Models;

namespace MailSystem.Interfaces
{
    public interface ISearchManager
    {
        SearchProcessor GenerateProcessor(SearchRequest request);
    }
}
