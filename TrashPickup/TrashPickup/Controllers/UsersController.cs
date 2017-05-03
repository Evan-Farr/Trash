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
    [Authorize]
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult Index()
        {
            if(User.Identity.IsAuthenticated)
            {
                var user = User.Identity;
                ViewBag.Name = user.Name;
                ViewBag.displayMenu = "No";
                ApplicationDbContext db = new ApplicationDbContext();
                if (isUser("Admin"))
                {
                    ViewBag.displayMenu = "Yes";
                }else if (isUser("Customer"))
                {
                    string holder = user.GetUserId();
                    var temp = db.Customers.Where(i => i.userId.Id == holder).FirstOrDefault().Id;
                    ViewBag.Id = temp;
                    ViewBag.displayMenu = "Customer";
                }else if (isUser("Employee"))
                {
                    string holder = user.GetUserId();
                    var temp = db.Employees.Where(i => i.userId.Id == holder).FirstOrDefault().Id;
                    ViewBag.Id = temp;
                    ViewBag.displayMenu = "Employee";
                }
                return View();
            }
            else
            {
                ViewBag.Name = "Not Logged In";
            }
            return View();
        }

        public bool isUser(string role)
        {
            if(User.Identity.IsAuthenticated)
            {
                var user = User.Identity;
                ApplicationDbContext context = new ApplicationDbContext();
                var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
                var s = UserManager.GetRoles(user.GetUserId());
                if(s[0].ToString() == role)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}