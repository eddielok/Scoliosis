using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Scoliosis.Models;


namespace Scoliosis.Repositories
{
    public class OperativeDataRepository : IRepository<OperativeDataViewModel, string>
    {
        private readonly MyContext _context;

        public OperativeDataRepository(MyContext context)
        {
            _context = context;
        }

        public string Create(OperativeDataViewModel operativeDataViewModel)
        {
            _context.OperativeData.Add(operativeDataViewModel);
            _context.SaveChanges();

            return "0";
        }

        public void Update(OperativeDataViewModel operativeDataViewModel)
        {
            var oriUser = _context.OperativeData.SingleOrDefault(x => x.SCN == operativeDataViewModel.SCN && x.RecordID  == operativeDataViewModel.RecordID);

            _context.Entry(oriUser).CurrentValues.SetValues(operativeDataViewModel);
            _context.SaveChanges();

        }

        public void Delete(string scn)
        {
            _context.OperativeData.Remove(_context.OperativeData.Single(x => x.SCN == scn));
            _context.SaveChanges();
        }

        public IEnumerable<OperativeDataViewModel> Find(Expression<Func<OperativeDataViewModel, bool>> expression)
        {
            return _context.OperativeData.Where(expression);
        }


        public OperativeDataViewModel FindById(string SCN)
        {
            return _context.OperativeData.SingleOrDefault(x => x.SCN == SCN);

        }

    }
}
