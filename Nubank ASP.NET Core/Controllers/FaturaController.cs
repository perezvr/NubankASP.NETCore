using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nubank_ASP.NET_Core.Models;
using NubankCore.Repositories.Interfaces;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Nubank_ASP.NET_Core.Controllers
{
    public class
        FaturaController : Controller
    {
        private readonly IFaturaRepository _faturaRepository;

        public FaturaController(IFaturaRepository faturaRepository)
        {
            this._faturaRepository = faturaRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public async Task<IActionResult> Upload(IFormFile files)
        {
            var x = await _faturaRepository.GerarFatura(files, DateTime.Now, DateTime.Now);

            //long size = files.Sum(f => f.Length);

            //var filePaths = new List<string>();
            //foreach (var formFile in files)
            //{
            //    if (formFile.Length > 0)
            //    {
            //        // full path to file in temp location
            //        var filePath = Path.GetTempFileName(); //we are using Temp file name just for the example. Add your own file path.
            //        filePaths.Add(filePath);
            //        using (var stream = new FileStream(filePath, FileMode.Create))
            //        {
            //            await formFile.CopyToAsync(stream);
            //        }
            //    }
            //}
            //// process uploaded files
            //// Don't rely on or trust the FileName property without validation.
            return Ok();
        }
    }
}
