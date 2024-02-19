using System.ComponentModel.DataAnnotations;

namespace formWithDbConn.Models
{
    public class Student
    {
        [Required(ErrorMessage = " Name Paraaa")]
        [StringLength(100)]
        [RegularExpression(@"^[a-z A-Z]*$", ErrorMessage = "Enter alphabets and space only")]
        public string Name { get; set; }

        [Required(ErrorMessage = "vayass ethraaa ")]

        [Display(Name = "Age")]
        public int Age { get; set; }

        [Required(ErrorMessage = "phone number kodukk machaaaa.. edak okee vilikendee ")]
        [Display(Name = "Phone")]
        [Phone(ErrorMessage = "number only")]
        public string PhNo { get; set; }

        [Required(ErrorMessage = "please enter Email")]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Format thettaan")]
        public string Emailid { get; set; }


        [Required(ErrorMessage = "please enter your choice")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "ni eth naatukarenn an")]
        [Display(Name = "Country")]
        public string Country { get; set; }

        [Required(ErrorMessage = " State eth an Mwonuseeee")]
        [Display(Name = "State")]
        public string State { get; set; }

        [Required(ErrorMessage = " cityyy paraaaa")]
        [Display(Name = "City")]
        public string City { get; set; }
    }
}
