namespace api.Models
{
    public class Person
    {
        private string firstName = string.Empty;
        private string lastName = string.Empty;
        private bool male;
        private string phoneNumber = string.Empty;
        private string address = string.Empty;
        private DateTime dateOfBirth;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public bool Male
        {
            get { return male; }
            set { male = value; }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        
    }
}