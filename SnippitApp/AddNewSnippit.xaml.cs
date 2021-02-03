using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SnippitApp
{
    /// <summary>
    /// Interaction logic for AddNewSnippit.xaml
    /// </summary>
    public partial class AddNewSnippit : Window
    {
        private SnippitRepo _repo;
        string newSnipName;
        string newSnipSummary;
        string newSnipContent;
        public AddNewSnippit()
        {
            InitializeComponent();
            _repo = SnippitRepo.GetSnippetRepo();
        }

        public event EventHandler SaveButtonClicked;

        protected virtual void OnSaveButtonClicked(RoutedEventArgs e)
        {
            SaveButtonClicked?.Invoke(this, e);
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            SaveFields();
            var snippit = CreateNewSnippet();
            _repo.AddSnippitToRepo(snippit);
            OnSaveButtonClicked(e);
            Close();
        }

        private CodeSnippit CreateNewSnippet()
        {
            CodeSnippit newSnippit = new CodeSnippit(newSnipName, newSnipSummary, newSnipContent);

            return newSnippit;
        }

        private void SaveFields()
        {
            newSnipName = txtName.Text;
            newSnipSummary = txtSummary.Text;
            newSnipContent = txtContent.Text;
        }
    }
}
