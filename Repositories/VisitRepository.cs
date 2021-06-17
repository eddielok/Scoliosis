using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Scoliosis.Models;


namespace Scoliosis.Repositories
{
    public class VisitRepository : IRepositoryVisit<VisitsModel, string>
    {
        private readonly MyContext _context;

        public VisitRepository(MyContext context)
        {
            _context = context;
        }

  
        public string Create(VisitsModel visitsModel)
        {
            _context.Visits.Add(visitsModel);
            _context.SaveChanges();

            return "0";
        }

      
         //check nullable field sql
        //select is_nullable,* from sys.columns c inner join sys.tables t on
        //t.object_id = c.object_id where t.name = 'Visits'
        public void Update(VisitsModel visitsModel)
        {
            var oriUser = _context.Visits.SingleOrDefault(x => x.SCN == visitsModel.SCN && x.DOC == visitsModel.DOC);

            _context.Entry(oriUser).CurrentValues.SetValues(visitsModel);
            _context.SaveChanges();

        }

        public void Delete(string scn, string docStr)
        {
            var doc = DateTime.ParseExact(docStr, "yyyy-MM-dd", CultureInfo.InvariantCulture);

            _context.Visits.Remove(_context.Visits.Single(x => x.SCN == scn && x.DOC == doc));
            _context.SaveChanges();
        }

        public IEnumerable<VisitsModel> Find(Expression<Func<VisitsModel, bool>> expression)
        {
            return _context.Visits.Where(expression);
        }


        public VisitsModel FindById(string SCN)
        {
            return _context.Visits.SingleOrDefault(x => x.SCN == SCN);

        }

    }
}
