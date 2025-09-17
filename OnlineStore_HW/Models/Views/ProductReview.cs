using OnlineStore_HW.Models.DTO;
using OnlineStore_HW.Models.Entities;

namespace OnlineStore_HW.Models.Views
{
    public class ProductView
    {
        public required Product Product { get; set; }

        public required ReviewDTO? ReviewDTO { get; set; }

    }
}
