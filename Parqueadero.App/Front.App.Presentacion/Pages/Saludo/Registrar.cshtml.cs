using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Parqueadero.App.Dominio;
using Parqueadero.App.Persistencia;

namespace Front.App.Presentacion.Pages.Saludo
{
    public class Registrar : PageModel
    {
        private static IRepositorio _repoPersona = new Repositorio(new Parqueadero.App.Persistencia.AppContext());

        private readonly ILogger<Registrar> _logger;

        public Registrar(ILogger<Registrar> logger)
        {
            _logger = logger;
        }
        [BindProperty]

        public Persona personas { get; set; }
        // public Vehiculo carro { get; set; }

        public void OnGet()
        {
        }
// async Task<IActionResult>
        public void OnPost()
        {
            if (personas != null)
            {
               _repoPersona.AddPersona(personas);
            //    return RedirectToPage("/Saludo/login");

            }
            // else
            // {
            //    return Page();
            // }


            // return RedirectToPage("/Saludo/login");    
        }

    }
}