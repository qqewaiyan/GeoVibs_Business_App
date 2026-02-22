using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeoVibs_Business.Shared.Services
{
    public class AppNavigationService
    {
        private readonly NavigationManager _nav;

        public AppNavigationService(NavigationManager nav)
        {
            _nav = nav;
        }

        public void GoToRoute(string routeName)
        {
            _nav.NavigateTo(routeName);
        }
    }

}
