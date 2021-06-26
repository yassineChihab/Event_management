﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Http;
using CoreMigration.Models;

namespace CoreMigration.Controllers
{
    public class BDEController : Controller
    {
        private readonly ConnectionDbClass _context;

        public BDEController(ConnectionDbClass context)
        {
            _context = context;
        }

        public ActionResult Index()
        {
            if (HttpContext.Session.GetString("bde_id") != null)
            {
                return View();
            }
            return RedirectToAction("Login");
        }

        public ActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Login(string name, string password)
        {
            var x = _context.BDEs.ToList();

            if (!string.IsNullOrEmpty(name) && string.IsNullOrEmpty(password))
            {
                return RedirectToAction("Login");
            }
            foreach (var ad in x)
            {
                if (ad.email == name && ad.password == password)
                {
                    HttpContext.Session.SetString("name", name);
                    HttpContext.Session.SetString("bde_id", Convert.ToString(ad.id));
                   
                    ViewBag.MySession = HttpContext.Session.GetString("name");
                    return View("Index");
                }
            }
            ViewBag.MyMsg = "mot de pass ou l'email est pas correct";
            return View();
        }

        public ActionResult About()
        {
            
            if (HttpContext.Session.GetString("bde_id") != null)
            {
                ViewBag.Message = "Your application description page.";

                return View();
            }
            return RedirectToAction("Login");

        }

        public ActionResult Contact()
        {
            if (HttpContext.Session.GetString("bde_id") != null)
            {
                ViewBag.Message = "Your contact page.";

                return View();
            }
            return RedirectToAction("Login");

        }


        public ActionResult Events()
        {
            if (HttpContext.Session.GetString("bde_id") != null)
            {
                int i = int.Parse(HttpContext.Session.GetString("bde_id"));
                var x = _context.activites.Where(p => p.BDE == i).ToList();
                return View(x);
            }
            return RedirectToAction("Login");
        }

        [HttpPost]
        public async Task<IActionResult> Add_event(string titre, string description, DateTime event_date, IFormFile file)
        {
            if (HttpContext.Session.GetString("bde_id") != null)
            {
                using (var transaction = _context.Database.BeginTransaction())
                {
                    try
                    {
                        Activite v = new Activite();
                        //image
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

                        v.titre = titre;
                        v.description = description;
                        v.state = "disable";
                        v.date = event_date;
                        v.BDE = int.Parse(HttpContext.Session.GetString("bde_id"));
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
                        return RedirectToAction("Events");
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Console.WriteLine("Error occurred.", ex);
                    }
                }
            }

            return RedirectToAction("Login");
        }



        public ActionResult add_event_page()
        {
            if (HttpContext.Session.GetString("bde_id") != null)
            {
                return View();
            }
            return RedirectToAction("Login");
        }
        [HttpGet]
        public ActionResult LogOut()
        {
            if (HttpContext.Session.GetString("name") == null)
            {
                return Redirect("/Evenement/page_home");
            }
            HttpContext.Session.SetString("name", null);
            return Redirect("/Evenement/page_home");

        }
    }
}
