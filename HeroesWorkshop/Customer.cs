namespace HeroesWorkshop
{
    public sealed class Customer : Base
    {
        public Customer(string firstName, string lastName) : base()
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public override string ToString()
        {
            return $"Customer with id {Id} and name {FirstName} {LastName}";
        }
    }
}
