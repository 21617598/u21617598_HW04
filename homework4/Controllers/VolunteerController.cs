using homework4.Models;
using System.Collections.Generic;
using System.IO;
using System.Web.Mvc;

namespace homework4.Controllers
{
    public class VolunteerController : Controller
    {
        // GET: Volunteer
        public ActionResult Volunteer()
        {
            string[] filePaths = Directory.GetFiles(Server.MapPath("~/media"));
            List<volunteer> files = new List<volunteer>();
            foreach (string filePath in filePaths)
            {
                files.Add(new volunteer { FileName = Path.GetFileName(filePath) });
            }
            return View(files);
        }

        public FileResult DownloadFile(string fileName)
        {
            string path = Server.MapPath("~/media") + fileName;
            byte[] bytes = System.IO.File.ReadAllBytes(path);
            return File(bytes, "application/octet-stream", fileName);
        }

        public ActionResult DeleteFile(string fileName)
        {
            string path = Server.MapPath("~/media") + fileName;
            byte[] bytes = System.IO.File.ReadAllBytes(path);
            System.IO.File.Delete(path);
            return RedirectToAction("volunteer");
        }

    }
}