using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Syring.DAL;
using Syring.ViewModels.Doctor;
using System;

namespace Syring.Controllers
{
    public class DoctorController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public DoctorController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<IActionResult> Index()
        {
            var doctorComponent = await _appDbContext.DoctorComponents.ToListAsync();
            var model = new DoctorIndexViewModel
            {
                DoctorComponents = doctorComponent
            };
            return View(model);
        }
    }
}
