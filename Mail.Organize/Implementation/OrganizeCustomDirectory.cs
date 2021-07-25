using Mail.Data.Models;
using Mail.Organize.Interfaces;
using System;

namespace Mail.Organize.Implementation
{
    public class OrganizeCustomDirectory : IOrganizeCustomDirectory
    {
        public void CreateCustomDirectory(CustomDirectory newDirectory)
        {
            Console.WriteLine("Creating new custom directory...");
        }

        public void DeleteCustomDirectory(CustomDirectory newDirectory)
        {
            Console.WriteLine("Deleting custom directory...");
        }
        
        public CustomDirectory GetCustomDirectory(string directoryName)
        {
            Console.WriteLine("Obtaining custom directory...");
            return new CustomDirectory();
        }

        public void MoveDirectory(CustomDirectory origin, CustomDirectory destiny)
        {
            origin.Parent = destiny;
        }

        public void UpdateCustomDirectory(CustomDirectory newDirectory)
        {
            Console.WriteLine("Updating custom directory...");
        }
    }
}
