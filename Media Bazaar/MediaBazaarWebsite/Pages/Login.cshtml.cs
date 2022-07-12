using LogicLayer;
using Media_Bazaar;
using MediaBazaarWebsite.DTOs;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace MediaBazaarWebsite.Pages
{
    public class LoginModel : PageModel
    {
        EmployeeAdmin mediaBazarEmployees = new EmployeeAdmin();

        [BindProperty]
        public LoginDTO LoggedUser { get; set; }
        Employee employeeLogin;


        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                mediaBazarEmployees.UpdateEmployeeLists();
                employeeLogin = mediaBazarEmployees.ReturnEmployee(LoggedUser.UserName);

                string employeePassword = Hasher.PasswordHasher(LoggedUser.Password + employeeLogin.Salt);
                if (employeeLogin.Password == employeePassword)
                {
                    SetupSessionCookie();
                    TempData["Success"] = "You are loggedin";
                    return new RedirectToPageResult("Index");
                }
                else
                {
                    TempData["Danger"] = "There is something wrong";
                    return new PageResult();
                }
            }

            return new PageResult();
            
        }
        private void SetupSessionCookie()
        {
            var claims = new List<Claim> {
                new Claim( ClaimTypes.Name, employeeLogin.UserName)                
            };
           
            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identity);
            HttpContext.SignInAsync(claimsPrincipal); // this line create the cookie 
        }


    }
}
