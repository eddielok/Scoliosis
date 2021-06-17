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
    public class UploadDocumentController : ControllerBase
    {
        private readonly IRepository<UploadDocumentViewModel, long> _repository;

        public UploadDocumentController(IRepository<UploadDocumentViewModel, long> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ResultModel Get()
        {
            var result = new ResultModel();

            var uploadDocuments = _repository.Find(x => 1 == 1);

            result.IsSuccess = true;
            result.Data = uploadDocuments;

            return result;
        }

        [HttpGet("{id}")]
        public ResultModel Get(long id)
        {
            var result = new ResultModel();

            var uploadDocument = _repository.Find(x => x.Id == id);

            result.IsSuccess = true;
            result.Data = uploadDocument;

            return result;
        }



        [HttpPut("{id}")]
        public ResultModel Put(long id, [FromBody]UploadDocumentViewModel uploadDocumentViewModel)
        {
            var result = new ResultModel();

            try
            {
                uploadDocumentViewModel.ModifiedDate = DateTime.Now;
                _repository.Update(uploadDocumentViewModel);
                result.IsSuccess = true;

            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                result.IsSuccess = false;
            }
            return result;
        }

        [HttpPost]
        public ResultModel Post([FromBody]UploadDocumentViewModel uploadDocumentViewModel)
        {
            var result = new ResultModel();

            try
            {
                uploadDocumentViewModel.CreatedDate = DateTime.Now;
                uploadDocumentViewModel.ModifiedDate = DateTime.Now;
                _repository.Create(uploadDocumentViewModel);
               
                result.IsSuccess = true;

            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                result.IsSuccess = false;
            }
            return result;
        }


    }
}