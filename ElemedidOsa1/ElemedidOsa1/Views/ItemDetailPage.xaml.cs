using System.ComponentModel;
using Xamarin.Forms;
using ElemedidOsa1.ViewModels;

namespace ElemedidOsa1.Views
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