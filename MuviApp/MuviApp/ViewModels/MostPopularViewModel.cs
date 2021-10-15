using MuviApp.Models;
using MuviApp.Services;
using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace MuviApp.ViewModels
{
    public class MostPopularViewModel : BaseViewModel
    {
        private IImdbApiService _imdbApiService;
        private IPageDialogService _dialogService;
        private Movie _selectedMovie;
        private ObservableCollection<Movie> _movies = new ObservableCollection<Movie>();
        public ObservableCollection<Movie> Movies
        {
            get
            {
                ObservableCollection<Movie> theCollection = new ObservableCollection<Movie>();

                if (_movies != null && _searchText != null)
                {
                    List<Movie> entities = (from e in _movies
                                                 where e.Title.ToLowerInvariant().Contains(_searchText.ToLowerInvariant())
                                                 select e).ToList<Movie>();
                    if (entities != null && entities.Any())
                    {
                        theCollection = new ObservableCollection<Movie>(entities);
                    }
                }
                else
                {
                    theCollection = _movies;
                }

                return theCollection;
            }
        }
        public string Text => AppResources.MostPopularMovies;
        public ICommand NavigateCommand { get; }
        public ICommand PerformSearch { get; }
        public MostPopularViewModel(INavigationService navigationService, IImdbApiService imdbApiService, IPageDialogService dialogService) : base(navigationService)
        {
            _imdbApiService = imdbApiService;
            _dialogService = dialogService;
            NavigateCommand = new DelegateCommand<Movie>(OnMovieSelected);
            LoadMostPopularMovies();
        }

        private async void LoadMostPopularMovies()
        {
            if(Connectivity.NetworkAccess == NetworkAccess.Internet)
            {
                var movieResponse = await _imdbApiService.GetPopularMoviesAsync();

                if(movieResponse != null)
                {
                    foreach(Movie movie in movieResponse.Movies)
                    {
                        _movies.Add(movie);
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

        public Movie SelectedMovie
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

        private async void OnMovieSelected(Movie selectedMovie)
        {
            NavigationParameters navigationParameters = new NavigationParameters
            {
                { "MovieId", selectedMovie.Id },
            };

            await NavigationService.NavigateAsync(NavigationConstants.Path.Detail, navigationParameters);
        }

        private string _searchText;
        public string SearchText
        {
            get { return _searchText; }
            set { if (_searchText != value) { _searchText = value; } }
        }





        public void SearchBarTextChanged(object sender, TextChangedEventArgs e)
        {
            Console.WriteLine("Changing from viewmodel");
            var searchTerm = e.NewTextValue;

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                searchTerm = string.Empty;
            }

            searchTerm = searchTerm.ToLowerInvariant();

            var filteredMovies = Movies.Where(value => value.Title.ToLowerInvariant().Contains(searchTerm)).ToList();

            foreach (var value in Movies)
            {
                if (!filteredMovies.Contains(value))
                {
                    Movies.Remove(value);
                }
                else if (!Movies.Contains(value))
                {
                    Movies.Add(value);
                }
            }
        }
    }
}
