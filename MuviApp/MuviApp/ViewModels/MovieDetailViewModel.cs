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
    class MovieDetailViewModel : BaseViewModel, INavigatedAware
    {
        private IImdbApiService _imdbApiService;
        private IPageDialogService _dialogService;

        public string MovieId { get; set; }
        public object Trailer { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public string Year { get; set; }
        public string Genres { get; set; }
        public string Time { get; set; }
        public string Rating { get; set; }
        public ObservableCollection<Actor> Cast { get; set; } = new ObservableCollection<Actor>();
        public string Text => AppResources.MovieDetail;
        public ICommand NavigateCommand { get; }

        public MovieDetailViewModel(INavigationService navigationService, IImdbApiService imdbApiService, IPageDialogService dialogService) : base(navigationService)
        {
            _imdbApiService = imdbApiService;
            _dialogService = dialogService;
            NavigateCommand = new DelegateCommand(OnNavigation);
            //LoadMovieDetail(MovieId);
        }

        private async void LoadMovieDetail(string movieId)
        {
            if (Connectivity.NetworkAccess == NetworkAccess.Internet)
            {
                var movieDetail = await _imdbApiService.GetTitleAsync(movieId);

                if (movieDetail != null)
                {

                    Trailer = movieDetail.Trailer;
                    Name = movieDetail.Title;
                    Year = movieDetail.Year;
                    Description = movieDetail.Plot;
                    Genres = movieDetail.Genres;
                    Time = movieDetail.RuntimeStr;
                    Rating = movieDetail.ImDbRating;

                    foreach (var actor in movieDetail.ActorList)
                    {
                        Cast.Add(actor);
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

        private async void OnNavigation() => await NavigationService.NavigateAsync(NavigationConstants.Path.Actor);

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
            throw new NotImplementedException();
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            MovieId = parameters.GetValue<string>(nameof(MovieId));
        }
    }
}
