using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbolistico.App.Persistencia;
using TorneoFutbolistico.App.Dominio;


namespace TorneoFutbolistico.App.Frontend.Pages.Municipios
{
    public class CreateModel : PageModel
    {
        private readonly IRepositorioMunicipio _repoMunicipio;
        public Municipio municipio {get; set;}
        public CreateModel(IRepositorioMunicipio repoMunicipio)
        {
            _repoMunicipio = repoMunicipio;
        }
        public void OnGet()
        {
            municipio = new Municipio();
        }
        public IActionResult OnPost(Municipio municipio)
        {
            _repoMunicipio.AddMunicipio(municipio);   
            return RedirectToPage("Index");
           
            
        }
    }
}
