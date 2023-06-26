using System.ComponentModel.DataAnnotations;

namespace Api.Models
{
    public class Isssue
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }

        public Priority Priority { get; set; }

        public IsuueType isuueType { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? Completed { get; set; }
    }
    public enum Priority
    {
        Low, Medium, high
    }

    public enum IsuueType
    {
        feature , bug, Documentation
    }
}
