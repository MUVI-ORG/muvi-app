using MuviApp.Models;
using MuviApp.Services;
using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Essentials;

namespace MuviApp.ViewModels
{
    class ComingSoonViewModel : BaseViewModel
    {
        private IImdbApiService _imdbApiService;
        private IPageDialogService _dialogService;
        public ObservableCollection<Movie> Movies { get; set; } = new ObservableCollection<Movie>();
        public string Text => AppResources.ComingSoonMovies;
        public ICommand NavigateCommand { get; }

        public ComingSoonViewModel(INavigationService navigationService, IImdbApiService imdbApiService, IPageDialogService dialogService) : base(navigationService)
        {
            _imdbApiService = imdbApiService;
            _dialogService = dialogService;
            NavigateCommand = new DelegateCommand(OnNavigation);
            LoadComingSoonMovies();
        }

        private async void LoadComingSoonMovies()
        {
            if (Connectivity.NetworkAccess == NetworkAccess.Internet)
            {
                var comingSoonResponse = await _imdbApiService.GetComingSoonMoviesAsync();

                if (comingSoonResponse != null)
                {
                    foreach (Movie movie in comingSoonResponse.Movies)
                    {
                        Movies.Add(movie);
                    }
                }
            }
            else
            {
                MainThread.BeginInvokeOnMainThread(async () =>
                {
                    await _dialogService.DisplayAlertAsync(AppResources.AlertTitle, AppResources.AlertMessage, AppResources.AlertButtonText);
                });
            }
        }

        private async void OnNavigation() => await NavigationService.NavigateAsync(NavigationConstants.Path.Detail);
    }
}
