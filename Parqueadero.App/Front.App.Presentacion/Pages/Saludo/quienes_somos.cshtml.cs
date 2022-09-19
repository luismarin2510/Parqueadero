using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Front.App.Presentacion.Pages.Saludo
{
    public class quienes_somos : PageModel
    {
        private readonly ILogger<quienes_somos> _logger;

        public quienes_somos(ILogger<quienes_somos> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}