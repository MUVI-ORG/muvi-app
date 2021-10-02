using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MuviApp.ViewModels
{
    class MovieDetailViewModel : BaseViewModel
    {
        public string Text => AppResources.MovieDetail;
        public ICommand NavigateCommand { get; }

        public MovieDetailViewModel(INavigationService navigationService) : base(navigationService)
        {
            NavigateCommand = new DelegateCommand(OnNavigation);
        }

        private async void OnNavigation() => await NavigationService.NavigateAsync(NavigationConstants.Path.Actor);
    }
}
