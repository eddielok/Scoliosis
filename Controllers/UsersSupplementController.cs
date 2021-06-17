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
    [Route("api/[controller]s")]
    public class UsersSupplementController : Controller
    {
        //private readonly MyContext _context;
        private readonly IRepository<UsersSupplementViewModel, string> _repository;

        public UsersSupplementController(IRepository<UsersSupplementViewModel, string> repository)
        {
            _repository = repository;
        }


        public ResultModel Get()
        {
            var result = new ResultModel();
            var usersSupplements = _repository.Find(x => "1" == "1").AsQueryable<UsersSupplementViewModel>().AsNoTracking().OrderByDescending(z => z.FullName);
            //var visisLists = new List<string>();

            result.IsSuccess = true;
            //result.Data = visisLists;
            result.Data = usersSupplements;

            return result;
        }



        [HttpGet("{userId}")]
        public ResultModel Get(string userId)
        {
            var result = new ResultModel();
            var usersSupplement = _repository.Find(x => x.UserId == userId);

            result.IsSuccess = true;
            result.Data = usersSupplement;

            return result;
        }

        [HttpPost]
        public ResultModel POST([FromBody]UsersSupplementViewModel usersSupplementViewModel)
        {

            var result = new ResultModel();
            try
            {
                usersSupplementViewModel.CreatedDate = DateTime.Now;
                usersSupplementViewModel.ModifiedDate = DateTime.Now;
                _repository.Create(usersSupplementViewModel);
                result.Data = usersSupplementViewModel.UserId;
                result.IsSuccess = true;
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.Message = ex.Message;
            }
            return result;
        }

        [HttpPut]
        public ResultModel Put(string UserID, [FromBody]UsersSupplementViewModel usersSupplementViewModel)
        {

            var result = new ResultModel();
            try
            {
                usersSupplementViewModel.ModifiedDate = DateTime.Now;
                _repository.Update(usersSupplementViewModel);
                result.IsSuccess = true;
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.Message = ex.Message;
            }

            return result;
        }


    }
}