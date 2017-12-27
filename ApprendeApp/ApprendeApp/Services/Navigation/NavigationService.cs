using ApprendeApp.Providers;
using ApprendeApp.Services.Navigation;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;


[assembly: Dependency(typeof(NavigationService))]
namespace ApprendeApp.Services.Navigation
{
    public class NavigationService : INavigationService
    {
        public async Task NavigateToAsync(string pageName, NavigationPage parentNavigation)
        {
            Type pageType = ViewManager.GetViewType(pageName);
            var page = Activator.CreateInstance(pageType) as Page;
            await parentNavigation.PushAsync(page);
        }
        public async Task NavigateBackAsync(NavigationPage parentNavigation)
        {
            await parentNavigation.PopAsync();
        }
    }
}
