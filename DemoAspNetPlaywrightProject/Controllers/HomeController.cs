using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.Playwright;

namespace DemoAspNetPlaywrightProject.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            using (var playwright = await Playwright.CreateAsync())
            {
                var browser = await playwright.Webkit.LaunchAsync();
                var page = await browser.NewPageAsync();
                await page.GotoAsync("https://github.com/microsoft/playwright");
                await page.ScreenshotAsync(new PageScreenshotOptions { Path = "screenshot.png" });
                await browser.DisposeAsync();
            }

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}