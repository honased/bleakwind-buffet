/*
 * Author: Eric Honas
 * Class name: Privacy.cshtml.cs
 * Purpose: Class used for representing the model behind the privacy page.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Website.Pages
{
    /// <summary>
    /// A class that acts as the model for the Privacy page.
    /// </summary>
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        /// <summary>
        /// Creates a new PrivacyModel.
        /// </summary>
        /// <param name="logger">The logger to use.</param>
        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// A method that runs on a get request.
        /// </summary>
        public void OnGet()
        {
        }
    }
}
