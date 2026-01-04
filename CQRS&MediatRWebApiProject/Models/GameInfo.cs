namespace CQRS_MediatRWebApiProject.Models
{
    public class GameInfo
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = null!;
        public string Genre { get; set; } = null!;
    }
}
