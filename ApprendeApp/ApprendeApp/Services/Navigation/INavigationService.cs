using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ApprendeApp.Services.Navigation
{
    public interface INavigationService
    {
        Task NavigateToAsync(string pageName, NavigationPage parentNavigationPage);

        Task NavigateBackAsync(NavigationPage parentNavigationPage);
    }
}
