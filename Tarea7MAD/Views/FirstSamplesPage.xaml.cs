using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Tarea7MAD.ViewModels;

namespace Tarea7MAD.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FirstSamplesPage : ContentPage
    {
        public FirstSamplesPage()
        {
            InitializeComponent();
            BindingContext = new FirstSamplesPageViewModel();
        }

        private void Entry_Focused(object sender, FocusEventArgs e)
        {

        }
    }
}