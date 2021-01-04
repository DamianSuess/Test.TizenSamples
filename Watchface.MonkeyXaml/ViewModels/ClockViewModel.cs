using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace TizenWatchfaceApp1
{
  public class ClockViewModel : INotifyPropertyChanged
  {
    private string _date;
    private DateTime _time;

    public ClockViewModel()
    {
      CmdFacePressed = new Command(OnFacePressed);
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public ICommand CmdFacePressed { get; private set; }

    public string Date
    {
      get => _date;
      set
      {
        if (_date == value)
          return;
        _date = value;
        OnPropertyChanged();
      }
    }

    public DateTime Time
    {
      get => _time;
      set
      {
        if (_time == value)
          return;

        _time = value;
        OnPropertyChanged();
      }
    }

    protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    private void OnFacePressed()
    {
      Date = "TEST";
    }
  }
}
