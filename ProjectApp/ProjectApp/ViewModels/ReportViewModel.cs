using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectApp.ViewModels
{
    class ReportViewModel : ViewModelBase
    {
        public DelegateCommand ReportCommand { get; set; }
        public ReportViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Login Page";
            ReportCommand = new DelegateCommand(() => Report());
        }

        private void Report()
        {
           
            NavigationService.NavigateAsync("ReportPage1View");
        }

    }
}
