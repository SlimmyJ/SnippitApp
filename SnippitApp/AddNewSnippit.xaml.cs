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
        public SnippitHandler SnippitHandler;

        public AddNewSnippit()
        {
            InitializeComponent();
            SnippitHandler = SnippitHandler.GetSnippitHandler();
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
            SnippitHandler.AddToList(codeSnippit);
            SnippitHandler.WriteToFile(SnippitHandler.GetSnippitList());
            Close();
        }
    }
}