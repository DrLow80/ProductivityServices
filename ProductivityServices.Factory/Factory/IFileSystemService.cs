using CSharpFunctionalExtensions;

namespace ProductivityServices.Factory.Factory
{
    public interface IFileSystemService
    {
        Result Save(Factory factory);

        Result<Factory> Load();
    }
}
