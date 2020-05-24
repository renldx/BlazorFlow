using System;
using System.Collections.Generic;
using BlazorFlow.Enums;

namespace BlazorFlow.Services
{
    public static class LookupService
    {
        public static Dictionary<string, string> GetLookup(FlowNodeEntity entity) => entity switch
        {
            FlowNodeEntity.Contact => GetContactLookup(),
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
