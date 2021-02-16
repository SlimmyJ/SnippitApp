using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace SnippitApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SnippitRepo _repo;
        private List<CodeSnippit> SnippitList;
        public CodeSnippit displaySnippit;

        public MainWindow()
        {
            InitializeComponent();
            _repo = SnippitRepo.GetSnippetRepo();
            SnippitList = _repo.GetSnippits();
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
        private void ListBoxOverView_SelectionChanged(object sender, SelectionChangedEventArgs e) 
        {
            if(ListBoxOverView.SelectedIndex != -1)
            {
                displaySnippit = _repo.GetSnippit(ListBoxOverView.SelectedIndex);

                if (displaySnippit != null)
                {
                    MainSnipWindow.Text = displaySnippit.SnipContent;
                }
            }        
        }        

        private void MenuItemNew_Click(object sender, RoutedEventArgs e)
        {
            AddNewSnippit newWindow = new AddNewSnippit();
            newWindow.Owner = this;
            newWindow.SaveButtonClicked += UpdateListBox;
            newWindow.Show();
        }

        private void MenuItemDelete_Click(object sender, RoutedEventArgs e)
        {
            if (displaySnippit != null)
            {
                //_repo.RemoveSnippitFromRepo(displaySnippit);
                _repo.RemoveSnippitFromRepo(ListBoxOverView.SelectedIndex);
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
        
        private void MenuItemStyle1_Click(object sender, RoutedEventArgs e)
        {
            Style st1 = FindResource("Style1") as Style;
            MainSnipWindow.Style = st1;
        }
        private void MenuItemStyle2_Click(object sender, RoutedEventArgs e)
        {
            Style st2 = FindResource("Style2") as Style;
            MainSnipWindow.Style = st2;
        }
        private void MenuItemStyle3_Click(object sender, RoutedEventArgs e)
        {
            Style st3 = FindResource("Style3") as Style;
            MainSnipWindow.Style = st3;
        }

        //private void btnTest_Click(object sender, RoutedEventArgs e)
        //{
        //    Style st = FindResource("Style1") as Style;
        //    Style st2 = FindResource("Style2") as Style;
        //    if (MainSnipWindow.Style == st2)
        //    {
        //        MainSnipWindow.Style = st;
        //    }
        //    else
        //    {
        //        MainSnipWindow.Style = st2;
        //    }            
        //}
    }
}