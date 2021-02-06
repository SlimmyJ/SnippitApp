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
        public SnippitRepo _repo;
        public List<CodeSnippit> SnippitList;
        public CodeSnippit displaySnippit;

        public MainWindow()
        {
            InitializeComponent();
            _repo = new SnippitRepo();
            _repo.SnippitListRepo = SnippitList;
            ListBoxOverView.ItemsSource = SnippitList;
        }

        //display text

        private void MenuItemNew_Click(object sender, RoutedEventArgs e)
        {
            AddNewSnippit newWindow = new AddNewSnippit(SnippitList, _repo)
            {
                Owner = this
            };
            newWindow.Show();
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
            SnippitList = _repo.Jasonbro.GetSnippitListFromJson();
            ListBoxOverView.ItemsSource = SnippitList;
        }

        private void SaveToRepo(object sender, RoutedEventArgs e)
        {
            JsonWriter jsonbro = new JsonWriter();
            jsonbro.ToJson(SnippitList);
            JsonReader jsonbro2 = new JsonReader();
            SnippitList = jsonbro2.GetSnippitListFromJson();
        }
    }
}