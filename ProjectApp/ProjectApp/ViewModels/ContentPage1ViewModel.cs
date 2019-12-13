using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;

namespace ProjectApp.ViewModels
{
    public class ContentPage1ViewModel : BindableBase
    {
        string _UserName;
        public string UserName
        {
            get { return _UserName; }
            set { SetProperty(ref _UserName, value); }

        }

        public ContentPage1ViewModel()
        {
           UserName= Preferences.Get("Name", "");
            
        }
  
    
        
    }
}
