using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Scoliosis.Models;


namespace Scoliosis.Repositories
{
    public class POConfigRepository : IRepository<POConfigModel, string>
    {
        private readonly MyContext _context;

        public POConfigRepository(MyContext context)
        {
            _context = context;
        }

        public string Create(POConfigModel poconfigModel)
        {

            _context.POConfig.Add(poconfigModel);
            _context.SaveChanges();

            return "0";
        }

        public void Update(POConfigModel poconfigModel)
        {
            var oriUser = _context.POConfig.SingleOrDefault(x => x.ID == poconfigModel.ID);

            _context.Entry(oriUser).CurrentValues.SetValues(poconfigModel);
            _context.SaveChanges();

        }

        public void Delete(string ID)
        {
            _context.POConfig.Remove(_context.POConfig.Single(x => x.ID == ID));
            _context.SaveChanges();
        }
        public IEnumerable<POConfigModel> Find(Expression<Func<POConfigModel, bool>> expression)
        {
            return _context.POConfig.Where(expression);
        }

        public POConfigModel FindBykey(string ID)
        {
            return _context.POConfig.SingleOrDefault(x => x.ID == ID);

        }
        public POConfigModel FindById(string ID)
        {
            return _context.POConfig.SingleOrDefault(x => x.ID == ID);

        }

    }
}
