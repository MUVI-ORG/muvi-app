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
            var searchTerm = e.NewTextValue;

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                searchTerm = string.Empty;
            }

            searchTerm = searchTerm.ToLowerInvariant();

            var filteredItems = sourceItems.Where(value => value.ToLowerInvariant().Contains(searchTerm)).ToList();

            foreach (var value in sourceItems)
            {
                if (!filteredItems.Contains(value))
                {
                    MyItems.Remove(value);
                }
                else if (!MyItems.Contains(value))
                {
                    MyItems.Add(value);
                }
            }
        }
    }
}