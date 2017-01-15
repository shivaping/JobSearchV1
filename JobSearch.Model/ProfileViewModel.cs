using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace JobSearch.Model
{
    public class ProfileViewModel 
    {
        public ProfileViewModel()
        {
            this.EducationViewModel = new List<EducationViewModel>() { new Model.EducationViewModel() };
        }
        public int ID { get; set; }
        [Required]
        [Display(Name = "Profile Name")]
        public string ProfileName { get; set; }

        [Display(Name = "Profile Description")]
        [DataType(DataType.MultilineText)]
        public string ProfileDescription { get; set; }

        [Display(Name = "Resume File Name")]
        public string ResumeFileName { get; set; }

        [Required]
        [Display(Name = "Current Location")]
        public string CurrentLocation { get; set; }

        [Required]
        [Display(Name = "Preferred Location")]
        public string PreferredLocation { get; set; }

        [Required]
        [Display(Name = "Current Role")]
        public string CurrentRole { get; set; }

        [Required]
        [Display(Name= "Date Of Birth")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> Dob { get; set; }

        [Required]
        public GenderType Gender { get; set; }

        [Required]
        
        [Display(Name = "Experience in Months")]
        [Range(0, int.MaxValue, ErrorMessage = "Experience must be a positive number")]
        public int Experience { get; set; }

        [Required]
        [Display(Name = "Current CTC in Lacs")]
        [RegularExpression("[+-]?([0-9]*[.])?[0-9]+", ErrorMessage = "CTC must be a valid value.")]
        public decimal? CurrentCtc { get; set; }

        public bool Active { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Your must provide a PhoneNumber")]
        [Display(Name = "Home Phone")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^([\+]|0)[(\s]{0,1}[2-9][0-9]{0,2}[\s-)]{0,2}[0-9][0-9][0-9\s-]*[0-9]$", ErrorMessage = "Please enter a valid phone number with country code")]

        public string PhoneNumber { get; set; }

        [Display(Name = "Skills (Comma Seperated)")]
        [DataType(DataType.MultilineText)]
        public string Skill { get; set; }

        public List<EducationViewModel> EducationViewModel { get; set; }

        [NotMapped]
        [DataType(DataType.Upload)]
        [FileExtensions(Extensions = ".pdf,.doc,.docx", ErrorMessage = "Please upload valid format")]
        public HttpPostedFileBase FileUpload { get; set; }
    }
    public enum GenderType
    {
        Male = 1,
        Female = 2
    }

    public class EducationViewModel
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Qualification")]
        public string Qualification { get; set; }

        [Required]
        [Display(Name = "Specialization")]
        public string Specialization { get; set; }

        [Required]
        [Display(Name = "Institute")]
        public string Institute { get; set; }

        [Required]
        [Display(Name = "Year")]
        public int? Year { get; set; }
    }
}
