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
    public class POImportRepository : IRepositoryPOImport<POImportModel, string>
    {
        private readonly MyContext _context;

        public POImportRepository(MyContext context)
        {
            _context = context;
        }

        public string Create(POImportModel poimportModel)
        {

            _context.POImport.Add(poimportModel);
            _context.SaveChanges();

            return "0";
        }

        public void Update(POImportModel poimportModel)
        {
            var oriUser = _context.POImport.SingleOrDefault(x => x.Serial == poimportModel.Serial);

            _context.Entry(oriUser).CurrentValues.SetValues(poimportModel);
            _context.SaveChanges();

        }

        public void Delete(string Serial)
        {
            _context.POImport.Remove(_context.POImport.Single(x => x.Serial == Serial));
            _context.SaveChanges();
        }
        public IEnumerable<POImportModel> Find(Expression<Func<POImportModel, bool>> expression)
        {
            return _context.POImport.Where(expression);
        }

        public POImportModel FindBykey(string Serial)
        {
            return _context.POImport.SingleOrDefault(x => x.Serial == Serial);

        }
        public List<POImportModel> FindById(string Serial)
        {
            var spParams = new object[] { Serial };
            var listpomodel = _context.POImport.FromSql("EXECUTE dbo.sp_ReadImportcsv @p0", spParams).ToList();
            return listpomodel;

        }

    }
}
