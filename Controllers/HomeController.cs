using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Scoliosis.Models;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;

namespace Scoliosis.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        public HomeController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }
        public ActionResult  Index()
        {
            try
            {
                ResetSubmitSession();

                if (!CheckLogIn())
                {
                    return RedirectToReLoginPage();
                }


                //input Log
                InsertActionLog();

            }
            catch (Exception ex)
            {

                var gUIDNumner = Guid.NewGuid();
                var exceptionDateTime = DateTime.Now;
                var showMessage = "Unable to go to home Controller<br> Exception: " + ex.Message + " <br/> ";

                return RedirectToErrorPage(gUIDNumner.ToString(), exceptionDateTime, showMessage);

            }

            return View();
        }


        private void ResetSubmitSession()
        {
            HttpContext.Session.SetString("_isShowMessage", "false");
            HttpContext.Session.SetString("_alertMessage", "");
            HttpContext.Session.SetString("_isCreatePage", "false");
        }


        private ResultModel InsertActionLog()
        {
            var baseAddress = "Http://" + Request.Host.ToString();
            var link = $"/api/ActionLogs";
            var client = new HttpClient();
            var actionLogViewModel = new ActionLogViewModel();

            actionLogViewModel.ActionType = "Login";
            actionLogViewModel.ActionDetail = "Login Successfully";
            actionLogViewModel.CreatedBy = HttpContext.Session.GetString("_userId");
            actionLogViewModel.scn = "";
            actionLogViewModel.doc = DateTime.Now;
            actionLogViewModel.LogDateTime = DateTime.Now;

            string content = JsonConvert.SerializeObject(actionLogViewModel);
            var buffer = Encoding.UTF8.GetBytes(content);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            HttpResponseMessage response = client.PostAsync(baseAddress + link, byteContent).GetAwaiter().GetResult();
            var stringResult1 = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            ResultModel resultModel1 = JsonConvert.DeserializeObject<ResultModel>(stringResult1);

            return resultModel1;

        }


        private bool CheckLogIn() {

            try
            {

                var email = User.FindFirstValue(ClaimTypes.Name);
                var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
                var user =  _userManager.FindByEmailAsync(email);
                var roles =  _userManager.GetRolesAsync(user.Result);

                var usersSupplement = GetUsersSupplement(email);


                HttpContext.Session.SetString("_userId", email);
                HttpContext.Session.SetString("_roles", roles.Result[0].ToString());
                HttpContext.Session.SetString("_userName", usersSupplement.FullName);


                return true;
            }
            catch (Exception ex) {
                return false;
            } 

        }

        private UsersSupplementViewModel GetUsersSupplement(string userId) {

            var UserSupplements = new List<UsersSupplementViewModel>();
            var UserSupplement = new UsersSupplementViewModel();

            try
            {
                var baseAddress = "Http://" + Request.Host.ToString();
                var link = $"/api/UsersSupplements/" + userId + "/";
                var client = new HttpClient();

                HttpResponseMessage response = client.GetAsync(baseAddress + link).GetAwaiter().GetResult();
                response.EnsureSuccessStatusCode();
                var stringResult = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                ResultModel resultModel = JsonConvert.DeserializeObject<ResultModel>(stringResult);
                UserSupplements = JsonConvert.DeserializeObject<List<UsersSupplementViewModel>>(resultModel.Data.ToString());
                UserSupplement = UserSupplements.FirstOrDefault();
            }

            catch (Exception ex)
            {
                var gUIDNumner = Guid.NewGuid();
             }

            return UserSupplement;
        }

        private ActionResult RedirectToReLoginPage()
        {
            var directAction = "../Home/ReLogin";
            return RedirectToAction(directAction);
        }


        private ActionResult RedirectToErrorPage(string gUIDNumner, DateTime exceptionDateTime, string message)
        {
            var directAction = "../Error";
            return RedirectToAction(directAction, new { GUIDNumner = gUIDNumner, ExceptionDateTime = exceptionDateTime, Message = message });
        }


        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public IActionResult ReLogin()
        {
            return View();
        }

    }
}
