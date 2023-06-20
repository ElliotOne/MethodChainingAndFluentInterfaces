namespace MethodChainingAndFluentInterfaces
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person SetFirstName(string firstName)
        {
            FirstName = firstName;
            return this;
        }

        public Person SetLastName(string lastName)
        {
            LastName = lastName;
            return this;
        }
    }
}
