using Scoliosis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;


namespace Scoliosis.Repositories
{
    public class UploadDocumentRepository : IRepository<UploadDocumentViewModel, long>
    {
        private readonly MyContext _context;

        public UploadDocumentRepository(MyContext context)
        {
            _context = context;
        }

        public long Create(UploadDocumentViewModel uploadDocumentViewModel)
        {
            _context.UploadDocument.Add(uploadDocumentViewModel);
            _context.SaveChanges();

            return uploadDocumentViewModel.Id;
        }

        public void Update(UploadDocumentViewModel uploadDocumentViewModel)
        {
            var oriActionLog = _context.UploadDocument.SingleOrDefault(x => x.Id == uploadDocumentViewModel.Id);

            _context.Entry(oriActionLog).CurrentValues.SetValues(uploadDocumentViewModel);
            _context.SaveChanges();

        }

        public void Delete(long id)
        {
            _context.UploadDocument.Remove(_context.UploadDocument.Single(x => x.Id == id));
            _context.SaveChanges();
        }

        public IEnumerable<UploadDocumentViewModel> Find(Expression<Func<UploadDocumentViewModel, bool>> expression)
        {
            return _context.UploadDocument.Where(expression);
        }


        public UploadDocumentViewModel FindById(long id)
        {
            return _context.UploadDocument.SingleOrDefault(x => x.Id == id);

        }




    }
}
