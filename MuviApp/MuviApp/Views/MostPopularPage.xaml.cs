using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MuviApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MostPopularPage : ContentPage
    {
        public MostPopularPage()
        {
            InitializeComponent();
        }

        private void SearchBarTextChanged(object sender, TextChangedEventArgs e)
        {
            Console.WriteLine("Changing");
        }
    }
}