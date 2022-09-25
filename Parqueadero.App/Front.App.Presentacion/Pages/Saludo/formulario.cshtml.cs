using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Front.App.Presentacion.Pages.Saludo
{
    public class formulario : PageModel
    {
        private readonly ILogger<formulario> _logger;

        public formulario(ILogger<formulario> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}