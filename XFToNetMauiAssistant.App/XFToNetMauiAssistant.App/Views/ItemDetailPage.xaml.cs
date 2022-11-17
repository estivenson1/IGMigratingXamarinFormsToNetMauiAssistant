using System.ComponentModel;
using Xamarin.Forms;
using XFToNetMauiAssistant.App.ViewModels;

namespace XFToNetMauiAssistant.App.Views
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