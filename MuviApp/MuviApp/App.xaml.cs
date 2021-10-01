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

            NavigationService.NavigateAsync($"NavigationPage/MainTabbedPage?{KnownNavigationParameters.SelectedTab}=Top");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<TopPage, TopViewModel>("Top");
            containerRegistry.RegisterForNavigation<ComingSoonPage, ComingSoonViewModel>("ComingSoon");
            containerRegistry.RegisterForNavigation<DetailPage, DetailViewModel>("Detail");
            containerRegistry.RegisterForNavigation<MainTabbedPage>();

        }
    }
}
