namespace Project5
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnMenuClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("///MenuPage");
        }

        private async void OnDirectionClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("///DirectionPage");
        }
    }
}
