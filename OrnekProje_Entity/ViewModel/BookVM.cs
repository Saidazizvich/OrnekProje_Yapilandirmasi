using Microsoft.AspNetCore.Mvc.Rendering;
using OrnekProje_Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrnekProje_Entity.ViewModel
{
	public class BookVM
	{
        public Book Book { get; set; }

		public IEnumerable<SelectListItem> PublishList  { get; set; }
    }
}
