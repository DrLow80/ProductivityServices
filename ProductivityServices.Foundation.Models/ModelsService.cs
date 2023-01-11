using CSharpFunctionalExtensions;

namespace ProductivityServices.Foundation.Models
{
    public class ModelsService : IModelsService
    {
        public Project Project { get; private set; }

        public ModelsService()
        {
            Project = RandomProject();
        }

        public Maybe<IEnumerable<WorkCenter>> ListWorkCenters() => Maybe.From(Project?.WorkCenters);

        public Result Load(Project project)
        {
            Project = project;

            return Result.Success();
        }

        private static string RandomString()
        {
            return Guid.NewGuid().ToString();
        }

        private static Station RandomStation()
        {
            return new Station()
            {
                Operation = RandomString(),
                Name = RandomString(),
            };
        }

        private static WorkCenter RandomWorkCenter()
        {
            return new WorkCenter()
            {
                Name = RandomString(),
                Stations = RandomItems(RandomStation, 10)
            };
        }

        private static Project RandomProject()
        {
            return new Project()
            {
                Name = RandomString(),
                WorkCenters = RandomItems(RandomWorkCenter, 10)
            };
        }

        private static IEnumerable<T> RandomItems<T>(Func<T> item, int amount)
        {
            List<T> items = new List<T>();

            for (int i = 0; i < amount; i++)
            {
                items.Add(item());
            }

            return items;
        }
    }
}