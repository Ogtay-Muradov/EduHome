﻿using EduHome.DAL;
using EduHome.Models;
using EduHome.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;
        public HomeController(AppDbContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> Index()
        {



            HomeVM homeVM = new HomeVM
            {
                Sliders = await _db.Sliders.Where(x => !x.IsDeactive).ToListAsync(),
                About =await _db.Abouts.FirstAsync(),
                Services =await _db.Services.Where(x => !x.IsDeactive).Take(3).OrderByDescending(x => x.Id).ToListAsync(),
                Blogs =await _db.Blogs.Take(3).OrderByDescending(x => x.Id).ToListAsync(),
                Courses =await _db.Courses.Take(3).OrderByDescending(x => x.Id).ToListAsync(),

            };
            return View(homeVM);
        }






        public IActionResult Error()
        {

            return View();
        }




    }
}
