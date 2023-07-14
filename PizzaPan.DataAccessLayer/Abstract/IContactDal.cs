﻿using PizzaPan.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPan.DataAccessLayer.Abstract
{
    public interface IContactDal:IGenericDal<Contact>
    {
        List<Contact> GetContactBySubjectWithtThanks();
    }
}
