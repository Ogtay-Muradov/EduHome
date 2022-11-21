using EduHome.DAL;
using EduHome.Models;
using EduHome.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace EduHome.ViewComponents
{
    public class FooterViewComponent : ViewComponent
    {
        private readonly AppDbContext _db;
        public FooterViewComponent(AppDbContext db)
        {
            _db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {

            FooterVM footerVM = new FooterVM
            {
                Bio = await _db.Bios.FirstAsync(),
                SocialMedias = await _db.SocialMedias.ToListAsync(),
            };
            return View(footerVM);
        }
    }
    

    
}






