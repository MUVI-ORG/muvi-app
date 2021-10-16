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
    public class ActorDetailViewModel : BaseViewModel, INavigatedAware
    {
        private IImdbApiService _imdbApiService;
        private IPageDialogService _dialogService;
        private MovieInformationResponse _selectedMovie;

        public string ActorId { get; set; }
        public string ActorName { get; set; }
        public string Biography { get; set; }
        public string Image { get; set; }
        public ObservableCollection<MovieInformationResponse> Movies { get; set; } = new ObservableCollection<MovieInformationResponse>();
        public string Text => AppResources.ActorDetail;
        public ICommand NavigateCommand { get; }

        public ActorDetailViewModel(INavigationService navigationService, IImdbApiService imdbApiService, IPageDialogService dialogService) : base(navigationService)
        {
            _imdbApiService = imdbApiService;
            _dialogService = dialogService;
            NavigateCommand = new DelegateCommand<MovieInformationResponse>(OnMovieSelected);
        }

        private async void LoadActorDetail(string actorId)
        {
            if (Connectivity.NetworkAccess == NetworkAccess.Internet)
            {
                var actorDetail = await _imdbApiService.GetActorDetailAsync(actorId);

                if (actorDetail != null)
                {

                    ActorName = actorDetail.Name;
                    Biography = actorDetail.Summary;
                    Image = actorDetail.Image;

                    foreach (CastMovy castMovy in actorDetail.CastMovies)
                    {
                        var movie = await _imdbApiService.GetTitleAsync(castMovy.Id);
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

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
            throw new NotImplementedException();
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            ActorId = parameters.GetValue<string>(nameof(ActorId));
            LoadActorDetail(ActorId);
        }

        public MovieInformationResponse SelectedMovie
        {
            get
            {
                return _selectedMovie;
            }
            set
            {
                _selectedMovie = value;

                if (_selectedMovie != null)
                {
                    NavigateCommand.Execute(_selectedMovie);
                    SelectedMovie = null;
                }
            }
        }

        private async void OnMovieSelected(MovieInformationResponse selectedMovie)
        {
            NavigationParameters navigationParameters = new NavigationParameters
            {
                { "MovieId", selectedMovie.Id },
            };

            await NavigationService.NavigateAsync(NavigationConstants.Path.Detail, navigationParameters);
        }
    }
}