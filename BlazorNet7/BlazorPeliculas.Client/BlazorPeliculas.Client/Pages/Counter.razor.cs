using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorPeliculas.Client.Pages
{
	public partial class Counter
	{
		[Inject] ServiciosSingleton primerServicio { get; set; } = null!;
		[Inject] ServiciosTransient segundoServicio { get; set; } = null!;
		[Inject] IJSRuntime js { get; set; } = null!;

		IJSObjectReference modulo;

		private int currentCount = 0;
		private static int currentCountStatic = 0;

		[JSInvokable]
		public async Task IncrementCount()
		{
		

			currentCount++;
			currentCountStatic = currentCount;
			primerServicio.Valor = currentCount;
			segundoServicio.Valor = currentCount;

			await js.InvokeVoidAsync("pruebaPuntoNetStatic");
		}

		private async Task IncrementCountJavascript()
		{
			await js.InvokeVoidAsync("pruebaPuntoNetInstancia",
				DotNetObjectReference.Create(this));
		}

		 

		[JSInvokable]
		public static Task<int> ObtenerCurrentCount()
		{

			return Task.FromResult(currentCountStatic);
		}
	}
}
