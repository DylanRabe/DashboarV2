using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DashboardV2.Data;
using DashboardV2.Models;


namespace DashboardV2.Pages.Candidats
{
    public class IndexModel : PageModel
    {

        private readonly CandidatDbContext _context;
        public IndexModel(CandidatDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> OnPost()
        {
            //validation pour savoir si le model est valid(coté server)
            if (!ModelState.IsValid) return Page();

            Candidat.Complet = DateTime.Now;
            await _context.Candidats.AddAsync(Candidat);
            await _context.SaveChangesAsync();

            return RedirectToPage("../Index");
        }

        //processus qui prend les valeurs de Http et les maps à nos methodes
        [BindProperty]

        //enregistrera les nouveau candidat
        public Candidat Candidat { get; set; }
    }
}
