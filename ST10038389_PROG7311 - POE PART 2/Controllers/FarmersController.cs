using Microsoft.AspNetCore.Mvc;
using ST10038389_PROG7311___POE_PART_2.Data;
using ST10038389_PROG7311___POE_PART_2.Models;

public class FarmersController : Controller
{
    //Farmer Controller  that controls and connects data to the database.
    //Constructor that receives the ApplicationDbContext to interact with the database.
    private readonly ApplicationDbContext _context;
    public FarmersController(ApplicationDbContext context)
    {
        _context = context;
    }
    //GET: Farmers display list of all Farmers.
    public IActionResult Index()
    {
        var farmers = _context.Farmers.ToList();
        ViewBag.Farmers = farmers;
        return View(new Farmer()); 
    }
    //GET: Farmers/Create or show a form to create a new farmer on the system.
    [HttpPost]
    public IActionResult Create(Farmer farmer)
    {
        if (ModelState.IsValid)
        {
            _context.Farmers.Add(farmer); //Add New Farmer
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        ViewBag.Farmers = _context.Farmers.ToList(); //Find Farmer by ID.
        return View("Index", farmer); 
    }
}
//---------------------------------------- END OF FILE --------------------------------------------------------------------