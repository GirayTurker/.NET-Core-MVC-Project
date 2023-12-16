using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkProject.Models
{
    public class Category
    {
        [Key] //Defines Primary Key for Entity Framework
        public int Id { get; set; }
        [Required] //Defines Required Fields for Entity Framework
                   //Data Annotation
        [DisplayName("Category Name")]
        public string? Name { get; set; }
        //Data Annotation
        [DisplayName("Display Order")]
        public int DisplayOrder { get; set; }
        //Data Annotation
        
    }
}
