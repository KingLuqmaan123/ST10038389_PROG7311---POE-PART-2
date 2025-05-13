using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ST10038389_PROG7311___POE_PART_2.Models;
using System.Collections.Generic;
using System.Linq;

namespace ST10038389_PROG7311___POE_PART_2.Controllers
{
    //Product Controller Constructors:
    public class ProductsController : Controller
    {
        //Products in listed form to list the number of products added onto the system.
        private static readonly List<Product> productList = [];
        private static int nextId = 1;

        //GET: Products
        public IActionResult Index()
        {
            return View(productList);
        }

        //GET: Products/Create
       
        public IActionResult Create()
        {
            return View();
        }
        //POST: Product goes through multifunction operation, checking if Products were added successfully or it failed to collect on DB.
        [HttpPost]
        [ValidateAntiForgeryToken]
       
        public IActionResult Create([Bind("Name,Category,ProductionDate")] Product product)
        {
            if (ModelState.IsValid)
            {
                product.Id = nextId++;
                product.FarmerId = 1;
                productList.Add(product);

                TempData["SuccessMessage"] = "Product added successfully!"; //Pop-Up Message to clarify results collected.
                return RedirectToAction(nameof(Index));
            }

            TempData["ErrorMessage"] = "Failed to add product. Please check your input.";
            return View(product);
        }

        //Action Control for Product Details, showing a brief description of each product.
        public IActionResult Details(int? id)
        {
            if (id == null)
                return NotFound();

            var product = productList.FirstOrDefault(p => p.Id == id);
            if (product == null)
                return NotFound();

            return View(product);
        }
        //Users can edit the products.
        public IActionResult Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var product = productList.FirstOrDefault(p => p.Id == id);
            if (product == null)
                return NotFound();

            return View(product);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,Name,Category,ProductionDate,FarmerId")] Product product)
        {
            var existingProduct = productList.FirstOrDefault(p => p.Id == id);
            if (existingProduct == null)
                return NotFound();

            if (ModelState.IsValid)
            {
                existingProduct.Name = product.Name;
                existingProduct.Category = product.Category;
                existingProduct.ProductionDate = product.ProductionDate;

                TempData["SuccessMessage"] = "Product updated successfully!";
                return RedirectToAction(nameof(Index));
            }

            TempData["ErrorMessage"] = "Update failed. Please check input.";
            return View(product);
        }
    }
}
//----------------------------------------------- END OF FILE-------------------------------------------------------------------------