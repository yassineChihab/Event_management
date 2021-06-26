using CoreMigration.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMigration.Controllers
{
    public class HomeController : Controller
    {
        private readonly ConnectionDbClass _context;

        public HomeController(ConnectionDbClass context)
        {
            _context = context;
        }
        public ActionResult Index()
        {
            if (HttpContext.Session.GetString("Admin") == null)
            {
                return Redirect("/Evenement/page_home");
            }
            ViewData["nbrEvents"] = _context.activites.Count();
            ViewData["nbrImages"] = _context.galleries.Count();
            ViewData["nbrLauriat"] = _context.laureats.Count();
            return View();
        }

        public ActionResult Events()
        {
            if (HttpContext.Session.GetString("Admin") == null)
            {
                return Redirect("/Evenement/page_home");
            }

            return View(_context.activites.ToList());
        }

        [HttpPost]
        public async Task<IActionResult> Add_event(string titre, string description, DateTime event_date, IFormFile file)
        {

            if (HttpContext.Session.GetString("Admin") == null)
            {
                return Redirect("/Evenement/page_home");
            }
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {

                    //Console.WriteLine(titre + " " + description + " image : " + file.FileName);
                    Activite v = new Activite();
                    gallerie g = new gallerie();

                    v.titre = titre;
                    v.description = description;
                    v.state = "disable";
                    event_date = event_date.Date;
                    v.date = event_date;
                    int last_id;
                    if (_context.activites.OrderByDescending(u => u.id).FirstOrDefault() == null)
                    {
                        last_id = 1;
                    }
                    else
                    {
                        last_id = _context.activites.OrderByDescending(u => u.id).FirstOrDefault().id + 1;
                    }
                    if (file == null || file.Length == 0)
                        return Content("file not selected");

                    var path = Path.Combine(Directory.GetCurrentDirectory(), "images", "ActivitieImage" + +last_id + ".png");
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }

                    v.piece_joint = "../../images/ActivitieImage" + last_id + ".png";


                    _context.activites.Add(v);
                    _context.SaveChanges();

                    _context.galleries.Add(new gallerie()
                    {
                        path = v.piece_joint,
                        date = v.date,
                        type = "image",
                        id_activite = last_id
                    });
                    _context.SaveChanges();

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    Console.WriteLine("Error occurred.", ex);
                }
            }
            return RedirectToAction("Events");
        }

        [HttpPost]
        public async Task<IActionResult> modifier_event(int id, string titre, string description, DateTime event_date, IFormFile file)
        {
            if (HttpContext.Session.GetString("Admin") == null)
            {
                return Redirect("/Evenement/page_home");
            }
            Activite v = _context.activites.Find(id);
            v.titre = titre;
            v.description = description;
            if (event_date != null)
            {
                v.date = event_date;
            }
            if (file != null)
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "images", "ActivitieImage" + +id + ".png");
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
                v.piece_joint = "../../images/ActivitieImage" + id + ".png";
            }

            _context.Entry(v).State = (Microsoft.EntityFrameworkCore.EntityState)EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction("Events");
        }

        public ActionResult delete_event(int id)
        {
            if (HttpContext.Session.GetString("Admin") == null)
            {
                return Redirect("/Evenement/page_home");
            }
            if (HttpContext.Session.GetString("Admin") == null)
            {
                return Redirect("/Evenement/page_home");
            }
            Activite v = _context.activites.Find(id);
            _context.activites.Remove(v);
            _context.SaveChanges();
            return RedirectToAction("Events");

        }

        public ActionResult show_event(int id)
        {
            if (HttpContext.Session.GetString("Admin") == null)
            {
                return Redirect("/Evenement/page_home");
            }

            Activite etu = _context.activites.Find(id);
            _context.activites.Find(id).state = "enable";
            _context.Entry(etu).State = (Microsoft.EntityFrameworkCore.EntityState)EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction("Events");

        }

        public ActionResult hide_event(int id)
        {
            if (HttpContext.Session.GetString("Admin") == null)
            {
                return Redirect("/Evenement/page_home");
            }

            Activite etu = _context.activites.Find(id);
            _context.activites.Find(id).state = "disable";
            _context.Entry(etu).State = (Microsoft.EntityFrameworkCore.EntityState)EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction("Events");

        }
        public ActionResult modifier_event_page(int id)
        {
            if (HttpContext.Session.GetString("Admin") == null)
            {
                return Redirect("/Evenement/page_home");
            }
           
            Activite etu = _context.activites.Find(id);
            ViewData["modifie"] = etu;
            return View();

        }
        public ActionResult add_event_page()
        {
            if (HttpContext.Session.GetString("Admin") == null)
            {
                return Redirect("/Evenement/page_home");
            }
            return View(new FileUpload());
        }
        public ActionResult add_gallerie_page()
        {
            if (HttpContext.Session.GetString("Admin") == null)
            {
                return Redirect("/Evenement/page_home");
            }
          
            var ActivitieList = _context.activites.ToList();
            ViewBag.ActivitieList = new SelectList(ActivitieList, "id", "titre");
            return View();
        }
        public ActionResult Laureats()
        {
            if (HttpContext.Session.GetString("Admin") == null)
            {
                return Redirect("/Evenement/page_home");
            }
           
            var filiereList = _context.filieres.ToList();
            ViewBag.FiliereList = new SelectList(filiereList, "id", "nom");
            ViewBag.Lauret = _context.laureats.ToList();
            return View();
        }

        [HttpPost]
        public ActionResult Add_Laureat(laureat laureat)
        {
            if (HttpContext.Session.GetString("Admin") == null)
            {
                return Redirect("/Evenement/page_home");
            }
            try
            {
                
                laureat.state = "admin";
                laureat.password = "12345678";
                _context.laureats.Add(laureat);
                _context.SaveChanges();
                return View();

            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Debug.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Debug.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
        }

        public ActionResult delete_laureat(int id)
        {
            if (HttpContext.Session.GetString("Admin") == null)
            {
                return Redirect("/Evenement/page_home");
            }
   
            laureat l = _context.laureats.Find(id);

            _context.laureats.Remove(l);
            _context.SaveChanges();
            return RedirectToAction("Laureats");

        }
        [HttpGet]
        public ActionResult LogOut()
        {
            if (HttpContext.Session.GetString("Admin") == null)
            {
                return Redirect("/Evenement/page_home");
            }
            HttpContext.Session.SetString("Admin", null);

            return Redirect("/Evenement/page_home");

        }
        [HttpPost]
        public async Task<IActionResult> Add_gal(string titr, int titre, DateTime event_date, IFormFile file)
        {
            if (HttpContext.Session.GetString("Admin") == null)
            {
                return Redirect("/Evenement/page_home");
            }
           
            gallerie g = new gallerie();
            int last_id;
            if (_context.galleries.OrderByDescending(u => u.id).FirstOrDefault() == null)
            {
                last_id = 1;
            }
            else
            {
                last_id = _context.galleries.OrderByDescending(u => u.id).FirstOrDefault().id + 1;
            }
            if (file == null || file.Length == 0)
                return Content("file not selected");

            var path = Path.Combine(Directory.GetCurrentDirectory(), "images", "gallerieImage" + +last_id + ".png");
            using (var stream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            
            g.path = "../../images/gallerieImage" + last_id + ".png";
            g.date = event_date;
            g.type = titr;
            g.id_activite = titre;

            _context.galleries.Add(g);
            _context.SaveChanges();

            return RedirectToAction("gallerieList");
        }
        public ActionResult gallerieList()
        {
            if (HttpContext.Session.GetString("Admin") == null)
            {
                return Redirect("/Evenement/page_home");
            }
      
            List<Activite> teachers = _context.activites.ToList();
            ViewData["listgallerie"] = teachers;
            return View();
        }
        public ActionResult gallerieListImages(int id)
        {
            if (HttpContext.Session.GetString("Admin") == null)
            {
                return Redirect("/Evenement/page_home");
            }

            HttpContext.Session.SetString("id_gallerie", Convert.ToString(id));
            List<gallerie> teachers = _context.galleries.Where(u => u.id_activite == id).ToList();
            ViewData["listgallerie"] = teachers;
            return View();
        }
        public ActionResult delet_gallerie(int id)
        {

            if (HttpContext.Session.GetString("Admin") == null)
            {
                return Redirect("/Evenement/page_home");
            }
            gallerie v = _context.galleries.Find(id);
            _context.galleries.Remove(v);
            _context.SaveChanges();
            return RedirectToAction("gallerieListImages/" + int.Parse(HttpContext.Session.GetString("id_gallerie")));

        }
    }
}
