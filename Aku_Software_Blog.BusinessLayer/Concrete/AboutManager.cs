using Aku_Software_Blog.BusinessLayer.Abstract;
using Aku_Software_Blog.DataAccessLayer.Abstract;
using Aku_Software_Blog.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aku_Software_Blog.BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void TAdd(About t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(About t)
        {
            throw new NotImplementedException();
        }

        public About TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<About> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(About t)
        {
            throw new NotImplementedException();
        }
    }
}
