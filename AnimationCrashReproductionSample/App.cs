using Xamarin.Forms;

namespace AnimationCrashReproductionSample
{
	public class App : Application
	{
		public App() => MainPage = new SpinButtonPage();
	}

	class SpinButtonPage : ContentPage
	{
		public SpinButtonPage()
		{
			Content = new SpinButton
			{
				BackgroundColor = Color.Black,
                TextColor = Color.White,
                Text = "Quickly Double Tap This Button",
				HeightRequest = 200,
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center
			};
		}
	}
}
