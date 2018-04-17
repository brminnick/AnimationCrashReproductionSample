using Xamarin.Forms;

namespace AnimationCrashReproductionSample
{
	public class App : Application
	{
		public App() => MainPage = new NavigationPage(new SpinButtonPage());
	}

	class SpinButtonPage : ContentPage
	{
		public SpinButtonPage() => Content = new SpinButton { Text = "Quickly Double Tap This Button" };
	}
}
