using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Scoliosis.Models;


namespace Scoliosis.Repositories
{
    public class PersonalInfoLogRepository : IRepository<PersonalInfoLogViewModel, int>
    {
        private readonly MyContext _context;

        public PersonalInfoLogRepository(MyContext context)
        {

            _context = context;
        }

        public int Create(PersonalInfoLogViewModel entity)
        {
            _context.PersonalInfoLog.Add(entity);
            _context.SaveChanges();

            return 0;
        }

        public void Update(PersonalInfoLogViewModel entity)
        {
            var oriUser = _context.PersonalInfoLog.Single(x => x.SCN == entity.SCN);
            _context.Entry(oriUser).CurrentValues.SetValues(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            _context.PersonalInfoLog.Remove(_context.PersonalInfoLog.Single(x => x.id == id));
            _context.SaveChanges();
        }

        public IEnumerable<PersonalInfoLogViewModel> Find(Expression<Func<PersonalInfoLogViewModel, bool>> expression)
        {
            var result = _context.PersonalInfoLog.Where(expression);

            //Invalid object name 'PersonalInfos'.
            return _context.PersonalInfoLog.Where(expression);
            //An exception occurred while reading a database value for property 'PersonalInfoModel.ASFPSF'
            //. The expected type was 'System.DateTime' but the actual value was null.
        }

        public PersonalInfoLogViewModel FindById(int Id)
        {
            return _context.PersonalInfoLog.SingleOrDefault(x => x.id == Id);
        }

 
    }
}
