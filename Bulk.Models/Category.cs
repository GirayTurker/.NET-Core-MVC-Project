using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bulk.Models
{
    public class Category
    {
        [Key] //Defines Primary Key for Entity Framework
        public int Id { get; set; }
        //Defines Required Fields for Entity Framework (Data Validation)
        [Required] 
        //Data Annotation
        [DisplayName("Category Name")]
        //Data Validation
        [MaxLength(30)]
        public string? Name { get; set; }
        //Data Annotation
        [DisplayName("Display Order")]
        //Data Validation
        [Range(1,10, ErrorMessage ="Display Order must be between 1-10")]
        public int DisplayOrder { get; set; }
        
        
    }
}
