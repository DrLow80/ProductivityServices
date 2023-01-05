using CSharpFunctionalExtensions;

namespace ProductivityServices.Factory.Factory
{
    public interface IFactoryService
    {
        Result Load();
        Result Save();
    }
}

