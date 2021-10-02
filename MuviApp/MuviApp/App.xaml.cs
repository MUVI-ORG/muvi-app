using MuviApp.ViewModels;
using MuviApp.Views;
using Prism;
using Prism.Ioc;
using Prism.Navigation;
using Prism.Unity;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MuviApp
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer platformInitializer) : base(platformInitializer) {}

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync($"NavigationPage/MainTabbedPage?{KnownNavigationParameters.SelectedTab}={NavigationConstants.Path.MostPopular}");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MostPopularPage, MostPopularViewModel>(NavigationConstants.Path.MostPopular);
            containerRegistry.RegisterForNavigation<ComingSoonPage, ComingSoonViewModel>(NavigationConstants.Path.ComingSoon);
            containerRegistry.RegisterForNavigation<DetailPage, DetailViewModel>(NavigationConstants.Path.Detail);
            containerRegistry.RegisterForNavigation<ActorPage, ActorViewModel>(NavigationConstants.Path.Actor);
            containerRegistry.RegisterForNavigation<MainTabbedPage>();

        }
    }
}
