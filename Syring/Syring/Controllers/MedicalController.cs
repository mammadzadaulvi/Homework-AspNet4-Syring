using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Syring.DAL;
using Syring.ViewModels.Medical;

namespace Syring.Controllers
{
    public class MedicalController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public MedicalController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<IActionResult> Index()
        {
            var medicalComponent = await _appDbContext.MedicalComponents.ToListAsync();

            var model = new MedicalIndexViewModel
            {
                MedicalComponents = medicalComponent
            };
            return View(model);
        }
    }
}
