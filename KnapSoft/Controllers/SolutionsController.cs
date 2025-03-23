using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KnapSoft.Data;
using KnapSoft.Models;
using KnapSoft.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace KnapSoft.Controllers
{
    public class SolutionsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SolutionsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Solutions
        public async Task<IActionResult> Index()
        {
            return View(await _context.Solutions.ToListAsync());
        }

        // GET: Solutions/Details/5
        public IActionResult Details(int id)
        {
            var solution = _context.Solutions
                .Include(s => s.SolutionProducts)
                .ThenInclude(sp => sp.Product)
                .FirstOrDefault(s => s.Id == id);

            if (solution == null) return NotFound();

            return View(solution);
        }
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            var products = _context.Products
                .Select(p => new ProductCheckbox
                {
                    ProductId = p.Id,
                    Name = p.Name
                }).ToList();

            var vm = new SolutionViewModel { Products = products };
            return View(vm);
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult Create(SolutionViewModel vm)
        {
            if (ModelState.IsValid)
            {
                var solution = new Solution
                {
                    Name = vm.Name,
                    Description = vm.Description,
                    Price = vm.Price,
                    MonthlyPrice = vm.MonthlyPrice,
                    SolutionProducts = vm.Products
                        .Where(p => p.IsSelected)
                        .Select(p => new SolutionProduct { ProductId = p.ProductId })
                        .ToList()
                };

                _context.Solutions.Add(solution);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(vm);
        }
        [Authorize(Roles = "Admin")]
        // GET: Solutions/Edit/5
        public IActionResult Edit(int id)
        {
            var solution = _context.Solutions
                .Include(s => s.SolutionProducts)
                .FirstOrDefault(s => s.Id == id);

            if (solution == null) return NotFound();

            var allProducts = _context.Products.ToList();

            var viewModel = new SolutionViewModel
            {
                Id = solution.Id,
                Name = solution.Name,
                Description = solution.Description,
                Price = solution.Price,
                MonthlyPrice = solution.MonthlyPrice,
                Products = allProducts.Select(p => new ProductCheckbox
                {
                    ProductId = p.Id,
                    Name = p.Name,
                    IsSelected = solution.SolutionProducts.Any(sp => sp.ProductId == p.Id)
                }).ToList()
            };

            return View(viewModel);
        }

        // POST: Solutions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult Edit(SolutionViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                return View(vm);
            }

            var solution = _context.Solutions
                .Include(s => s.SolutionProducts)
                .FirstOrDefault(s => s.Id == vm.Id);

            if (solution == null) return NotFound();

            // Update základních údajů
            solution.Name = vm.Name;
            solution.Description = vm.Description;
            solution.Price = vm.Price;
            solution.MonthlyPrice = vm.MonthlyPrice;

            // Odebrání starých vztahů
            solution.SolutionProducts.Clear();

            // Přidání nových vztahů
            foreach (var product in vm.Products.Where(p => p.IsSelected))
            {
                solution.SolutionProducts.Add(new SolutionProduct
                {
                    ProductId = product.ProductId,
                    SolutionId = solution.Id
                });
            }

            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        // GET: Solutions/Delete/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var solution = await _context.Solutions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (solution == null)
            {
                return NotFound();
            }

            return View(solution);
        }

        // POST: Solutions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var solution = await _context.Solutions.FindAsync(id);
            if (solution != null)
            {
                _context.Solutions.Remove(solution);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SolutionExists(int id)
        {
            return _context.Solutions.Any(e => e.Id == id);
        }
    }
}
