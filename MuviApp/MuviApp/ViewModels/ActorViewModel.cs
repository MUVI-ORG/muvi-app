using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MuviApp.ViewModels
{
    class ActorViewModel : BaseViewModel
    {
        public string Text => "Actor Page";
        public ICommand NavigateCommand { get; }

        public ActorViewModel(INavigationService navigationService) : base(navigationService)
        {
            //NavigateCommand = new Command(OnNavigation);
        }
    }
}
