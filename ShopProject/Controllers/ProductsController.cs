using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shop.Models;
using ShopProject.Data;

namespace ShopProject.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ShopProjectContext _context;

        public ProductsController(ShopProjectContext context)
        {
            _context = context;
        }

        // GET: Products
        public async Task<IActionResult> Index()
        {
            return View(await _context.Product.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> Search(string product)
        {
            var products = _context.Product.Where(p => p.Name.Contains(product)).OrderBy(p => p.Name);
            return View("../Products/Index", await products.ToListAsync());
        }


        // GET: Products/Create
        public IActionResult Create()
        {
            if (HttpContext.Session.GetString("userName") == null || !HttpContext.Session.GetString("userName").Equals("admin"))
            {
                return View("../Products/Index", _context.Product);
            }
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Desc,Price,ImgURL")] Product product)
        {
            if (HttpContext.Session.GetString("userName") == null || !HttpContext.Session.GetString("userName").Equals("admin"))
            {
                return View("../Products/Index", _context.Product);
            }
            if (ModelState.IsValid)
            {
                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: Products/Create
        public IActionResult Edit()
        {
            if (HttpContext.Session.GetString("userName") == null || !HttpContext.Session.GetString("userName").Equals("admin"))
            {
                return View("../Products/Index", _context.Product);
            }
            return View();
        }


        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Desc,Price,ImgURL")] Product product)
        {
            if (HttpContext.Session.GetString("userName") == null || !HttpContext.Session.GetString("userName").Equals("admin"))
            {
                return View("../Products/Index", _context.Product);
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (HttpContext.Session.GetString("userName") == null || !HttpContext.Session.GetString("userName").Equals("admin"))
            {
                return View("../Products/Index", _context.Product);
            }

            var product = await _context.Product
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (HttpContext.Session.GetString("userName") == null || !HttpContext.Session.GetString("userName").Equals("admin"))
            {
                return View("../Products/Index", _context.Product);
            }
            var product = await _context.Product.FindAsync(id);
            _context.Product.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.Product.Any(e => e.Id == id);
        }
    }
}
