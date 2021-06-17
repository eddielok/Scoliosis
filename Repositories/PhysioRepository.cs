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
    public class PhysioRepository : IRepositoryDOC<PhysioModel, string>
    {
        private readonly MyContext _context;

        public PhysioRepository(MyContext context)
        {
            _context = context;
        }

        public string Create(PhysioModel physioModel)
        {

            _context.Physio.Add(physioModel);
            _context.SaveChanges();

            return "0";
        }

        public void Update(PhysioModel physioModel)
        {
            var oriUser = _context.Physio.SingleOrDefault(x => x.SCN == physioModel.SCN && x.DOC.Value.ToString("yyyy-MM-dd") == physioModel.DOC.Value.ToString("yyyy-MM-dd"));

            _context.Entry(oriUser).CurrentValues.SetValues(physioModel);
            _context.SaveChanges();

        }

        public void Delete(string SCN, string DOC)
        {
            _context.Physio.Remove(_context.Physio.Single(x => x.SCN == SCN && x.DOC.Value.ToString("yyyy-MM-dd") == DOC));

            _context.SaveChanges();
        }
        public IEnumerable<PhysioModel> Find(Expression<Func<PhysioModel, bool>> expression)
        {
            return _context.Physio.Where(expression);
        }

        public PhysioModel FindBykey(string SCN, string DOC)
        {
            DateTime DOB = DateTime.Parse(DOC);
            return _context.Physio.SingleOrDefault(x => x.SCN == SCN && x.DOC == DOB);

        }
        public PhysioModel FindById(string SCN)
        {
            return _context.Physio.SingleOrDefault(x => x.SCN == SCN);

        }

    }
}
