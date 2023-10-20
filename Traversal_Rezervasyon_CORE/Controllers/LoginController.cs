using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Traversal_Rezervasyon_CORE.Models;

namespace Traversal_Rezervasyon_CORE.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly  UserManager<AppKullanici> _userManager;
        private readonly SignInManager<AppKullanici> _signInManager;

        public LoginController(UserManager<AppKullanici> userManager, SignInManager<AppKullanici> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(KullaniciRegisterViewModel k)
        {
            AppKullanici appKullanici = new AppKullanici()
            {
                Name = k.Name,
                Surname = k.Surname,
                Email = k.Mail,
                UserName = k.Username
            };
            if (k.Password == k.ConfirmPassword)
            {
                var result = await _userManager.CreateAsync(appKullanici, k.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("SignIn");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View(k);
        }
        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignIn(KullaniciSignInViewModel p)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(p.username, p.password, false, true);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index","Profile",new { area = "Member" });
                }
                else
                {
                    return RedirectToAction("SignIn", "Login");
                }
            }
            return View();
        }
    }
}
