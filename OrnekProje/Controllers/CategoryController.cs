using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using OrnekProje_DataAcces.Data;
using OrnekProje_Entity.Models;
using System.Collections.Generic;

namespace OrnekProje.Controllers
{
    public class CategoryController : Controller
    {
        private readonly OrnekDbContext _context;

        public CategoryController(OrnekDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Category> arrived = _context.Categories.ToList();    
            return View(arrived);
        }

        public IActionResult Update(int? id)
        {


            Category updateId = new Category();
            if (id == null)
            {
                return View(updateId);
            }

            updateId = _context.Categories.FirstOrDefault(z => z.CategoryId == id);

            if (updateId == null)
            {
                return NotFound();
            }

            _context.SaveChanges();


            return View(updateId);


        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Post(Category updateId)
        {
            if (ModelState.IsValid)
            {
                if(updateId.CategoryId == 0)
                {
                   _context.Categories.Add(updateId);
                }
                else
                {
                    _context.Categories.Update(updateId);

                }
                  
                _context.SaveChanges();
                return RedirectToAction("Index");


            }
            return View(updateId); 
        }
        



    }

          

      
        //public IActionResult Delete(int id)
        //{
        //    var delete = _context.Categories.FirstOrDefault(z => z.CategoryId == id);

        //    _context.Categories.Remove(delete); 
        //    _context.SaveChanges(); 

        //    return RedirectToAction("Index");
        //}
        
        //public IActionResult ManyAdd()
        //{
        //    List<Category> categories = new List<Category>();   

        //    for(int i = 1; i<=3; i++)
        //    {
        //        categories.Add(new Category() { CategoryName = Guid.NewGuid().ToString()});
        //    }

        //    _context.Categories.AddRange(categories);
        //    _context.SaveChanges();

        //     return View
        //        ();
        //}
       
    
}
