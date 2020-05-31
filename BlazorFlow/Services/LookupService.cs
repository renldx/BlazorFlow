using System;
using System.Collections.Generic;
using BlazorFlow.Models;
using BlazorFlow.Enums;

namespace BlazorFlow.Services
{
    public static class LookupService
    {
        public static Dictionary<string, string> GetLookup(FlowEntity entity) => entity switch
        {
            FlowEntity.Contact => GetContactLookup(),
            _ => throw new NotImplementedException()
        };

        public static Dictionary<string, string> GetContactLookup()
        {
            var contacts = ContactService.GetContacts();
            var contactsDict = new Dictionary<string, string>();

            foreach (var contact in contacts)
            {
                contactsDict.Add(contact.ContactId.ToString(), contact.Name);
            }

            return contactsDict;
        }
    }
}
