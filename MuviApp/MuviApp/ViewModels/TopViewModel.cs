using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MuviApp.ViewModels
{
    public class TopViewModel : BaseViewModel
    {
        public string Text => "Top Movies Page";
        public ICommand NavigateCommand { get; }

        public TopViewModel(INavigationService navigationService) : base(navigationService)
        {
            NavigateCommand = new Command(OnNavigation);
        }

        private async void OnNavigation() => await NavigationService.NavigateAsync("Detail");
    }
}
