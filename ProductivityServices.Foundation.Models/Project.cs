namespace ProductivityServices.Foundation.Models
{
    public class Project
    {
        public string Name { get; set; }
        public IEnumerable<WorkCenter> WorkCenters { get; set; }
    }
}