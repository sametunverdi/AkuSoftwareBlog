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
    public class ContactManager : IContactService
    {
        IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }
        
        public void TAdd(Contact t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Contact t)
        {
            throw new NotImplementedException();
        }

        public Contact TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Contact> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Contact t)
        {
            throw new NotImplementedException();
        }
    }
}
