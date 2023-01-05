using CSharpFunctionalExtensions;

namespace ProductivityServices.Foundation.Models
{
    public interface IModelsService
    {
        Project Project { get; }

        Result Load(Project project);

        Maybe<IEnumerable<WorkCenter>> ListWorkCenters();
    }
}