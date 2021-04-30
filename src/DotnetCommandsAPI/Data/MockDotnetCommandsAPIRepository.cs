using System.Collections.Generic;
using src.DotnetCommandsAPI.Models;

namespace src.DotnetCommandsAPI.Data
{
    public class MockDotnetCommandsAPIRepository : IDotnetCommandsAPIRepository
    {
        public void CreateCommand(DotnetCommand cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(DotnetCommand cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<DotnetCommand> GetAllCommands()
        {
            var commands = new List<DotnetCommand>
            {
                new DotnetCommand 
                {
                    Id=0, 
                    HowTo="How to generate a migration",
                    CommandLine="dotnet ef migrations add <Name of Migration>",
                    Platform=".Net Core EF"
                },
                new DotnetCommand
                {                    
                    Id=1, 
                    HowTo="Run Migrations",
                    CommandLine="dotnet ef database update",
                    Platform=".Net Core EF"
                },
                new DotnetCommand
                {
                    Id=2, HowTo="List active migrations",
                    CommandLine="dotnet ef migrations list",
                    Platform=".Net Core EF"
                }
            };
            return commands;
        }

        public DotnetCommand GetCommandById(int id)
        {
            return new DotnetCommand
            {
                Id=0, 
                HowTo="How to generate a migration",
                CommandLine="dotnet ef migrations add <Name of Migration>",
                Platform=".Net Core EF"
            };
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(DotnetCommand cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}