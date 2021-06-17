using Scoliosis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Scoliosis.Repositories
{
    public class TemplateRemarksHeaderRepository : IRepository<TemplateRemarksHeaderViewModel, int>
    {

        private readonly MyContext _context;

        public TemplateRemarksHeaderRepository(MyContext context)
        {

            _context = context;
        }

        public int Create(TemplateRemarksHeaderViewModel entity)
        {
            _context.TemplateRemarksHeader.Add(entity);
            _context.SaveChanges();
            return 0;
        }

        public void Update(TemplateRemarksHeaderViewModel entity)
        {
            var oriUser = _context.TemplateRemarksHeader.Single(x => x.Id == entity.Id);
            _context.Entry(oriUser).CurrentValues.SetValues(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            _context.TemplateRemarksHeader.Remove(_context.TemplateRemarksHeader.Single(x => x.Id == id));
            _context.SaveChanges();
        }

        public IEnumerable<TemplateRemarksHeaderViewModel> Find(Expression<Func<TemplateRemarksHeaderViewModel, bool>> expression)
        {
            return _context.TemplateRemarksHeader.Where(expression);
        }

        public TemplateRemarksHeaderViewModel FindById(int id)
        {
            return _context.TemplateRemarksHeader.SingleOrDefault(x => x.Id == id);

            // return _context.Users.FirstOrDefault();

        }
    }
}
