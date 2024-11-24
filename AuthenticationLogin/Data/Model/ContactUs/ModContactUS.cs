namespace AuthenticationLogin.Data.Model.ContactUs
{
    public class ModContactUS
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string Mobile { get; set; } = default!;
        public string Message { get; set; }= default!;
    }
}
