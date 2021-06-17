using Scoliosis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Scoliosis.Repositories
{
    public class ActionLogRepository : IRepository<ActionLogViewModel, int>
    {
        private readonly MyContext _context;

        public ActionLogRepository(MyContext context)
        {
            _context = context;
        }


        public int Create(ActionLogViewModel actionLogViewModel)
        {
            _context.ActionLog.Add(actionLogViewModel);
            _context.SaveChanges();

            return 0;
        }

        public void Update(ActionLogViewModel actionLogViewModel)
        {
            var oriActionLog = _context.ActionLog.SingleOrDefault(x => x.Id == actionLogViewModel.Id);

            _context.Entry(oriActionLog).CurrentValues.SetValues(actionLogViewModel);
            _context.SaveChanges();

        }

        public void Delete(int Id)
        {
            _context.ActionLog.Remove(_context.ActionLog.Single(x => x.Id == Id));
            _context.SaveChanges();
        }

        public IEnumerable<ActionLogViewModel> Find(Expression<Func<ActionLogViewModel, bool>> expression)
        {
            return _context.ActionLog.Where(expression);
        }


        public ActionLogViewModel FindById(int Id)
        {
            return _context.ActionLog.SingleOrDefault(x => x.Id == Id);

        }
    }
}
