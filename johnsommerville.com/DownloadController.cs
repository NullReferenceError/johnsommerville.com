using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace johnsommerville.com
{

    [Route("[controller]/[action]")]
    public class DownloadController : Controller
    {
        private readonly IHostingEnvironment _hostingEnvironment;

        public DownloadController(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Resume()
        {
            var filePath = Path.Combine(_hostingEnvironment.WebRootPath, "John B Sommerville 2019.pdf"); 
            if (!System.IO.File.Exists(filePath))
            {
                throw new Exception($"Resume at this filePath does not exist: {filePath}");
            }

            var fileBytes = System.IO.File.ReadAllBytes(filePath);

            var response = new FileContentResult(fileBytes, "application/octet-stream")
            {
                FileDownloadName = "JohnSommervilleResume2019.pdf"
            };
            return response;

        }
    }
}
