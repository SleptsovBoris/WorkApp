using System;
using System.Windows.Input;
using Xamarin.Forms;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using WorkApp.Pages;

namespace WorkApp.ViewModels
{
    public class Page1ViewModel:INotifyPropertyChanged
    {
        private int _number = 147;

        public int Number 
        { 
            get => _number; 
            set 
            { 
                _number = value;
                OnPropertyChanged();
            } 
        }

        public async Task ChangeNumber()
        {
            await Task.Delay(1000);
            int random = new Random().Next(100);
            Number = random;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public ICommand LabelCommand => new Command(async value => 
        {
            await ChangeNumber();
        });
        
        public ICommand command => new Command(async value => 
        {
            await Application.Current.MainPage.Navigation.PushAsync(new Page2());
        });
    }
}