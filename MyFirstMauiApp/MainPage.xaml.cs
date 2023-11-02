namespace MyFirstMauiApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count += 10;

            if (count == 1)
                CounterBtn.Text = $"I was clicked {count} time";
            else
                CounterBtn.Text = $"I was licked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }
}