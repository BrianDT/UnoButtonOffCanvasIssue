
namespace UnoButtonOffCanvasIssue
{
    using Microsoft.UI.Xaml;
    using Microsoft.UI.Xaml.Controls;
    using UnoButtonOffCanvasIssue.ViewModels;

    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            this.Loaded += (s, e) =>
            {
                this.VM.ShowControl();
            };

            this.DataContext = new MainViewModel();
        }

        public MainViewModel VM => this.DataContext as MainViewModel;

        private void Container_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            this.VM.SetContainerSize(e.NewSize.Width , e.NewSize.Height);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.VM.DoAction();
        }
    }
}