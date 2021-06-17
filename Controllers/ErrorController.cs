using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Scoliosis.Models;
using System.Text.RegularExpressions;
using Scoliosis.Repositories;
using System.Globalization;


namespace Scoliosis.Controllers
{

    //[Route("Error")]
    public class ErrorController : Controller
    {
        //private readonly MyContext _context;
        //private readonly IRepository<ErrorLogViewModel, int> _repository;

        //public ErrorController(IRepository<ErrorLogViewModel, int> repository)
        //{
        //    _repository = repository;
        //}

        public IActionResult Index(string gUIDNumner, DateTime exceptionDateTime, string Message)

        {
            var errorExceptionViewModel = new ErrorExceptionViewModel();

            errorExceptionViewModel.GUIDNumber = gUIDNumner;
            errorExceptionViewModel.ExceptionDateTime = exceptionDateTime;
            errorExceptionViewModel.ExceptionDetail = Message;

            return View(errorExceptionViewModel);
        }

        //[HttpPost("{GUID}")]
        //public ResultModel Post(string GUID, [FromBody]ErrorLogViewModel errorLogViewModel)
        //{
        //    var result = new ResultModel();
        //    _repository.Create(errorLogViewModel);
        //    result.Data = GUID;
        //    result.IsSuccess = true;

        //    return result;
        //}

    }
}