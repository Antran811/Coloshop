﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;

namespace WebBanHangOnline.Models
{
    public class IndexViewModel
    {
        public bool HasPassword { get; set; }
        public IList<UserLoginInfo> Logins { get; set; }
        public string PhoneNumber { get; set; }
        public bool TwoFactor { get; set; }
        public bool BrowserRemembered { get; set; }
    }

    public class ManageLoginsViewModel
    {
        public IList<UserLoginInfo> CurrentLogins { get; set; }
        public IList<AuthenticationDescription> OtherLogins { get; set; }
    }

    public class FactorViewModel
    {
        public string Purpose { get; set; }
    }

    public class SetPasswordViewModel
    {
        [Required]
        [StringLength(100, ErrorMessage = "Mật khẩu yếu !!!", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Mật khẩu mới ")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Xác nhận mật khẩu mới ")]
        [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

    public class ChangePasswordViewModel
    {
        [Required(ErrorMessage = "Không được bỏ trống ")]
        [DataType(DataType.Password)]
        [Display(Name = "Mật khẩu hiện tại ")]
        public string OldPassword { get; set; }

        [Required(ErrorMessage = "Không được bỏ trống ")]

        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Mật khẩu mới ")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "xác nhận mật khẩu ")]
        [Compare("NewPassword", ErrorMessage = "Mật khẩu không trùng khớp !!!")]
        public string ConfirmPassword { get; set; }
    }

    public class AddPhoneNumberViewModel
    {
        [Required(ErrorMessage = "Không được bỏ trống ")]

        [Phone]
        [Display(Name = "Số điện thoại ")]
        public string Number { get; set; }
    }

    public class VerifyPhoneNumberViewModel
    {
        [Required(ErrorMessage = "Không được bỏ trống ")]

        [Display(Name = "Mã")]
        public string Code { get; set; }

        [Required(ErrorMessage = "Không được bỏ trống ")]

        [Phone]
        [Display(Name = "Số điện thoại ")]
        public string PhoneNumber { get; set; }
    }

    public class ConfigureTwoFactorViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
    }
}