namespace AuthenticationLogin.Data.Model.Feedback
{
    public class Feedback
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string Mobile { get; set; } = default!;
        public string Email { get; set; }= default!;
        public string FeedBack { get; set; } = default!;
    }
}
