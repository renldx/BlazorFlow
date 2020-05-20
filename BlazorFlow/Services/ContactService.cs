using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorFlow.Entities;
using BlazorFlow.Helpers;

namespace BlazorFlow.Services
{
    public static class ContactService
    {
        public static IEnumerable<Contact> GetContacts()
        {
            return new List<Contact>() {
                new Contact(1, "John Doe", DateTime.Now),
                new Contact(2, "Eddie Murphy", DateTime.Now),
                new Contact(3, "Jim Carrey", DateTime.Now)
            };
        }
    }
}
