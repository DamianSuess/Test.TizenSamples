using Tizen.Applications;
using Tizen.Wearable.CircularUI.Forms.Renderer.Watchface;
using Xamarin.Forms;

namespace TizenWatchfaceApp1
{
  class Program : FormsWatchface
  {
    ClockViewModel _viewModel;

    protected override void OnCreate()
    {
      base.OnCreate();

      // ElmSharp.Utility.AppendGlobalFontPath(DirectoryInfo.Resource);
      var watchfaceApp = new TextWatchApplication();

      _viewModel = new ClockViewModel();
      watchfaceApp.BindingContext = _viewModel;

      SetTimeTickFrequency(1, TimeTickResolution.TimeTicksPerSecond);
      LoadWatchface(watchfaceApp);
    }

    /// <summary>Inform WatchFace ViewModel to update the clock</summary>
    /// <param name="time"></param>
    protected override void OnTick(TimeEventArgs time)
    {
      base.OnTick(time);
      if (_viewModel != null)
      {
        _viewModel.Time = time.Time.UtcTimestamp;
        _viewModel.Date = time.Time.UtcTimestamp.ToString("MMM dd").ToUpper();
      }
    }

    protected override void OnAmbientChanged(AmbientEventArgs mode)
    {
      base.OnAmbientChanged(mode);
    }

    protected override void OnAmbientTick(TimeEventArgs time)
    {
      base.OnAmbientTick(time);
    }

    static void Main(string[] args)
    {
      var app = new Program();
      Forms.Init(app);
      global::Tizen.Wearable.CircularUI.Forms.Renderer.FormsCircularUI.Init();
      app.Run(args);
    }
  }
}
