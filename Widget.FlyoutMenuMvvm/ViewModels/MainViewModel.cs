using System.Windows.Input;

using Sample.Wizard.Mvvm;

using Xamarin.Forms;

namespace Sample.Wizard.ViewModels
{
  public class MainViewModel : BaseViewModel
  {
    public MainViewModel()
    {
      ClickDenyButtonCommand = new Command(() => ClickDenyButton());
      ClickConfirmButtonCommand = new Command(() => ClickConfirmButton());
    }

    public ICommand ClickDenyButtonCommand { get; private set; }
    public ICommand ClickConfirmButtonCommand { get; private set; }

    // Called when the deny circle button is clicked.
    private void ClickDenyButton()
    {
      // TODO: Insert code to handle the circle button click.
    }

    // Called when the confirm circle button is clicked.
    private void ClickConfirmButton()
    {
      // TODO: Insert code to handle the circle button click.
    }
  }
}
