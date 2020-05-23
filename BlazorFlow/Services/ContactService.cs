using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorFlow.Models;
using BlazorFlow.Helpers;

namespace BlazorFlow.Services
{
    public static class ContactService
    {
        public static IEnumerable<Contact> GetContacts()
        {
            return new List<Contact>() {
                new Contact("John", "Doe"),
                new Contact("Eddie", "Murphy"),
                new Contact("Jim", "Carrey")
            };
        }
    }
}
