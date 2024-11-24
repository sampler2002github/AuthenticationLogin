namespace AuthenticationLogin.Data.Model.NewCompany
{
    public class PostNewJob
    {
        public int Id { get; set; }
        public string JobTitle { get; set; } = default!;
        public string Degree { get; set; } = default!;
        public string Skill { get; set; } = default!;
        public string Salary { get; set; } = default!;
        public string Experience {  get; set; } = default!;
        public int NoOfVacancy {  get; set; }
        public string Detail { get; set; } = default!;
    }
}
