using CommunityToolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiMessages.ViewModels
{
    public partial class MainPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private double latitude = 28.8083;
        [ObservableProperty] 
        private double longitude = -8.7073; 
        public MainPageViewModel()
        {
            
        }
        /// <summary>
        /// 
        /// </summary>
        [RelayCommand]
        async void SendMessage()
        {
           await Shell.Current.GoToAsync(nameof(NewPage1));
            WeakReferenceMessenger.Default.Send<MainPageViewModel>();
        }
    }
}
