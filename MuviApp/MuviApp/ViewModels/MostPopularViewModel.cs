using MuviApp.Models;
using MuviApp.Services;
using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;

namespace MuviApp.ViewModels
{
    public class MostPopularViewModel : BaseViewModel
    {
        private IImdbApiService _imdbApiService;
        private IPageDialogService _dialogService;
        public ObservableCollection<Movie> Movies { get; set; } = new ObservableCollection<Movie>();
        public string Text => AppResources.MostPopularMovies;
        public ICommand NavigateCommand { get; }

        public MostPopularViewModel(INavigationService navigationService, IImdbApiService imdbApiService, IPageDialogService dialogService) : base(navigationService)
        {
            _imdbApiService = imdbApiService;
            _dialogService = dialogService;
            NavigateCommand = new DelegateCommand(OnNavigation);
            LoadMostPopularMovie();
        }

        private async Task LoadMostPopularMovie()
        {
            if(Connectivity.NetworkAccess == NetworkAccess.Internet)
            {
                var movieResponse = await _imdbApiService.GetPopularMoviesAsync();

                if(movieResponse != null)
                {
                    foreach(Movie movie in movieResponse.Movies)
                    {
                        Movies.Add(movie);
                    }
                }
            }
            else
            {
                MainThread.BeginInvokeOnMainThread(async () =>
                {
                    await _dialogService.DisplayAlertAsync("Alerta", "No hay conexión a Internet", "OK");
                });
            }
        }

        private async void OnNavigation() => await NavigationService.NavigateAsync(NavigationConstants.Path.Detail);
    }
}
