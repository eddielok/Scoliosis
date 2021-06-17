using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Scoliosis.Models;



namespace Scoliosis.Repositories
{
    public class ErrorLogRepository : IRepository<ErrorLogViewModel, int>
    {
        private readonly MyContext _context;

        public ErrorLogRepository(MyContext context)
        {
            _context = context;
        }


        public int Create(ErrorLogViewModel errorLogViewModel)
        {
            _context.ErrorLog.Add(errorLogViewModel);
            _context.SaveChanges();

            return 0;
        }


        //check nullable field sql
        //select is_nullable,* from sys.columns c inner join sys.tables t on
        //t.object_id = c.object_id where t.name = 'Visits'
        public void Update(ErrorLogViewModel errorLogViewModel)
        {
            var oriUser = _context.ErrorLog.SingleOrDefault(x => x.Id == errorLogViewModel.Id);

            _context.Entry(oriUser).CurrentValues.SetValues(errorLogViewModel);
            _context.SaveChanges();

        }

        public void Delete(int Id)
        {
            _context.ErrorLog.Remove(_context.ErrorLog.Single(x => x.Id == Id));
            _context.SaveChanges();
        }

        public IEnumerable<ErrorLogViewModel> Find(Expression<Func<ErrorLogViewModel, bool>> expression)
        {
            return _context.ErrorLog.Where(expression);
        }


        public ErrorLogViewModel FindById(int Id)
        {
            return _context.ErrorLog.SingleOrDefault(x => x.Id == Id);

        }

    }
}
