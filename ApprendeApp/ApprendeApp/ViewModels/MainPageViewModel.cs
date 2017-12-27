using System;
using System.Threading.Tasks;
using ApprendeApp.Models;
using ApprendeApp.Providers;
using ApprendeApp.Views.Popups;
using Rg.Plugins.Popup.Contracts;
using Rg.Plugins.Popup.Services;

namespace ApprendeApp.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        public DelegateCommand NotificationsCommand { get; set; }

        private IPopupNavigation _popupNavigation;
        public MainPageViewModel()
        {
            _popupNavigation = PopupNavigation.Instance;
            NotificationsCommand = new DelegateCommand(async ()=>await NotificationsCommandExecute());
        }

        private async Task NotificationsCommandExecute()
        {
            await _popupNavigation.PushAsync(new NotificationsPopup());
        }
    }
}
