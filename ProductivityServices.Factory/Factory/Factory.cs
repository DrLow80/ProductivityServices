using System;

namespace ProductivityServices.Factory.Factory
{
    public class Factory
    {
        public string Name { get; set; }

        public Factory()
        {
            this.Name = Guid.NewGuid().ToString();
        }
    }
}
