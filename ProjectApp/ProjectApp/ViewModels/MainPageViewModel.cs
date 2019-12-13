using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Essentials;

namespace ProjectApp.ViewModels
{

    
    public class MainPageViewModel : ViewModelBase
    {

        
        string _userName;
        public string UserName
        {
            get { return _userName; }
            set { SetProperty(ref _userName, value); }
        }

        string _password;
        

        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
            
        }

        bool _myswitch;

        public bool MySwitch
        {
            get { return _myswitch; }
            set { SetProperty(ref _myswitch, value); }
        }
        public DelegateCommand LoginCommand { get; set; }
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Login Page";
            LoginCommand = new DelegateCommand(() => Login());
        }

        private void Login()
        {
            Preferences.Set("Name", UserName);
            Preferences.Set("Password", Password);
            Preferences.Set("MySwitch", MySwitch);
            NavigationService.NavigateAsync("ContentPage1View");
        }
   
    
       
    }
}
