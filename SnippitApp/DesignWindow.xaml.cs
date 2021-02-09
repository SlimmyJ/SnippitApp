using SnippitApp.Snippits;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace SnippitApp
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>

    public partial class DesignWindow : Window
    {
        public MainWindow Mainwindow;
        public object SelectedItem { get; set; }
        public List<CodeSnippit> listofsnippetswindow;

        public DesignWindow(MainWindow window)
        {
            Mainwindow = window;
            InitializeComponent();

            ListView_DesignWindow.ItemsSource = Mainwindow.SnippitHandler.GetSnippitList();
            TxtBox_CodeBlockXaml.DataContext = Mainwindow.SnippitHandler.GetSnippitList();
        }

        private void ListView_DesignWindow_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectedItem = ListView_DesignWindow.SelectedItem;

            CodeSnippit designersnipper = SelectedItem as CodeSnippit;
            TxtBox_CodeBlockXaml.Text = designersnipper.content;
        }
    }
}