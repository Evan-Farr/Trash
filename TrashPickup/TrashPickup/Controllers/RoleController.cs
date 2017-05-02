using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrashPickup.Models;

namespace TrashPickup.Controllers
{
    public class RoleController : Controller
    {
        // GET: Role
        public ActionResult Index()
        {
            ApplicationDbContext context = new ApplicationDbContext();
            //if (User.Identity.IsAuthenticated)
            //{
            //    if (!User.IsInRole("Admin"))
            //    {
            //        return RedirectToAction("Index", "Home");
            //    }
            //}
            //else
            //{
            //    return RedirectToAction("Index", "Home");
            //}
            var Roles = context.Roles.ToList();
            return View(Roles);
        }
    }
}