using Microsoft.JSInterop;

namespace BlazorPeliculas.Client.Helpers
{
	public static class IJSRuntimeExtensionMethods
	{
		public static async ValueTask<bool> Confirm(this IJSRuntime js, string mensaje)
		{
			await js.InvokeVoidAsync("console.log", "Pruba de consola");
			return await js.InvokeAsync<bool>("confirm", mensaje);
		}
	}
}
