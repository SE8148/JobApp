namespace JobAppWebAPI.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string? JobTitle { get; set; }
        public string? JobDescription { get; set; }
        public bool Completed { get; set; } = false;
    }
}
