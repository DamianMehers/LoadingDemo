using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LoadingDemo.Shared {
  public class ViewModel : INotifyPropertyChanged {
    private bool _loading;

    public ViewModel() {
      // When you click the button run the Start method.  The command is available
      // when not loading
      StartCommand = new Command(Start, () => !Loading);
    }

    private async void Start() {
      Loading = true;
      await Task.Delay(TimeSpan.FromSeconds(5));
      Loading = false;
    }

    public bool Loading {
      get {
        return _loading;
      }
      private set {
        _loading = value;
        OnPropertyChanged();
        StartCommand.ChangeCanExecute();
      }
    }

    public Command StartCommand { get; }

    public event PropertyChangedEventHandler PropertyChanged;
    private void OnPropertyChanged([CallerMemberName] string propertyName = null) {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
  }
}