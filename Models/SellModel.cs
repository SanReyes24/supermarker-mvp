using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Supermarket_mvp.Models
{
    internal class SellModel
    {
        [DisplayName("Sell Id")]
        public int Id { get; set; }

        [DisplayName("Customer Id")]
        [Required(ErrorMessage = "Customer Id is required")]
        [RegularExpression(@"^.*[1-9].*$", ErrorMessage = "Customer Id" +
            "is required and must contain at least one non-zero digit")]
        [Range(1, int.MaxValue, ErrorMessage = "Product Price must" +
            " be between 3 and 200 characters")]
        public int CustomerId { get; set; }

        [DisplayName("Total")]
        [Required(ErrorMessage = "Total is required")]
        [RegularExpression(@"^.*[1-9].*$", ErrorMessage = "Total Quantity " +
            "must contain at least one non-zero digit")]
        [Range(1, int.MaxValue, ErrorMessage = "Total must" +
            " be between 3 and 200 characters")]
        public int Total { get; set; }

        [DisplayName("Pay Mode")]
        [Required(ErrorMessage = "Pay Mode is required")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "Pay Mode must" +
            " be between 3 and 200 characters")]
        public string PayMode { get; set; }

        [DisplayName("Observation")]
        [Required(ErrorMessage = "Obsrvacion is required")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "Observation must" +
            " be between 3 and 200 characters")]
        public string Observation { get; set; }

    }
}
