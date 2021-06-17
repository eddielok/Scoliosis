using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Scoliosis.Data;
using Scoliosis.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
namespace Scoliosis.Controllers
{
    public class AccountController : Controller
    {
        private readonly MyContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly IEmailSender _emailSender;
        RoleManager<IdentityRole> _roleManager;


        public AccountController(
            MyContext context,
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            IEmailSender emailSender,
            RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
            _roleManager = roleManager;
        }


        public string Username { get; set; }
        public async Task<IActionResult> Index()
        {
            return View(await _userManager.Users.Select(aspnetuser =>
                new AccountViewModel
                {
                    Name = aspnetuser.UserName
                }).ToListAsync());
        }
        public async Task<IActionResult> Edit(string id)
        {
            var user = await _userManager.FindByNameAsync(id);
            //var user = await _userManager.FindByIdAsync(id);
           // var user =  _userManager.Users.Select(aspuser => id).First();
           //xx var user = await _userManager.GetUserAsync(id);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            var userName = await _userManager.GetUserNameAsync(user);
            var email = await _userManager.GetEmailAsync(user);
            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);

            Username = userName;
            var inputrole = await _userManager.GetRolesAsync(user);
            var name = _roleManager.FindByNameAsync(inputrole.First()).Result;// await _userManager.GetRolesAsync(user);
            ViewData["roles"] = _roleManager.Roles.ToList();
            var Input = new AccountEditModel
            {
                Email = email,
                PhoneNumber = phoneNumber,
                Name = name.Id
            };
            return View(Input);

        }

        [HttpPost]
        public async Task<IActionResult> Editdetail(AccountEditModel account)
        {
            var user = await _userManager.FindByEmailAsync(account.Email);  
            if (user == null)
            {
                throw new InvalidOperationException($"The related User name was not found for user with ID '{user.Id}'.");
            }

           // var email = await _userManager.GetEmailAsync(user);
           // if (account.Email != email)
           // {
                var setEmailResult = await _userManager.SetEmailAsync(user, account.Email);
                if (!setEmailResult.Succeeded)
                {
                    var userId = await _userManager.GetUserIdAsync(user);
                    throw new InvalidOperationException($"Unexpected error occurred setting email for user with ID '{user.Id}'.");
                }
            //}

            //var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
            //if (account.PhoneNumber != phoneNumber)
            //{
                var setPhoneResult = await _userManager.SetPhoneNumberAsync(user, account.PhoneNumber);
                if (!setPhoneResult.Succeeded)
                {
                    var userId = await _userManager.GetUserIdAsync(user);
                    throw new InvalidOperationException($"Unexpected error occurred setting phone number for user with ID '{user.Id}'.");
                }
          //  }

            var roles = await _userManager.GetRolesAsync(user);
            var role = _roleManager.FindByIdAsync(account.Name).Result;
            await _userManager.RemoveFromRolesAsync(user, roles.ToArray());
            //Assign Role to user here
            await _userManager.AddToRoleAsync(user, role.Name);
            return RedirectToAction("Index");
        }

    }

}
