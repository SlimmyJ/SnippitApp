using System;
using System.Windows;
using System.Collections.Generic;

namespace SnippitApp
{
    /// <summary>
    /// Interaction logic for AddNewSnippit.xaml
    /// </summary>
    public partial class AddNewSnippit : Window
    {
        private string newSnipName;
        private string newSnipSummary;
        private string newSnipContent;
        public SnippitRepo _repo;
        public List<CodeSnippit> addNewSnippitList;

        public AddNewSnippit(List<CodeSnippit> codeSnippits)
        {
            InitializeComponent();
            codeSnippits = _repo.jasonbro.GetSnippitListFromJson();
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