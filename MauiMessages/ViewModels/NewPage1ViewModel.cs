using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;

namespace MauiMessages.ViewModels
{
    public partial class NewPage1ViewModel : ObservableObject, IRecipient<MainPageViewModel>
    {
        [ObservableProperty]
        private bool isbusy;
        [ObservableProperty]
        public string message;

        public NewPage1ViewModel()
        {
           WeakReferenceMessenger.Default.Register(this);

        }
       
        [RelayCommand]
        void IsBusyCheck()
        {
            if (Message != null)
            {
                Isbusy = false;
            }
            else
            {
                Isbusy = true;
            }
        }

        [RelayCommand(CanExecute = nameof(Isbusy))]
        void ButtonClick(CancellationToken token)
        {       
        }

        public void Receive(MainPageViewModel message)
        {
            if (message != null)
            {
                Message = message.Latitude + " " + message.Longitude;
            }
        }
    }
}
