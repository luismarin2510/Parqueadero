using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Front.App.Presentacion.Pages.Saludo
{
    public class politicas : PageModel
    {
        private readonly ILogger<politicas> _logger;

        public politicas(ILogger<politicas> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}