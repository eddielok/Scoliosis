using Scoliosis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Scoliosis.Repositories
{
    public class InitAssessRepository : IRepository<InitAssessViewModel, string>
    {
        private readonly MyContext _context;

        public InitAssessRepository(MyContext context)
        {
            _context = context;
        }


        public string Create(InitAssessViewModel initialAssessmentViewModel)
        {
            _context.InitAssess.Add(initialAssessmentViewModel);
            _context.SaveChanges();

            return "0";
        }

        public void Update(InitAssessViewModel initialAssessmentViewModel)
        {
            var oriActionLog = _context.InitAssess.SingleOrDefault(x => x.SCN == initialAssessmentViewModel.SCN);

            _context.Entry(oriActionLog).CurrentValues.SetValues(initialAssessmentViewModel);
            _context.SaveChanges();
        }

        public void Delete(string scn)
        {
            _context.InitAssess.Remove(_context.InitAssess.Single(x => x.SCN == scn));
            _context.SaveChanges();
        }

        public IEnumerable<InitAssessViewModel> Find(Expression<Func<InitAssessViewModel, bool>> expression)
        {
            return _context.InitAssess.Where(expression);
        }


        public InitAssessViewModel FindById(string scn)
        {
            return _context.InitAssess.SingleOrDefault(x => x.SCN == scn);
        }
    }
}
