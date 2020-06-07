using System;

namespace BlazorFlow.Models
{
    public class Contact
    {
        public Contact(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public int ContactId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Name => FirstName + " " + LastName;
        public DateTime DateOfBirth { get; set; }
    }
}
