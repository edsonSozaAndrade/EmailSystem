using Mail.Data.Models;

namespace Mail.Organize.Interfaces
{
    public interface IOrganizeCustomDirectory
    {
        void CreateCustomDirectory(CustomDirectory newDirectory);
        CustomDirectory GetCustomDirectory(string directoryName);
        void UpdateCustomDirectory(CustomDirectory newDirectory);
        void DeleteCustomDirectory(CustomDirectory newDirectory);
        void MoveDirectory(CustomDirectory origin, CustomDirectory destiny);
    }
}
