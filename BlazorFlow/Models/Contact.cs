using System;

namespace BlazorFlow.Models
{
    public class Contact
    {
        public Contact(int contactId, string name, DateTime dateOfBirth)
        {
            ContactId = contactId;
            Name = name;
            DateOfBirth = dateOfBirth;
        }

        public int ContactId { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
