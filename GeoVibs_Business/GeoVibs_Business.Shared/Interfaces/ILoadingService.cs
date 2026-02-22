using System;
using System.Collections.Generic;
using System.Text;

namespace GeoVibs_Business.Shared.Interfaces
{
    public interface ILoadingService
    {
        Task ShowAsync();
        Task HideAsync();
    }

}
