﻿using MvcApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MvcApp1.Controllers
{
    public class ContactsController : ApiController
    {
        // GET api/contacts
        public IEnumerable<Contact> Get()
        {
            System.Threading.Thread.Sleep(1000);
            return Contact.getContacts();
        }

        // GET api/contacts/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/contacts
        public void Post([FromBody]string value)
        {
        }

        // PUT api/contacts/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/contacts/5
        public void Delete(int id)
        {
        }
    }
}
