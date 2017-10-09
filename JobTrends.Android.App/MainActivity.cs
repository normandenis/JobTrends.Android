using Android.App;
using Android.OS;

namespace JobTrends.Android.App
{
	[Activity(Label = "JobTrends.Android.App", MainLauncher = true)]
	public class MainActivity : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			this.SetContentView(Resource.Layout.Main);
		}
	}
}