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
        private Actor _selectedActor;

        public string MovieId { get; set; }
        public string Trailer { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public string Year { get; set; }
        public string Genres { get; set; }
        public string Time { get; set; }
        public string Rating { get; set; }
        public string Image { get; set; }
        public ObservableCollection<Actor> Cast { get; set; } = new ObservableCollection<Actor>();
        public string Text => AppResources.MovieDetail;
        public ICommand NavigateCommand { get; }
        public ICommand ShowTrailerCommand { get; }
        public MovieDetailViewModel(INavigationService navigationService, IImdbApiService imdbApiService, IPageDialogService dialogService) : base(navigationService)
        {
            _imdbApiService = imdbApiService;
            _dialogService = dialogService;
            NavigateCommand = new DelegateCommand<Actor>(OnActorSelected);
            ShowTrailerCommand = new DelegateCommand(OnClickTrailerButton);
        }

        private async void LoadMovieDetail(string movieId)
        {
            if (Connectivity.NetworkAccess == NetworkAccess.Internet)
            {
                var movieDetail = await _imdbApiService.GetTitleAsync(movieId);
                var movieTrailer = await _imdbApiService.GetTrailerAsync(movieId);

                if (movieDetail != null)
                {

                    Trailer = movieTrailer.LinkEmbed;
                    Name = movieDetail.Title;
                    Year = movieDetail.Year;
                    Description = movieDetail.Plot;
                    Genres = movieDetail.Genres;
                    Time = movieDetail.RuntimeStr;
                    Rating = movieDetail.ImDbRating ?? "N/A";
                    Image = movieDetail.Image;


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


        public void OnNavigatedFrom(INavigationParameters parameters)
        {
            throw new NotImplementedException();
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            MovieId = parameters.GetValue<string>(nameof(MovieId));
            LoadMovieDetail(MovieId);
        }

        public Actor SelectedActor
        {
            get
            {
                return _selectedActor;
            }
            set
            {
                _selectedActor = value;

                if (_selectedActor != null)
                {
                    NavigateCommand.Execute(_selectedActor);
                    SelectedActor = null;
                }
            }
        }

        private async void OnActorSelected(Actor selectedActor)
        {
            NavigationParameters navigationParameters = new NavigationParameters
            {
                { "ActorId", selectedActor.Id},
            };

            await NavigationService.NavigateAsync(NavigationConstants.Path.Actor, navigationParameters);
        }

        private async void OnClickTrailerButton()
        {
            if(Trailer != null)
            {
                await Browser.OpenAsync(Trailer, BrowserLaunchMode.SystemPreferred);
            }
            else
            {
                await _dialogService.DisplayAlertAsync(AppResources.OopsAlert, AppResources.AlertTrailerMessage, AppResources.AlertButtonText);
            }
        }
    }
}
