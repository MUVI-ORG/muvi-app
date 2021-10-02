using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MuviApp.ViewModels
{
    class ComingSoonViewModel : BaseViewModel
    {
        public string Text => "Coming Soon Page";
        public ICommand NavigateCommand { get; }

        public ComingSoonViewModel(INavigationService navigationService) : base(navigationService)
        {
            NavigateCommand = new Command(OnNavigation);
        }

        private async void OnNavigation() => await NavigationService.NavigateAsync(NavigationConstants.Path.Detail);
    }
}
