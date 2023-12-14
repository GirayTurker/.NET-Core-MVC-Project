using System.ComponentModel.DataAnnotations;

namespace BulkProject.Models
{
    public class Category
    {
        [Key] //Defines Primary Key for Entity Framework
        public int Id { get; set; }
        [Required] //Defines Required Fields for Entity Framework
        public string? Name { get; set; }
        public int DisplayOrder { get; set; }
    }
}
