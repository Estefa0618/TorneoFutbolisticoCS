using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbolistico.App.Persistencia;
using TorneoFutbolistico.App.Dominio;

namespace TorneoFutbolistico.App.Frontend.Pages.Partidos
{
    public class CreateModel : PageModel
    {
        private readonly IRepositorioPartido _repoPartido;
        public Partido partido {get; set;}
        public CreateModel(IRepositorioPartido repoPartido)
        {
            _repoPartido = repoPartido;
        }
        public void OnGet()
        {
            partido = new Partido();
        }
        public IActionResult OnPost(Partido partido)
        {
            _repoPartido.AddPartido(partido);   
            return RedirectToPage("Index");
           
            
        }
    }
}
