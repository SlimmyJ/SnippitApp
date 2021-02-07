using System.Windows;
using System.Windows.Controls;

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
            ListBoxOverView.ItemsSource = SnippitHandler.GetBindingSnippitList();
            ListViewXaml.ItemsSource = SnippitHandler.GetBindingSnippitList();
            this.Resources["listingDataView"] = SnippitHandler.GetBindingSnippitList();
        }

        private void MenuItemNew_Click(object sender, RoutedEventArgs e)
        {
            Window newpage = new AddNewSnippit(this);
            newpage.Show();
            //MainWindowFrame.NavigationService.Navigate(new AddNewSnippitPage(SnippitList, _repo));
        }

        private void MenuItemDelete_Click(object sender, RoutedEventArgs e)
        {
            SnippitHandler.DeleteFromList(SnippitHandler.GetSnippîtFromList(ListBoxOverView.SelectedIndex));
        }

        private void GetFromRepo(object sender, RoutedEventArgs e)
        {
            ListBoxOverView.ItemsSource = SnippitHandler.GetBindingSnippitList();
            this.Resources["listingDataView"] = SnippitHandler.GetBindingSnippitList();
        }

        private void SaveToRepo(object sender, RoutedEventArgs e)
        {
            SnippitHandler.WriteToFile(SnippitHandler.GetSnippitList());
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)       
        {
            
            CodeSnippit snippit = SnippitHandler.GetSnippîtFromList(ListBoxOverView.SelectedIndex);
            snippit.author = "7/02/2021 21:13:55";
            SnippitHandler.UpdateSnippit(snippit);
        }
    }
}