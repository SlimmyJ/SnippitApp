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
        private string newSnipName;
        private string newSnipSummary;
        private string newSnipContent;
        public SnippitRepo _repo;
        public List<CodeSnippit> addNewSnippitList;

        public AddNewSnippit(List<CodeSnippit> codeSnippits, SnippitRepo snippitRepo)
        {
            InitializeComponent();
            _repo = snippitRepo;
            addNewSnippitList = codeSnippits;
        }

        public event EventHandler SaveButtonClicked;

        protected virtual void OnSaveButtonClicked(RoutedEventArgs e)
        {
            SaveButtonClicked?.Invoke(this, e);
            addNewSnippitList = _repo.SnippitListRepo;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            SaveFields();
            var snippit = CreateNewSnippet();
            addNewSnippitList.Add(snippit);
            _repo.Jasonsis.ToJson(addNewSnippitList);
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