using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MuviApp.ViewModels
{
    class ActorDetailViewModel : BaseViewModel
    {
        public string Text => AppResources.ActorDetail;
        public ICommand NavigateCommand { get; }

        public ActorDetailViewModel(INavigationService navigationService) : base(navigationService)
        {
            //NavigateCommand = new Command(OnNavigation);
        }
    }
}
