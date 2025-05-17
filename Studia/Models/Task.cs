using System.ComponentModel.DataAnnotations;

namespace Studia.Models
{
    public class Task
    {
        public int Id { get; set; } //primary key
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Status { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DueDateTime { get; set; }

        public string? CreatedBy { get; set; }
    }
}