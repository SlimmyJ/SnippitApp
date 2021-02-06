using System.Windows;

namespace SnippitApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public SnippitHandler SnippitHandler;
        public CodeSnippit displaySnippit;

        public MainWindow()
        {
            InitializeComponent();
            SnippitHandler = SnippitHandler.GetSnippitHandler();
            ListBoxOverView.ItemsSource = SnippitHandler.GetSnippitList();
        }

        private void MenuItemNew_Click(object sender, RoutedEventArgs e)
        {
            Window newpage = new AddNewSnippit(this);
            newpage.Show();
            //MainWindowFrame.NavigationService.Navigate(new AddNewSnippitPage(SnippitList, _repo));
        }

        private void MenuItemDelete_Click(object sender, RoutedEventArgs e)
        {
            if (displaySnippit != null)
            {
                //_repo.RemoveSnippitFromRepo(displaySnippit);
                //_repo.RemoveSnippitFromRepo(ListBoxOverView.SelectedIndex);

                //MainSnipWindow.ClearValue();
            }
        }

        private void GetFromRepo(object sender, RoutedEventArgs e)
        {
            ListBoxOverView.ItemsSource = SnippitHandler.GetSnippitList();
            Application.Current.Resources["AppCodeSnippit"] = SnippitHandler.GetSnippitList();
        }

        private void SaveToRepo(object sender, RoutedEventArgs e)
        {
        }
    }
}