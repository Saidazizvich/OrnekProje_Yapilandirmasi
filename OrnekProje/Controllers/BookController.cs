using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OrnekProje_DataAcces.Data;
using OrnekProje_Entity.Models;
using OrnekProje_Entity.ViewModel;
using System.Linq;

namespace OrnekProje.Controllers
{
    public class BookController : Controller
    {
        private readonly OrnekDbContext _context;

        public BookController(OrnekDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Book> books = new List<Book>().ToList();

            foreach (var item in books)
            {
                // uygulanibilr ama serveri acisinden cok verimli degildir ve server cok yorar!!!
                //item.Publisher = _context.Publishers.FirstOrDefault(x => x.PublisherId == item.PublisherId);
                 
                // Eger 1 - 1 ilkisi olursa reference kullaniyoruz ve ve coka cok olursa collection kullaniyoruz
                _context.Entry(item).Reference(a=>a.Publisher).Load();// lazy loadingdir dikkat!!


            }

            return View(books);
        }

        public IActionResult Update_Insert(int? id)
        {

            BookVM bookVM = new BookVM();
            bookVM.PublishList = _context.Publishers.Select( a=> new SelectListItem{
                 Text = a.Name,
                 Value = a.PublisherId.ToString()
            });

            if (id == null)
            {
                return View(bookVM);
            }

           bookVM.Book = _context.Books.FirstOrDefault(x =>x.BookId == id);

            bookVM.Book = _context.Books.Include(a => a.BookDetailId).FirstOrDefault(a => a.BookId == id);// eager loading  islemi yapyoruz include ile

            if (bookVM == null)
            {
                return NotFound();
            }

            return View(bookVM);    

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
		public IActionResult Update_Insert(BookVM bookVM)
        {
            if (ModelState.IsValid)
            {
                if (bookVM.Book.BookId == 0)
                {
                    _context.Books.Add(bookVM.Book);
                }
                else
                {
                    _context.Books.Update(bookVM.Book); 
                }

                _context.SaveChanges();
                return RedirectToAction("Index");   

            }


            return View();
        }

        public IActionResult Delete(int id) 
        {
              var delet = _context.Books.FirstOrDefault( x => x.BookId == id);  
               _context.Books.Remove(delet);
            _context.SaveChanges(); 
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int? id) 
        {
			BookVM bookVM = new BookVM();
			bookVM.PublishList = _context.Publishers.Select(a => new SelectListItem
			{
				Text = a.Name,
				Value = a.PublisherId.ToString()
			});

			if (id == null)
			{
				return View(bookVM);
			}

			bookVM.Book = _context.Books.FirstOrDefault(x => x.BookId == id);
            bookVM.Book.BookDetails = _context.BookDetails.FirstOrDefault(z => z.BookDetailId == bookVM.Book.BookDetailId);
            

			if (bookVM == null)
			{
				return NotFound();
			}

			return View(bookVM);

		      
        }

        [HttpPost]

        public IActionResult Post(BookVM bookVM) 
        {
			if (bookVM.Book.BookDetails.BookDetailId == 0)
			{
				_context.BookDetails.Add(bookVM.Book.BookDetails);
                _context.SaveChanges();

                var bookDb = _context.Books.FirstOrDefault(a=>a.BookId == bookVM.Book.BookId);

                bookDb.BookDetailId = bookVM.Book.BookDetails.BookDetailId;

                _context.SaveChanges();

			}
			else
			{
				_context.BookDetails.Update(bookVM.Book.BookDetails);
                _context.SaveChanges();
			}
			return RedirectToAction("Index");

        }

        public IActionResult Working() 
        {
            IEnumerable<Book> books = _context.Books;
            var filter = books.Where(z => z.Price > 2).ToList(); // burda su on biz sorgunu direkt hafize yapiyoruz ve islem urda gerceklestiriyoruz

            IQueryable<Book> books1 = _context.Books;
            var filter1 = books1.Where(x=>x.Price > 2).ToList(); 
            // burda esa biz direkt olarak database sorgu yapiyoruz ve filter liyouz ve istemicye gonderyoruz response !!!

            return RedirectToAction("Index");
        }
	}
}
