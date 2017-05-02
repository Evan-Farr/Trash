
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;


[assembly: OwinStartupAttribute(typeof(TrashPickup.Startup))]
namespace TrashPickup
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            CreateRolesAndUsers();
        }

        private void CreateRolesAndUsers()
        {
            Models.ApplicationDbContext context = new Models.ApplicationDbContext();

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var userManager = new UserManager<Models.ApplicationUser>(new UserStore<Models.ApplicationUser>(context));
  
            if (!roleManager.RoleExists("Admin"))
            {
                var role = new IdentityRole();
                role.Name = "Admin";
                roleManager.Create(role);                  
                var user = new Models.ApplicationUser();
                user.UserName = "Evan";
                user.Email = "evan.c.farr@gmail.com";
                string userPassword = "Farr1029!";
                var checkUser = userManager.Create(user, userPassword);
                if (checkUser.Succeeded)
                {
                    var result = userManager.AddToRole(user.Id, "Admin");
                }
            }  
             
            if(!roleManager.RoleExists("Employee"))
            {
                var role = new IdentityRole();
                role.Name = "Employee";
                roleManager.Create(role);
            }

            if (!roleManager.RoleExists("Customer"))
            {
                var role = new IdentityRole();
                role.Name = "Customer";
                roleManager.Create(role);
            }
        }
    }
}
