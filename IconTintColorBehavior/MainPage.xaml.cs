namespace IconTintColorBehavior
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            itemCollection.ItemsSource = new List<string>() { "Test String" };
        }
    }

}
