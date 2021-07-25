using Mail.Data.Enums;
using Mail.Data.Models;
using System.Collections.Generic;

namespace Mail.Organize.Mappers
{
    public class MapperDirectory
    {
        public List<KeyValuePair<DirectoryType, BaseDirectory>> directoryDictionary = new List<KeyValuePair<DirectoryType, BaseDirectory>>();

        public MapperDirectory()
        {
            directoryDictionary.Add(new KeyValuePair<DirectoryType, BaseDirectory>(DirectoryType.Base, new BaseDirectory()));
            directoryDictionary.Add(new KeyValuePair<DirectoryType, BaseDirectory>(DirectoryType.Custom, new CustomDirectory()));
        }
    }
}
