using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Parqueadero.App.Dominio;

namespace Front.App.Presentacion.Pages.Saludo
{
    public class Registrar : PageModel
    {
        private readonly ILogger<Registrar> _logger;

        public Registrar(ILogger<Registrar> logger)
        {
            _logger = logger;
        }
        [BindProperty]

        public Persona personas { get; set; }

        public void OnGet()
        {
        }
    }
}