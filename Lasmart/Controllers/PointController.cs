using Lasmart.DataService;
using Microsoft.AspNetCore.Mvc;

namespace Lasmart.Controllers
{
    public class PointController : Controller
    {
        public DataManager _dataManager;

        public PointController(DataManager dataManager)
        {
            _dataManager = dataManager;
        }
        public IActionResult Index()
        {
            var points = _dataManager.PointService.GetPoints();
            return View(points);
        }

        [HttpPost]
        public async Task<IActionResult> Index(Guid id) 
        {
            await _dataManager.PointService.RemovePointAsync(id);
            return RedirectToAction("Index");
        }
    }
}
