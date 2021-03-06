using System;
using Tizen.Applications;
using Tizen.Wearable.CircularUI.Forms.Renderer.Watchface;

namespace WatchFaceXamMonkey
{
    class Program : FormsWatchface
    {
        WatchViewModel _viewModel;

        protected override void OnCreate()
        {
            base.OnCreate();
            ElmSharp.Utility.AppendGlobalFontPath(DirectoryInfo.Resource);
            var watchfaceApp = new App();
            _viewModel = new WatchViewModel(watchfaceApp.WatchView);
            watchfaceApp.BindingContext = _viewModel;
            SetTimeTickFrequency(1, TimeTickResolution.TimeTicksPerMinute);
            LoadWatchface(watchfaceApp);
        }

        protected override void OnTick(TimeEventArgs time)
        {
            base.OnTick(time);
            if (_viewModel != null)
            {
                DateTime currentTime = time.Time.UtcTimestamp;
                _viewModel.Date = currentTime.ToString("MMM dd").ToUpper();
                _viewModel.Time = currentTime.ToString("HH:mm");
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
            global::Xamarin.Forms.Platform.Tizen.Forms.Init(app);
            global::Tizen.Wearable.CircularUI.Forms.Renderer.FormsCircularUI.Init();
            app.Run(args);
        }
    }
}
