using Microsoft.AspNetCore.Mvc;
using MvcTemplateNoteManager.Context;

namespace MvcTemplateNoteManager.Controllers
{
    public class NoteController : Controller
    {
        private readonly NoteManagerContext _context;

        public NoteController(NoteManagerContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Notes);
        }
    }
}
