using System;

namespace DapperDemo
{
    [Serializable]
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public string Email { get; set; }
        public string IpAddress { get; set; }
        public string Province { get; set; }
        public int Age { get; set; }
    }
}
