using Owny_app.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Owny_app.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}