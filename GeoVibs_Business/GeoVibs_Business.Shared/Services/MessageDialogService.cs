using GeoVibs_Business.Shared.ReusableComponents;
using MudBlazor;

namespace GeoVibs_Business.Shared.Services
{
    public class MessageDialogService
    {
        private readonly IDialogService _dialog;

        public MessageDialogService(IDialogService dialog)
        {
            _dialog = dialog;
        }

        public async Task ShowError(string title,string message)
        {
            var parameters = new DialogParameters
        {
            { "Title", title },
            { "Message", message },
            { "Icon", Icons.Material.Filled.Error },
            { "Color", Color.Error },
            { "IsConfirmation", false },
            { "ConfirmText", "OK" }
        };

            await  _dialog.ShowAsync<MessageDialog>(title, parameters);
        }

        public async Task<bool> ShowConfirm(string title, string message)
        {
            var parameters = new DialogParameters
    {
        { "Title", title },
        { "Message", message },
        { "Icon", Icons.Material.Filled.Help },
        { "Color", Color.Warning },
        { "IsConfirmation", true },
        { "ConfirmText", "Yes" }
    };

            var dialog = await _dialog.ShowAsync<MessageDialog>(title, parameters);

            var result = await dialog.Result;
            if(result is null) return false;
            return !result.Canceled;
        }
    }
}
