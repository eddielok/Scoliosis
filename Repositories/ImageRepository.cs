using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Scoliosis.Models;


namespace Scoliosis.Repositories
{
    public class ImageRepository : IRepository<ImageModel, string>
    {
        private readonly MyContext _context;

        public ImageRepository(MyContext context)
        {
            _context = context;
        }

        public string Create(ImageModel imageModel)
        {

            _context.ImageMeasurement.Add(imageModel);
            _context.SaveChanges();

            return "0";
        }

        public void Update(ImageModel imageModel)
        {
            var oriUser = _context.ImageMeasurement.SingleOrDefault(x => x.SCN == imageModel.SCN && x.DOB == imageModel.DOB && x.LastModify == imageModel.LastModify);

            _context.Entry(oriUser).CurrentValues.SetValues(imageModel);
            _context.SaveChanges();

        }

        public void Delete(string ID)
        {
            var qsdata = ID.Split("|");
            _context.ImageMeasurement.Remove(_context.ImageMeasurement.Single(y => y.SCN == qsdata[0] && y.DOB == qsdata[1] && y.LastModifyBy == qsdata[2] && y.imageName == qsdata[3]));
            _context.SaveChanges();
        }
        public void DeleteAll(string SCN, string DOB, string LastModify, string imageName)
        {
            _context.ImageMeasurement.Remove(_context.ImageMeasurement.Single(x => x.SCN == SCN && x.DOB == DOB && x.LastModify == LastModify && x.imageName == imageName));
            _context.SaveChanges();
        }
        public IEnumerable<ImageModel> Find(Expression<Func<ImageModel, bool>> expression)
        {
            return _context.ImageMeasurement.Where(expression);
        }

        public ImageModel FindBykey(string SCN, string DOB, string LastModify)
        {
            return _context.ImageMeasurement.SingleOrDefault(x => x.SCN == SCN && x.DOB == DOB && x.LastModify == LastModify);

        }
        public ImageModel FindById(string ID)
        {
            return _context.ImageMeasurement.SingleOrDefault(x => x.ID == ID);

        }

    }
}
