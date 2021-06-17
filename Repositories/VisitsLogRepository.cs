using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Scoliosis.Models;


namespace Scoliosis.Repositories
{
    public class VisitsLogRepository : IRepository<VisitsLogViewModel, int>
    {
        private readonly MyContext _context;

        public VisitsLogRepository(MyContext context)
        {
            _context = context;
        }

  
        public int Create(VisitsLogViewModel visitsLogViewModel)
        {
            _context.VisitsLog.Add(visitsLogViewModel);
            _context.SaveChanges();

            return 0;
        }

      
         //check nullable field sql
        //select is_nullable,* from sys.columns c inner join sys.tables t on
        //t.object_id = c.object_id where t.name = 'Visits'
        public void Update(VisitsLogViewModel visitsLogViewModel)
        {
            var oriUser = _context.VisitsLog.SingleOrDefault(x => x.id == visitsLogViewModel.id);

            _context.Entry(oriUser).CurrentValues.SetValues(visitsLogViewModel);
            _context.SaveChanges();

        }

        public void Delete(int id)
        {
            _context.VisitsLog.Remove(_context.VisitsLog.Single(x => x.id == id));
            _context.SaveChanges();
        }

        public IEnumerable<VisitsLogViewModel> Find(Expression<Func<VisitsLogViewModel, bool>> expression)
        {
            return _context.VisitsLog.Where(expression);
        }


        public VisitsLogViewModel FindById(int id)
        {
            return _context.VisitsLog.SingleOrDefault(x => x.id == id);

        }

    }
}
