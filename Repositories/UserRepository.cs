using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Scoliosis.Models;


namespace Scoliosis.Repositories
{

    public class UserRepository : IRepository<UsersModel, string>
    {

        private readonly MyContext _context;

        public UserRepository(MyContext context) {

            _context = context;
        }

        public string Create(UsersModel entity)
        {
            _context.Users.Add(entity);
            _context.SaveChanges();
            return "0";
        }

        public void Update(UsersModel entity)
        {
            var oriUser = _context.Users.Single(x => x.Id == entity.Id);
            _context.Entry(oriUser).CurrentValues.SetValues(entity);
            _context.SaveChanges();
        }

        public void Delete(string id)
        {
            _context.Users.Remove(_context.Users.Single(x => x.Id == id));
            _context.SaveChanges();
        }

        public IEnumerable<UsersModel> Find(Expression<Func<UsersModel, bool>> expression)
        {
            return _context.Users.Where(expression);
        }

        public UsersModel FindById(string id)
        {
           return _context.Users.SingleOrDefault(x => x.Id == id);

           // return _context.Users.FirstOrDefault();

        }

        //public IQueryable<UserModel> GetAll()
        //{
        //    IQueryable<UserModel> users = _context.Users;
        //   return users;
        //}


    }


}
