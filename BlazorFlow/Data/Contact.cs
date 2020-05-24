using System;

namespace BlazorFlow.Data
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }
    }
}
