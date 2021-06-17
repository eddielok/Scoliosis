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

namespace Scoliosis.Controllers
{
    [Route("api/[controller]s")]
    public class UserController : Controller
    {
        //private readonly MyContext _context;
        private readonly IRepository<UsersModel, string> _repository;
 
        public UserController(IRepository<UsersModel, string> repository)
        {
            _repository = repository;
        }

        [HttpGet("{id}")]
        public ResultModel Get(string id)
        {
            var result = new ResultModel();

            //https://localhost:44361/api/Users/chy814
            result.Data = _repository.Find(x => string.IsNullOrEmpty(id)
                               || Regex.IsMatch(x.Id, id, RegexOptions.IgnoreCase));

            result.IsSuccess = true;
            return result;
        }

        // POST: api/User
        [HttpPost]
        public ResultModel Post([FromBody]UsersModel user) {

            var result = new ResultModel();
            _repository.Create(user);
            result.Data = user.Id;
            result.IsSuccess = true;
            return result;

        }

        [HttpPut("id")]
        public ResultModel Put(string id, [FromBody]UsersModel user) {

            var result = new ResultModel();

            try
            {
                user.Id = id;
                _repository.Update(user);
                result.IsSuccess = true;
            }
            catch {

            }
            return result;
        }


 
    }
}