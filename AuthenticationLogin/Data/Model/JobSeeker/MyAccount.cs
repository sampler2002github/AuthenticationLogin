namespace AuthenticationLogin.Data.Model.JobSeeker
{
    public class MyAccount
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public string Address { get; set; } = default!;
        public string City { get; set; } = default!;
        public int PinCode { get; set; } 
        public string Mobile { get; set; } = default!;
        public string Degree { get; set; } = default!;
        public string Skill { get; set; } = default!;
        public string Details { get; set; } = default!;
        public string Salary { get; set; } = default!;
        public string Experience { get; set; } = default!;

    }
}


