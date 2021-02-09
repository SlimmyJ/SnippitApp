using SnippitApp.Snippits;
using System.Windows;

namespace SnippitApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public SnippitHandler SnippitHandler;

        public MainWindow()
        {
            InitializeComponent();
            SnippitHandler = SnippitHandler.GetSnippitHandler();
            ListBoxOverView.ItemsSource = SnippitHandler.GetBindingSnippitList();
        }

        private void MenuItemNew_ClickNew(object sender, RoutedEventArgs e)
        {
            Window window = new AddNewSnippit(this);
            window.Show();
        }

        private void MenuItem_ClickDelete(object sender, RoutedEventArgs e)
        {
            SnippitHandler.DeleteFromList(SnippitHandler.GetSnippitFromList(ListBoxOverView.SelectedIndex));
        }

        private void GetFromRepo(object sender, RoutedEventArgs e)
        {
            ListBoxOverView.ItemsSource = SnippitHandler.GetBindingSnippitList();
        }

        private void SaveToRepo(object sender, RoutedEventArgs e)
        {
            SnippitHandler.WriteToFile(SnippitHandler.GetSnippitList());
        }

        private void MenuItem_ClickEdit(object sender, RoutedEventArgs e)
        {
            CodeSnippit snippit = SnippitHandler.GetSnippitFromList(ListBoxOverView.SelectedIndex);
            snippit.author = "09:02:2021/1219";
            SnippitHandler.UpdateSnippit(snippit);
        }

        private void OpenTestDesigner(object sender, RoutedEventArgs e)
        {
            Window designWindow = new DesignWindow(this);
            designWindow.Show();
        }
    }
}