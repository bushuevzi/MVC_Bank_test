using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Bank_test.Models
{
    public class CheckingAccount
    {
        public int Id { get; set; }

        [Required]
        //[StringLength(10, MinimumLength =6)]
        [RegularExpression(@"\d{6,10}", ErrorMessage = "Номер должен содержать от 6 до 10 цифр")]
        [Display(Name="Account #")]
        public string AccountNumber { get; set; }
        
        [Required]
        [Display(Name ="First Name:")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name ="Last Name:")]
        public string LastName { get; set; }

        public string Name
        {
            get
            {
                return string.Format($"{this.FirstName} {this.LastName}");
            }
        }

        [DataType(DataType.Currency)]
        public decimal Balance { get; set; }

        public virtual ApplicationUser User { get; set; }

        public string ApplicationUserID { get; set; }
    }
}