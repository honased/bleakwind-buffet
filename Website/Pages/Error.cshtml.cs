/*
 * Author: Eric Honas
 * Class name: Error.cshtml.cs
 * Purpose: Class used for representing the model behind the Error page.
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Website.Pages
{
    /// <summary>
    /// A class that acts as a model for the Error Page.
    /// </summary>
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public class ErrorModel : PageModel
    {
        /// <summary>
        /// The request id.
        /// </summary>
        public string RequestId { get; set; }

        /// <summary>
        /// Whether to show the request id or not.
        /// </summary>
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        private readonly ILogger<ErrorModel> _logger;

        /// <summary>
        /// Creates a new Error Model.
        /// </summary>
        /// <param name="logger">The logger to use.</param>
        public ErrorModel(ILogger<ErrorModel> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// A method that runs on a get request.
        /// </summary>
        public void OnGet()
        {
            RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
        }
    }
}
