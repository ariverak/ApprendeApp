using System;
using System.Reflection;
using System.Threading.Tasks;
using ApprendeApp.Models;
using ApprendeApp.Providers;
using ApprendeApp.Services.Navigation;
using ApprendeApp.Views;
using ApprendeApp.Views.Popups;
using Rg.Plugins.Popup.Contracts;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;

namespace ApprendeApp.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        public DelegateCommand NotificationsCommand { get; set; }
        public DelegateCommand<string> MenuRedirectCommand { get; set; }
        
        private IPopupNavigation _popupNavigation;
        private INavigationService _navigationService;
        public MainPageViewModel()
        {
            _popupNavigation = PopupNavigation.Instance;
            _navigationService = DependencyService.Get<INavigationService>();
            NotificationsCommand = new DelegateCommand(async ()=>await NotificationsCommandExecute());
            MenuRedirectCommand = new DelegateCommand<string>(async (x) => await MenuRedirectCommandExecute(x));
        }

        private async Task NotificationsCommandExecute()
        {
            await _popupNavigation.PushAsync(new NotificationsPopup());
        }
        private async Task MenuRedirectCommandExecute(string pageName)
        {
            var parentNavigation = (Application.Current.MainPage as MainPage).Detail as NavigationPage;
            await _navigationService.NavigateToAsync("ContentEvaluation", parentNavigation);
        }
    }
}
