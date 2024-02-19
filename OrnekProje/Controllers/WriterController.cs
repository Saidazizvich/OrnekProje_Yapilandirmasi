using Microsoft.AspNetCore.Mvc;
using OrnekProje_DataAcces.Data;
using OrnekProje_Entity.Models;

namespace OrnekProje.Controllers
{
    public class WriterController : Controller
    {

        private readonly OrnekDbContext _context;

        public WriterController(OrnekDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Writer> writers = new List<Writer>().ToList();  
            return View(writers);
        }

        public IActionResult Update_Insert(int? id)
        {
            var update = _context.Writers.FirstOrDefault(x=>x.WriterId == id);

            if (update != null)
            {
                _context.Writers.Update(update);
            }
            else
            {
                 return NotFound(); 
            }

            _context.SaveChanges();

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update_Insert(Writer writer)
        {
            if (ModelState.IsValid)
            {
               if(writer.WriterId == 0)
               {
                    _context.Writers.Add(writer);     
               }
               else
               {
                    _context.Writers.Update(writer);  
               }
               _context.SaveChanges();
                return RedirectToAction("Index");   
            }

            return View();
        }

        public IActionResult Delete(int id)
        {
             var delet = _context.Writers.FirstOrDefault(x=>x.WriterId==id); 

               _context.Writers.Remove(delet);

            _context.SaveChanges();

            return View();
        }
    }
}
