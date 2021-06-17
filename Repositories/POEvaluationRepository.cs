using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Scoliosis.Models;


namespace Scoliosis.Repositories
{
    public class POEvaluationRepository : IRepositoryPOEvaluation<POEvaluationModel, string>
    {
        private readonly MyContext _context;

        public POEvaluationRepository(MyContext context)
        {
            _context = context;
        }

        public string Create(POEvaluationModel poevaluationModel)
        {

            _context.POEvaluation.Add(poevaluationModel);
            _context.SaveChanges();

            return "0";
        }

        public void Update(POEvaluationModel poevaluationModel)
        {
            var oriUser = _context.POEvaluation.SingleOrDefault(x => x.SCN == poevaluationModel.SCN);

            _context.Entry(oriUser).CurrentValues.SetValues(poevaluationModel);
            _context.SaveChanges();

        }
        public void Update(POEvaluationModel poevaluationModel, string type,string filepath)
        {
            var strpath = filepath.Replace(@"\\", @"\");
            var spParams = new object[] { strpath };
            _context.POImport.FromSql("EXECUTE dbo.sp_uploadPOcsv @p0", spParams).ToList();
            _context.SaveChanges();

        }
        public void Delete(string SCN)
        {
            _context.POEvaluation.Remove(_context.POEvaluation.Single(x => x.SCN == SCN));
            _context.SaveChanges();
        }
        public IEnumerable<POEvaluationModel> Find(Expression<Func<POEvaluationModel, bool>> expression)
        {
            return _context.POEvaluation.Where(expression);
        }

        public POEvaluationModel FindBykey(string SCN)
        {
            return _context.POEvaluation.SingleOrDefault(x => x.SCN == SCN);

        }
        public POEvaluationModel FindById(string SCN)
        {
            return _context.POEvaluation.SingleOrDefault(x => x.SCN == SCN);

        }

    }
}
