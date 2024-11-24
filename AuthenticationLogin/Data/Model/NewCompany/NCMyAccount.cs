namespace AuthenticationLogin.Data.Model.NewCompany
{
    public class NCMyAccount
    {
        public int Id { get; set; }
        public string CompanyName { get; set; } = default!;
        public string ContactPerson { get; set; } = default!;
        public string Address { get; set; } = default!;
        public string City { get; set; } = default!;
        public int PinCode { get; set; } = default!;
        public string Mobile { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string Type { get; set; } = default!;
        public string Detail { get; set; } = default!;
    }
}
