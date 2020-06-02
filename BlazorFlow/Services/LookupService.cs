using System;
using System.Collections.Generic;
using BlazorFlow.Models;
using BlazorFlow.Enums;

namespace BlazorFlow.Services
{
    public static class LookupService
    {
        public static Dictionary<int, string> GetLookup(FlowEntity entity) => entity switch
        {
            FlowEntity.Contact => GetContactLookup(),
            _ => throw new NotImplementedException()
        };

        public static Dictionary<int, string> GetContactLookup()
        {
            var contacts = ContactService.GetContacts();
            var contactsDict = new Dictionary<int, string>();
            var contactId = 0;

            foreach (var contact in contacts)
            {
                contactsDict.Add(++contactId, contact.Name);
            }

            return contactsDict;
        }
    }
}
