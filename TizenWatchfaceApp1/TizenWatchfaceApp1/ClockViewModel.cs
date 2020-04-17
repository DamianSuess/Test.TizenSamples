using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TizenWatchfaceApp1
{
  public class ClockViewModel : INotifyPropertyChanged
  {
    private DateTime _time;

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

    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
