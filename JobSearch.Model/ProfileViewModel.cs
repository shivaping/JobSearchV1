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
            this.SkillViewModel = new List<SkillViewModel>();
            this.EducationViewModel = new List<EducationViewModel>() { new Model.EducationViewModel() };
        }
        public int ID { get; set; }
        [Required]
        [Display(Name = "Profile Name")]
        public string ProfileName { get; set; }

        [Required]
        [Display(Name = "Profile Description")]
        public string ProfileDescription { get; set; }

        [Required]
        public byte[] Resume { get; set; }

        [Required]
        [Display(Name = "Current Location")]
        public string CurrentLocation { get; set; }

        [Required]
        [Display(Name = "Preferred Location")]
        public string PreferredLocation { get; set; }

        public string CurrentRole { get; set; }

        [Required]
        [Display(Name= "Date Of Birth")]
        [DataType(DataType.Date)]
        public System.DateTime Dob { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        
        [Display(Name = "Experience in Months")]
        public double Experience { get; set; }

        [Required]
        [Display(Name = "Current CTC in Lacs")]
        [RegularExpression("[+-]?([0-9]*[.])?[0-9]+", ErrorMessage = "CTC must be a valid value.")]
        public decimal CurrentCtc { get; set; }

        public bool Active { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
        public List<SkillViewModel> SkillViewModel { get; set; }
        public List<EducationViewModel> EducationViewModel { get; set; }

        [Required]
        [NotMapped]
        [DataType(DataType.Upload)]
        [Display(Name = "Choose Resume File")]
        [ValidateFile(ErrorMessage = "Please select a PNG image smaller than 1MB")]
        [FileExtensions(Extensions = ".pdf,.doc,.docx", ErrorMessage = "Please upload valid format")]
        public HttpPostedFileBase FileUpload { get; set; }
    }
    public class ValidateFileAttribute : RequiredAttribute
    {
        public override bool IsValid(object value)
        {
          
            return false;
        }
    }
    public class SkillViewModel
    {
        public int ID { get; set; }
        public string SkillName { get; set; }
        public string SkillDescription { get; set; }
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
