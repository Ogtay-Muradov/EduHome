﻿using EduHome.Models;
using System.Collections.Generic;

namespace EduHome.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public List<Service> Services { get; set; }
        public List<Blog> Blogs { get; set; }
        public List<Course> Courses { get; set; }
        public  About About { get; set; }




    }
}
