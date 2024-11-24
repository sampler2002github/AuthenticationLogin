namespace AuthenticationLogin.Data.Model.JobSeeker
{
    public class ChangePassword
    {
        public int Id { get; set; }
        public string OldPassword { get; set; } = default!;
        public string NewPassword { get; set; }=default!;
        public string ConfirmPassword { get; set; } = default!;
    }
}
