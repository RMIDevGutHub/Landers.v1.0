using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Landers.v1.Areas.TruGreen.Models
{
    public class TrugreenFormModel
    {
        
            [Required(ErrorMessage = "First Name is a Required field.")]
            [DataType(DataType.Text)]
            [Display(Order = 1, Name = "First Name")]
            [RegularExpression("^((?!^First Name$)[a-zA-Z /.'])+$", ErrorMessage = "First name is required and must be properly formatted.")]
            public string FirstName { get; set; }

            [Required(ErrorMessage = "Last Name is a Required field.")]
            [DataType(DataType.Text)]
            [Display(Order = 2, Name = "Last Name")]
            [RegularExpression("^((?!^Last Name$)[a-zA-Z /.'])+$", ErrorMessage = "Last name is required and must be properly formatted.")]
            public string LastName { get; set; }

            [Required(ErrorMessage = "Address is a Required field.")]
            [DataType(DataType.Text)]
            [Display(Order = 3, Name = "Address")]
            [RegularExpression("^((?!^Address$)[0-9A-Za-z /#.,])+$", ErrorMessage = "Address is required and must be properly formatted.")]
            public string Address { get; set; }

            [DataType(DataType.Text)]
            [Display(Order = 4, Name = "Address2")]
            public string Address2 { get; set; }

            [Required(ErrorMessage = "City is a Required field.")]
            [DataType(DataType.Text)]
            [RegularExpression("^((?!^City$)[a-zA-Z ./'])+$", ErrorMessage = "City is required and must be properly formatted.")]
            [Display(Order = 6, Name = "City")]
            //[RegularExpression(" ")]
            public string City { get; set; }

            [Required(ErrorMessage = "State is a Required field.")]
            [DataType(DataType.Text)]
            [Display(Order = 7, Name = "State")]
            //[RegularExpression(" ")]
            public IEnumerable<String> State { get; set; }

            [Required(ErrorMessage = "Zip is a Required field.")]
            [DataType(DataType.Text)]
            [RegularExpression("\\d{5}",
                ErrorMessage = "Zip Code is required and must be properly formatted.")]
            [Display(Order = 8, Name = "Zip")]
            //[RegularExpression(" ")]
            public String Zip { get; set; }

            [Required(ErrorMessage = "Phone is a Required field.")]
            [DataType(DataType.PhoneNumber)]
            [RegularExpression("^[01]?[- .]?\\(?[2-9]\\d{2}\\)?[- .]?\\d{3}[- .]?\\d{4}$",
                ErrorMessage = "Phone is required and must be properly formatted.")]
            [Display(Order = 9, Name = "Phone")]
            //[RegularExpression(" ")]
            public string Phone { get; set; }

            [Required(ErrorMessage = "Email is a Required field.")]
            [DataType(DataType.EmailAddress)]

            [RegularExpression("^[A-Za-z0-9._%+-]*@[A-Za-z0-9.-]*\\.[A-Za-z0-9-]{2,}$",
                ErrorMessage = "Email is required and must be properly formatted.")]
            [Display(Order = 10, Name = "Email")]

            public string Email { get; set; }

            [Required(ErrorMessage = "Please accept the terms, of if you prefer, please call !!!MongooseNumber!!! for your Free Quote.")]
            public bool Terms { get; set; }

            /*[Display(Order = 11, Name = "RentOrOwn")]
            [Required(ErrorMessage = "Please indicate if you rent or own.")] */
            public Boolean RentOrOwn { get; set; }

            public string Page { get; set; }

            public string PageNumber { get; set; }

            public string Tg { get; set; }

            public string TyPage { get; set; }

            public string Media { get; set; }

            public Boolean CallCenterLead { get; set; }
        
    }
}