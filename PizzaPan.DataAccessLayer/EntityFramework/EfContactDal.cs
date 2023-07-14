using PizzaPan.DataAccessLayer.Abstract;
using PizzaPan.DataAccessLayer.Concrete;
using PizzaPan.DataAccessLayer.Repositories;
using PizzaPan.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPan.DataAccessLayer.EntityFramework
{
    public class EfContactDal : GenericRepositoriy<Contact>, IContactDal
    {
        public List<Contact> GetContactBySubjectWithtThanks()
        {
            using var c = new Context();
            var values = c.Contacts.Where(x => x.ContactSubject == "Teşekkür").ToList();
            return values;
        }

    }
}
