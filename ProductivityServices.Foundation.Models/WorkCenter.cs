﻿namespace ProductivityServices.Foundation.Models
{
    public class WorkCenter
    {
        public string Name { get; set; }
        public IEnumerable<Station> Stations { get; set; }
    }
}