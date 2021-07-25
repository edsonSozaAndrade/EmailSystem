using Mail.Search.Models;

namespace Mail.Search.SearchTypes
{
    public abstract class SearchCreator
    {
        public abstract SearchProcessor GetSearchProcessor();
    }
}
