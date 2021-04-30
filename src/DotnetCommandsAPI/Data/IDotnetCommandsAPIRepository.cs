using System.Collections.Generic;
using src.DotnetCommandsAPI.Models;

namespace src.DotnetCommandsAPI.Data
{
    public interface IDotnetCommandsAPIRepository
    {
        bool SaveChanges();
        IEnumerable<DotnetCommand> GetAllCommands();
        DotnetCommand GetCommandById(int id);
        void CreateCommand(DotnetCommand cmd);
        void UpdateCommand(DotnetCommand cmd);
        void DeleteCommand(DotnetCommand cmd);        
    }
}