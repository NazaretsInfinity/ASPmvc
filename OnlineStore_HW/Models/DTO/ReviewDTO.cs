using System.ComponentModel.DataAnnotations;

namespace OnlineStore_HW.Models.DTO
{
    public class ReviewDTO
    {
        [Display(Name = "Your name:")]
        public string? Author { get; set; }

        [Display(Name = "Review text:")]
        [DataType(DataType.MultilineText)]
        public string? Text { get; set; }
    }
}
