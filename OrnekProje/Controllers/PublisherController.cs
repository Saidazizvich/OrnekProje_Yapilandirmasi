using Microsoft.AspNetCore.Mvc;
using OrnekProje_DataAcces.Data;
using OrnekProje_Entity.Models;

namespace OrnekProje.Controllers
{
    public class PublisherController : Controller
    {
        private readonly OrnekDbContext _context;

        public PublisherController(OrnekDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Publisher> publishers = _context.Publishers.ToList();     

            return View(publishers);
        }

        public IActionResult Update(int? id)
        {
            Publisher publisher = new Publisher();  
            if (id == null) 
            {
                return View(publisher);
            }

            publisher = _context.Publishers.FirstOrDefault(x => x.PublisherId == id);

            if (publisher == null)
            {
                return NotFound();                
            }
            return View(publisher);
        }

        public IActionResult Delete() 
        {
            return View();  
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("Insert/Writer")]
        public IActionResult Insert(Publisher publisher)
        {
            if (ModelState.IsValid)
            {
                if (publisher.PublisherId == 0 )
                {
                    _context.Publishers.Add(publisher);
                }
                else
                {
                    _context.Publishers.Update(publisher);  
                }

                _context.SaveChanges(); 
                return RedirectToAction("Index");
            }

            return View();
        }


    }
}
