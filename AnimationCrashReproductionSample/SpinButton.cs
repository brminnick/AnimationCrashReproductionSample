using Xamarin.Forms;

namespace AnimationCrashReproductionSample
{
	public class SpinButton : Button
	{
		public SpinButton() => Clicked += HandleClicked;

		async void HandleClicked(object sender, System.EventArgs e)
		{
			await this.RotateTo(539, 1000, Easing.CubicOut);
			await this.RotateTo(0, 1000, Easing.CubicIn);
		}
	}
}
