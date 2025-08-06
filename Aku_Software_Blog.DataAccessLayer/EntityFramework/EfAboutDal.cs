using Aku_Software_Blog.DataAccessLayer.Abstract;
using Aku_Software_Blog.DataAccessLayer.Repository;
using Aku_Software_Blog.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aku_Software_Blog.DataAccessLayer.EntityFramework
{
    public class EfAboutDal : GenericRepository<About>, IAboutDal
    {
    }
}
