using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace tranhoangkhai_project1.Helper
{
    public class ShowErrorMessage
    {
        private IJSRuntime _jsRuntime;

        public ShowErrorMessage(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }

        public async Task ShowMessage(string title, string message, string icon)
        {
            await _jsRuntime.InvokeVoidAsync("Swal.fire", title, message, icon.ToLower());
        }

        public async Task ShowToast(string title, string icon, int timer = 3000)
        {
            await _jsRuntime.InvokeVoidAsync("Swal.fire", new
            {
                position = "top-right",
                icon = icon.ToLower(),
                title = title,
                showConfirmButton = false,
                timer = timer
            });
        }
        public enum SweetAlertIcon
        {
            Success,
            Error,
            Warning,
            Info,
            Question
        }
    }
}
