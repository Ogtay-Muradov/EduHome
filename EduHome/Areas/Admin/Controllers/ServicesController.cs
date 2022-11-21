using EduHome.DAL;
using EduHome.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ServicesController : Controller
    {
        private readonly AppDbContext _db;
        public ServicesController(AppDbContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> Index()
        {

            List<Service> services = await _db.Services.Where(x => !x.IsDeactive).ToListAsync();
            return View(services);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(Service service)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            bool isExist = await _db.Services.AnyAsync(X => X.Name == service.Name);
            if (isExist)
            {
                ModelState.AddModelError("Name", "The service with this name is already exist!");
                return View();
            }
            await _db.Services.AddAsync(service);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Service service = await _db.Services.FirstOrDefaultAsync(x => x.Id == id);
            if (service == null)
            {
                return BadRequest();

            }

            return View(service);
        }
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Service service = await _db.Services.FirstOrDefaultAsync(x => x.Id == id);
            if (service == null)
            {
                return BadRequest();

            }
            service.IsDeactive = true;
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }









        public async Task<IActionResult> Update(int? id)
        {
            if (id==null)
            {
                return NotFound();
            }
            Service service=await _db.Services.FirstOrDefaultAsync(x => x.Id == id);
            if (service == null)
            {
                return BadRequest();
            }
            return View(service);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Service service)
        {
            if (id==null)
            {
                return NotFound();


            }
            Service dbservice= await _db.Services.FirstOrDefaultAsync(x => x.Id == id);
            if (dbservice==null)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return View(dbservice);
            }
            bool isExist = await _db.Services.AnyAsync(X => X.Name == service.Name&&X.Id!=id);
            if (isExist)
            {
                ModelState.AddModelError("Name", "The service with this name is already exist!");
                return View(dbservice);
            }
            dbservice.Name = service.Name;
            dbservice.Description=service.Description;
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }
        public async Task<IActionResult> Detail(int? id)
        {
            
            Service service = await _db.Services.FirstOrDefaultAsync(x => x.Id == id);
            return View(service);
        }
    }
}
