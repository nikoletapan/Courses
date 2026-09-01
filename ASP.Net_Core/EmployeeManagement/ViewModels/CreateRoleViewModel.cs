using Microsoft.AspNetCore.Authorization;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.ViewModels
{
   
    public class CreateRoleViewModel
    {
        [Required]
        public string RoleName { get; set; }
    }
}
