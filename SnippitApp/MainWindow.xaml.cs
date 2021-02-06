using System;
using System.Collections.Generic;
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
            SnippitHandler.CreateSnippitList();
            ListBoxOverView.ItemsSource = SnippitHandler.GetSnippitList();
        }

        //display text

        private void MenuItemNew_Click(object sender, RoutedEventArgs e)
        {
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