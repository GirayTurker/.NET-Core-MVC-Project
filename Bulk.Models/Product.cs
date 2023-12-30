using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bulk.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required]
        public string? SKU { get; set; }
        [Required]
        [Display(Name ="Brand Name")]
        public string BrandName { get; set; }
        [Required]
        public string? Description { get; set; }
        
        [Required]
        [Range(1,100000)]
        [Display(Name = "Price for 1")]
        public double? Price { get; set; }
       
        [Required]
        [Display(Name = "Price for 2-10")]
        [Range(1, 100000)]
        public double? Price2 { get; set; }
        
        [Required]
        [Display(Name = "Price for 10+")]
        [Range(1, 100000)]
        public double? PriceMoreThan10 { get; set; }


        public int CategoryId { get; set; }

        //Navigation Property for CategoryId (navigate Id in Category table)
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
    }
}
