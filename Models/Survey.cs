//validation implementation with Data Annotations
using System.ComponentModel.DataAnnotations;
namespace DojoSurvey.Models
{
    public class Survey
    {
        [Required]
        [MinLength(2)]
        [MaxLength(30)]
        [Display(Name = "Your Name:")]
        public string Name{get;set;}
        public string Location{get;set;}
        public string Language{get;set;}
        public string Comment{get;set;}
    }
}