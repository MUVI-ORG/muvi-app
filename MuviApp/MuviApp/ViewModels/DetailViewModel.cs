using Prism.Commands;
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
            NavigateCommand = new DelegateCommand(OnNavigation);
        }

        private async void OnNavigation() => await NavigationService.NavigateAsync("Actor");
    }
}
