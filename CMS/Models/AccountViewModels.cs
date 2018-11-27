using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CMS.Models
{
   public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name ="姓名")]
        public string UserName { get; set; }
    }
    public class ManageUserViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name ="旧密码")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100,ErrorMessage ="请至少输入6位长度的密码",MinimumLength =6)]
        [DataType(DataType.Password)]
        [Display(Name ="新密码")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name ="确认新密码")]
        [Compare("NewPassword",ErrorMessage ="输入密码不一致，请重新输入")]
        public string ConfirmPassword { get; set; }
    }
    public class LoginViewModel
    {
        [Required]
        [Display(Name ="姓名")]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name ="密码")]
        public string Password { get; set; }
        [Display(Name ="记住账户密码")]
        public bool RememberMe { get; set; }
    }
}