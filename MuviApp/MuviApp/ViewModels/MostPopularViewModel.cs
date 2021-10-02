using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MuviApp.ViewModels
{
    public class MostPopularViewModel : BaseViewModel
    {
        public string Text => "Most Popular Movies Page";
        public ICommand NavigateCommand { get; }

        public MostPopularViewModel(INavigationService navigationService) : base(navigationService)
        {
            NavigateCommand = new Command(OnNavigation);
        }

        private async void OnNavigation() => await NavigationService.NavigateAsync(NavigationConstants.Path.Detail);
    }
}
