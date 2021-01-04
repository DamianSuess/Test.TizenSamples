using Xamarin.Forms;

namespace TizenXamlApp1.Wearable
{
  internal class Program : global::Xamarin.Forms.Platform.Tizen.FormsApplication
  {
    protected override void OnCreate()
    {
      base.OnCreate();

      LoadApplication(new Client.App());
    }

    private static void Main(string[] args)
    {
      var app = new Program();
      Forms.Init(app);
      app.Run(args);
    }
  }
}
