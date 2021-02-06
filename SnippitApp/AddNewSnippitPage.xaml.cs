using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace SnippitApp
{
    /// <summary>
    /// Interaction logic for AddNewSnippitPage.xaml
    /// </summary>
    public partial class AddNewSnippitPage : Page

    {
        private string newSnipName;
        private string newSnipSummary;
        private string newSnipContent;
        public SnippitHandler _repo;
        public List<CodeSnippit> addNewSnippitList;

        public AddNewSnippitPage(List<CodeSnippit> codeSnippits, SnippitHandler snippitRepo)
        {
            InitializeComponent();
            _repo = snippitRepo;
            addNewSnippitList = codeSnippits;
        }

        public event EventHandler SaveButtonClicked;

        protected virtual void OnSaveButtonClicked(RoutedEventArgs e)
        {
            // SaveButtonClicked?.Invoke(this, e); addNewSnippitList = _repo.SnippitListRepo;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            SaveFields();
            var snippit = CreateNewSnippet();
            addNewSnippitList.Add(snippit);
            //_repo.Jasonsis.ToJson(addNewSnippitList);
            OnSaveButtonClicked(e);
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