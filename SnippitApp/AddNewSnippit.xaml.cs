using System;
using System.Collections.Generic;
using System.Windows;

namespace SnippitApp
{
    /// <summary>
    /// Interaction logic for AddNewSnippit.xaml
    /// </summary>
    public partial class AddNewSnippit : Window
    {
        public MainWindow Mainwindow;

        public AddNewSnippit(MainWindow window)
        {
            InitializeComponent();
            Mainwindow = window;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private CodeSnippit CreateNewSnippet()
        {
            CodeSnippit newSnippit = new CodeSnippit(txtName.Text, txtSummary.Text, txtContent.Text);
            return newSnippit;
        }

        private void ClickSaveButton(object sender, RoutedEventArgs e)
        {
            CodeSnippit codeSnippit = CreateNewSnippet();

            Mainwindow.SnippitHandler.AddToList(codeSnippit);

            //Mainwindow.ListBoxOverView.ItemsSource = null;
            //Mainwindow.ListBoxOverView.ItemsSource = Mainwindow.SnippitHandler.GetSnippitList();

            Mainwindow.ListBoxOverView.ItemsSource = Mainwindow.SnippitHandler.GetBindingSnippitList();

            Close();
        }
    }
}