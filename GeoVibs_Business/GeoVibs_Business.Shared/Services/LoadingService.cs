using GeoVibs_Business.Shared.Interfaces;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeoVibs_Business.Shared.Services
{
    public class LoadingService : ILoadingService
    {
        private readonly IJSRuntime _js;

        public LoadingService(IJSRuntime js)
        {
            _js = js;
        }

        public async Task ShowAsync()
        {
            await _js.InvokeVoidAsync("LoadingJs.ToggleLoading", true);
        }

        public async Task HideAsync()
        {
            await _js.InvokeVoidAsync("LoadingJs.ToggleLoading", false);
        }
    }
}
