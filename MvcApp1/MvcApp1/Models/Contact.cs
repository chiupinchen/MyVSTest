using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApp1.Models
{
    public class Contact
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public static IEnumerable<Contact> getContacts()
        {
            IEnumerable<Contact> oContacts = new List<Contact> 
                { 
                    new Contact() { Name = "Allen", Age = 5},
                    new Contact() { Name = "Jessica", Age = 15},
                };

            return oContacts;
        }
    }
}