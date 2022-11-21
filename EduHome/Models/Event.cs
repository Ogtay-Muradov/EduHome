using System;

namespace EduHome.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string By { get; set; }
        public string Image { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
