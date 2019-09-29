using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Tarea7MAD.ViewModels
{
    public class FirstSamplesPageViewModel:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ICommand IsClickedCommand { get; set; }
        public bool IsMagic { get; set; }
        

        

        public FirstSamplesPageViewModel()
        {
            IsMagic = false;
            IsClickedCommand = new Command(async () =>
            {
                IsMagic = false;
            });
        }

    }

}
