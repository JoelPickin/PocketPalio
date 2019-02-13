using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PocketPalio.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private INavigationService _navigationService { get; set; }
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
            _navigationService = navigationService;
        }
    }
}
