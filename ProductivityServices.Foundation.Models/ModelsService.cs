using CSharpFunctionalExtensions;

namespace ProductivityServices.Foundation.Models
{
    public class ModelsService : IModelsService
    {
        public Project Project { get; private set; }

        public ModelsService()
        {
            Project = new Project();
            Project.Name= Guid.NewGuid().ToString();    
            Project.WorkCenters = new[] {
                new WorkCenter() {
                    Name=Guid.NewGuid().ToString()
                },
                 new WorkCenter() {
                    Name=Guid.NewGuid().ToString()
                }, new WorkCenter() {
                    Name=Guid.NewGuid().ToString()
                }
            };
        }

        public Maybe<IEnumerable<WorkCenter>> ListWorkCenters() => Maybe.From(Project?.WorkCenters);

        public Result Load(Project project)
        {
            Project = project;

            return Result.Success();
        }
    }
}