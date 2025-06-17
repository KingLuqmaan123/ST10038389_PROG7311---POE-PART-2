using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ST10038389_PROG7311_PART_2_OF_POE.Models;
using ST10038389_PROG7311_PART_2_OF_POE.Services;

namespace ST10038389_PROG7311_PART_2_OF_POE.Controllers
{
    //New Controller called Employee Controller.
    //The EmployeeController collects all the Employee data.
    [Authorize(Roles = "Admin")]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public async Task<IActionResult> Index()
        {
            var employees = await _employeeService.GetAllAsync();
            return View(employees);
        }

        public async Task<IActionResult> Details(int id)
        {
            var employee = await _employeeService.GetByIdAsync(id);
            if (employee == null) return NotFound();
            return View(employee);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                await _employeeService.AddAsync(employee);
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var employee = await _employeeService.GetByIdAsync(id);
            if (employee == null) return NotFound();
            return View(employee);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                await _employeeService.UpdateAsync(employee);
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var employee = await _employeeService.GetByIdAsync(id);
            if (employee == null) return NotFound();
            return View(employee);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _employeeService.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
//------------------------------------------------ END OF FILE --------------------------------------------------------------------------------

