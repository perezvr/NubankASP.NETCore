using Microsoft.AspNetCore.Mvc;

namespace Nubank_ASP.NET_Core.Controllers
{
    public class FileController : Controller
    {
        public IActionResult ImportFile([FromForm] FileUploadViewModel model)
        {
            return View();
        }

        [HttpPost]
        [Route("upload")]
        public async Task<IActionResult> Upload([FromForm] FileUploadViewModel model, [FromForm] string member_code)
        {
            var file = model.File;

            // ...
        }
    }
}
