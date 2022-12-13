using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PustokLayout.DAL;
using PustokLayout.Models;
using PustokLayout.ViewModels;
using System.Data;

namespace PustokLayout.Controllers
{
    public class AccountController : Controller
    {
        private readonly PustokContext _pustokContext;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public AccountController(PustokContext pustokContext, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _pustokContext = pustokContext;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(MemberLoginViewModel memberVM, string returnUrl)
        {
            AppUser user = await _userManager.FindByNameAsync(memberVM.Username);

            if (user == null)
            {
                ModelState.AddModelError("", "Username or Password is incorrect!");
                return View();
            }

            var roles = await _userManager.GetRolesAsync(user);

            if (!roles.Contains("Member"))
            {
                ModelState.AddModelError("", "Username or Passwrod is incorrect!");
                return View();
            }

            var result = await _signInManager.PasswordSignInAsync(user, memberVM.Password, false, true);

            if (result.IsLockedOut)
            {
                ModelState.AddModelError("", "Try it in 5 minutes");
                return View();
            }

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Username or Password is incorrect!");
                return View();
            }

            if (returnUrl != null)
                return Redirect(returnUrl);

            return RedirectToAction("index", "home");
        }
        public async Task<IActionResult> Show()
        {
            if (User.Identity.IsAuthenticated)
            {
                AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
                return Content(user.Fullname);
            }
            return Content("logged out");
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(MemberRegisterVM memberVM)
        {
            if (!ModelState.IsValid)
                return View();

            if (await _userManager.FindByNameAsync(memberVM.Username) != null)
            {
                ModelState.AddModelError("Username", "User already exist!");
                return View();
            }
            else if(await _userManager.FindByEmailAsync(memberVM.Email) != null)
            {
                ModelState.AddModelError("Email", "Email already exist!");
                return View();
            }

            AppUser user = new AppUser
            {
                UserName = memberVM.Username,
                Email = memberVM.Email,
                Fullname = memberVM.Fullname,
            };

            var result = await _userManager.CreateAsync(user, memberVM.Password);

            if (!result.Succeeded)
            {
                foreach (var err in result.Errors)
                {
                    ModelState.AddModelError("", err.Description);
                }
                return View();
            }

            return RedirectToAction("login");
        }
        [HttpPost]
        public async Task<IActionResult> Profile(MemberUpdateViewModel memberVM)
        {
            return Ok(memberVM);
        }
    }
}
