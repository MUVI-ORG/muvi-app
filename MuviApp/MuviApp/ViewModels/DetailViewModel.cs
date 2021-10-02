using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MuviApp.ViewModels
{
    class DetailViewModel : BaseViewModel
    {
        public string Text => "Detail Page";
        public ICommand NavigateCommand { get; }

        public DetailViewModel(INavigationService navigationService) : base(navigationService)
        {
            NavigateCommand = new Command(OnNavigation);
        }

        private async void OnNavigation() => await NavigationService.NavigateAsync("Actor");
    }
}
