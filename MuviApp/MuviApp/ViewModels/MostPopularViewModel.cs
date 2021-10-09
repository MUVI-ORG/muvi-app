using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;


namespace MuviApp.ViewModels
{
    public class MostPopularViewModel : BaseViewModel
    {
        public string Text => AppResources.MostPopularMovies;
        public ICommand NavigateCommand { get; }

        public MostPopularViewModel(INavigationService navigationService) : base(navigationService)
        {
            NavigateCommand = new DelegateCommand(OnNavigation);
        }

        private async void OnNavigation() => await NavigationService.NavigateAsync(NavigationConstants.Path.Detail);
    }
}
