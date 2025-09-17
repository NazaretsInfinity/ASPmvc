using System.ComponentModel.DataAnnotations;

namespace OnlineStore_HW.Models.DTO
{
    public class ReviewDTO
    {
        [Display(Name = "Your name:")]
        [Required(ErrorMessage ="Type yourn name")]
        public string? Author { get; set; }

        [Display(Name = "Review text:")]
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Review can't be empty")]
        public string? Text { get; set; }
    }
}
