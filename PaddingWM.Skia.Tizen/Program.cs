using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace PaddingWM.Skia.Tizen
{
	public sealed class Program
	{
		static void Main(string[] args)
		{
			var host = new TizenHost(() => new PaddingWM.App());
			host.Run();
		}
	}
}
