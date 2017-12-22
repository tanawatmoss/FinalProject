using Xamarin.Forms;

namespace hydroponicsenvironmentmanagement
{
    public partial class hydroponicsenvironmentmanagementPage : ContentPage
    {
        public hydroponicsenvironmentmanagementPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new settings());
        }
    }
}
