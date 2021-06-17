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
    public class PODOCRepository : IRepositoryPODOC<PODOCModel, string>
    {
        private readonly MyContext _context;

        public PODOCRepository(MyContext context)
        {
            _context = context;
        }

        public string Create(PODOCModel poDOCModel)
        {

            _context.PODOC.Add(poDOCModel);
            _context.SaveChanges();

            return poDOCModel.Id.ToString();
        }

        public void Update(PODOCModel poDOCModel)
        {
            var oriUser = _context.PODOC.SingleOrDefault(x => x.Id == poDOCModel.Id);

            _context.Entry(oriUser).CurrentValues.SetValues(poDOCModel);
            _context.SaveChanges();

        }
 
        public void Delete(string id)
        {
            _context.PODOC.Remove(_context.PODOC.Single(x => x.Id == Convert.ToInt64(id)));
            _context.SaveChanges();
        }
        public IEnumerable<PODOCModel> Find(Expression<Func<PODOCModel, bool>> expression)
        {
            return _context.PODOC.Where(expression);
        }

        public PODOCModel FindBykey(string id)
        {
            return _context.PODOC.SingleOrDefault(x => x.Id == Convert.ToInt64(id));

        }
        public PODOCModel FindById(string id)
        {
            return _context.PODOC.SingleOrDefault(x => x.Id == Convert.ToInt64(id));

        }

    }
}
