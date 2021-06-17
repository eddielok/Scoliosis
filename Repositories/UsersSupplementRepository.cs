using Scoliosis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;


namespace Scoliosis.Repositories
{
    public class UsersSupplementRepository : IRepository<UsersSupplementViewModel, string>
    {
        private readonly MyContext _context;

        public UsersSupplementRepository(MyContext context)
        {
            _context = context;
        }


        public string Create(UsersSupplementViewModel usersSupplementViewModel)
        {
            _context.UsersSupplement.Add(usersSupplementViewModel);
            _context.SaveChanges();

            return usersSupplementViewModel.UserId ;
        }

        public void Update(UsersSupplementViewModel usersSupplementViewModel)
        {
            var oriActionLog = _context.UsersSupplement.SingleOrDefault(x => x.UserId == usersSupplementViewModel.UserId);

            _context.Entry(oriActionLog).CurrentValues.SetValues(usersSupplementViewModel);
            _context.SaveChanges();

        }

        public void Delete(string UserId)
        {
            _context.UsersSupplement.Remove(_context.UsersSupplement.Single(x => x.UserId == UserId));
            _context.SaveChanges();
        }

        public IEnumerable<UsersSupplementViewModel> Find(Expression<Func<UsersSupplementViewModel, bool>> expression)
        {
            return _context.UsersSupplement.Where(expression);
        }


        public UsersSupplementViewModel FindById(string UserId)
        {
            return _context.UsersSupplement.SingleOrDefault(x => x.UserId == UserId);

        }

    }
}
