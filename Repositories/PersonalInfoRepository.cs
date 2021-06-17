using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Scoliosis.Models;


namespace Scoliosis.Repositories
{
    public class PersonalInfoRepository : IRepository<PersonalInfoModel, string>
    {
        private readonly MyContext _context;

        public PersonalInfoRepository(MyContext context)
        {

            _context = context;
        }

        public string Create(PersonalInfoModel entity)
        {
            _context.PersonalInfo.Add(entity);
            _context.SaveChanges();

            return entity.SCN;
        }

        public void Update(PersonalInfoModel entity)
        {
            var oriUser = _context.PersonalInfo.Single(x => x.SCN == entity.SCN);
            _context.Entry(oriUser).CurrentValues.SetValues(entity);
            _context.SaveChanges();
        }

        public void Delete(string scn)
        {
            _context.PersonalInfo.Remove(_context.PersonalInfo.Single(x => x.SCN == scn));
            _context.SaveChanges();
        }

        public IEnumerable<PersonalInfoModel> Find(Expression<Func<PersonalInfoModel, bool>> expression)
        {
            var result = _context.PersonalInfo.Where(expression);

            //Invalid object name 'PersonalInfos'.
            return _context.PersonalInfo.Where(expression);
            //An exception occurred while reading a database value for property 'PersonalInfoModel.ASFPSF'
            //. The expected type was 'System.DateTime' but the actual value was null.
        }

        public PersonalInfoModel FindById(string SCN)
        {
            return _context.PersonalInfo.SingleOrDefault(x => x.SCN == SCN);
        }

 
    }
}
