using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Model
{
    public class JobViewModel
    {
        public int ID { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        public string JobDescription { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string Client { get; set; }
        [Required]
        [Display(Name ="Experience in Years")]
        public string Experience { get; set; }
        [Required]
        public string GeneralSkills { get; set; }
        [Required]
        public string Technology { get; set; }
        [Required]
        public string TechnicalSkills { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        public string AboutClient { get; set; }
        [Required]
        public int Positions { get; set; }
        [Required]
        public bool IsActive { get; set; }
        [Required]
        public string CreatedBy { get; set; }
        [Required]
        public string ReferralAmount { get; set; }
        [Required]
        [Range(1, 3, ErrorMessage = "Select Job Type")]
        public JobType JobType { get; set; }
    }
    public enum JobType
    {
        Permanent = 1,
        Contract = 2
    }
}
