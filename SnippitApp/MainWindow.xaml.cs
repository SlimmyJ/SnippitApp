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
            ListBoxOverView.ItemsSource = SnippitList;
            _repo = new SnippitRepo();
            SnippitList = new List<CodeSnippit>();
            FillListBoxItems();
        }

        public void FillListBoxItems()
        {
            foreach (CodeSnippit item in SnippitList)
            {
                ListBoxOverView.Items.Add(item.ToString());
            }
        }

        //display text

        private void MenuItemNew_Click(object sender, RoutedEventArgs e)
        {
            AddNewSnippit newWindow = new AddNewSnippit(SnippitList, _repo)
            {
                Owner = this
            };
            newWindow.SaveButtonClicked += UpdateListBox;
            newWindow.Show();
        }

        private void MenuItemDelete_Click(object sender, RoutedEventArgs e)
        {
            if (displaySnippit != null)
            {
                //_repo.RemoveSnippitFromRepo(displaySnippit);
                //_repo.RemoveSnippitFromRepo(ListBoxOverView.SelectedIndex);
                UpdateListBox();
                //MainSnipWindow.ClearValue();
            }
        }

        private void UpdateListBox(object sender, EventArgs e)
        {
            ListBoxOverView.Items.Clear();
            FillListBoxItems();
        }

        //non event versie (reverse overload?) om in deze klasse te kunnen gebruiken
        private void UpdateListBox()
        {
            ListBoxOverView.Items.Clear();
            FillListBoxItems();
        }

        private void GetFromRepo(object sender, RoutedEventArgs e)
        {
            SnippitList = _repo.Jasonbro.GetSnippitListFromJson();
            UpdateListBox();
        }

        private void SaveToRepo(object sender, RoutedEventArgs e)
        {
            JsonWriter jsonbro = new JsonWriter();
            jsonbro.ToJson(SnippitList);
            JsonReader jsonbro2 = new JsonReader();
            SnippitList = jsonbro2.GetSnippitListFromJson();

            UpdateListBox();
        }
    }
}