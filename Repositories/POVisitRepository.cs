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
    public class POVisitRepository : IRepositoryPOVisit<POVisitModel, string>
    {
        private readonly MyContext _context;

        public POVisitRepository(MyContext context)
        {
            _context = context;
        }

        public string Create(POVisitModel povisitModel)
        {

            _context.POVisit.Add(povisitModel);
            _context.SaveChanges();

            return "0";
        }

        public void Update(POVisitModel povisitModel)
        {
            var oriUser = _context.POVisit.SingleOrDefault(x => x.SCN == povisitModel.SCN && x.DOC.Value.ToString("yyyy-MM-dd") == povisitModel.DOC.Value.ToString("yyyy-MM-dd"));

            _context.Entry(oriUser).CurrentValues.SetValues(povisitModel);
            _context.SaveChanges();

        }

        public void Delete(string SCN, string DOC)
        {
       //     DateTime DOB = DateTime.Parse(DOC);
           // var DOB = DateTime.ParseExact(DOC, "yyyy-MM-dd", CultureInfo.InvariantCulture);
         //   var POobject = _context.POVisit.FirstOrDefault(x => x.SCN == SCN && x.DOC.Value.ToString("yyyy-MM-dd") == DOC);
            // _context.POVisit.Remove(POobject);
               _context.POVisit.Remove(_context.POVisit.Single(x => x.SCN == SCN && x.DOC.Value.ToString("yyyy-MM-dd") == DOC));
          
            _context.SaveChanges();
        }
        public IEnumerable<POVisitModel> Find(Expression<Func<POVisitModel, bool>> expression)
        {
            return _context.POVisit.Where(expression);
        }

        public POVisitModel FindBykey(string SCN, string DOC)
        {
            DateTime DOB = DateTime.Parse(DOC);
            return _context.POVisit.SingleOrDefault(x => x.SCN == SCN && x.DOC == DOB);

        }
        public POVisitModel FindById(string SCN)
        {
            return _context.POVisit.SingleOrDefault(x => x.SCN == SCN);

        }

    }
}
