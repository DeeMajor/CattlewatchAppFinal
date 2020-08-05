using CattleMobile.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace CattleMobile.ViewModel
{
    public class RegisterViewModel
    {
        ApiServices _apiServices = new ApiServices();
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

        public ICommand RegisterCommand
        {
            get
            {
                return new Command(() =>
               {
                   _apiServices.RegisterAsync(Email, Password, ConfirmPassword);
               });
            }
        }
    }
}
