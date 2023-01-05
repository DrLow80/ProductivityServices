using CSharpFunctionalExtensions;
using ProductivityServices.Foundation.Models;

namespace ProductivityServices.Factory.Factory
{
    public interface IFileSystemService
    {
        Result Save(Project project);

        Result<Project> Load();
    }
}
