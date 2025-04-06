using System.ComponentModel.DataAnnotations;
using TheplaceEmployeeManagement.Data.Enums;
using TheplaceEmployeeManagement.Models;

namespace TheplaceEmployeeManagement.Models
{
    public class Employee : UserActivity
    {
        [Key]
        public Guid Id { get; set; }

        public int? EmpNo { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = "Employee name must have 3 or more character")]
        [MaxLength(50, ErrorMessage = "Maximum number character exceeded")]
        public string FirstName { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = "Employee name must have 3 or more character")]
        [MaxLength(50, ErrorMessage = "Maximum number character exceeded")]
        public string LastName { get; set; }

        [MinLength(3, ErrorMessage = "Employee name must have 3 or more character")]
        [MaxLength(50, ErrorMessage = "Maximum number character exceeded")]
        public string MiddleName { get; set; }

        public string FullName => $"{FirstName} {MiddleName} {LastName}";

        public string? EmployeeImageUrl { get; set; }

        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }

        [Required]
        public string ResidentialAddress { get; set; }

        [Required, Range(10, 100, ErrorMessage = "Please enter valid Age")]
        public int Age { get; set; }

        [Required]
        public long PhoneNumber { get; set; }

        [Required]
        public DateTime DateEmployed { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public SkinColor SkinColor { get; set; }

        [Required]
        public BranchName BranchName { get; set; }

        [Required]
        public Department Department { get; set; }

        [Required]
        public StateName StateName { get; set; }

        [Required]
        public Designation Designation { get; set; }

    }
}