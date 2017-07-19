using Infragistics.Data;
using Xamarin.Forms;

namespace PrismUnityApp1.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            DataGrid1.ItemsSource = SampleSalesPerson.GenerateSalesData(100);
            DataGrid1.AutoGenerateColumns = true;
        }
    }
}
