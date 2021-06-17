using Scoliosis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Scoliosis.Repositories
{
    public class TemplateRemarksContentRepository : IRepository<TemplateRemarksContentViewModel, int>
    {

        private readonly MyContext _context;

        public TemplateRemarksContentRepository(MyContext context)
        {

            _context = context;
        }

        public int Create(TemplateRemarksContentViewModel entity)
        {
            _context.TemplateRemarksContent.Add(entity);
            _context.SaveChanges();
            return 0;
        }

        public void Update(TemplateRemarksContentViewModel entity)
        {
            var oriUser = _context.TemplateRemarksContent.Single(x => x.Id == entity.Id);
            _context.Entry(oriUser).CurrentValues.SetValues(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            _context.TemplateRemarksContent.Remove(_context.TemplateRemarksContent.Single(x => x.Id == id));
            _context.SaveChanges();
        }

        public IEnumerable<TemplateRemarksContentViewModel> Find(Expression<Func<TemplateRemarksContentViewModel, bool>> expression)
        {
            return _context.TemplateRemarksContent.Where(expression);
        }

        public TemplateRemarksContentViewModel FindById(int id)
        {
            return _context.TemplateRemarksContent.SingleOrDefault(x => x.Id == id);

            // return _context.Users.FirstOrDefault();

        }
    }
}
