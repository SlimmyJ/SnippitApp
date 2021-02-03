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
            //SnippitList = FillListWithSnippits();
            FillListBoxItems();
        }

        public void FillListBoxItems()
        {
            foreach (CodeSnippit item in SnippitList)
            {
                ListBoxOverView.Items.Add(item.ToString());
            }
        }

        private void ListBoxOverView_SelectionChanged(object sender, SelectionChangedEventArgs e) //display text
        {
            var index = ListBoxOverView.SelectedIndex +1 ;

            MainSnipWindow.Text = _repo.GetSnippit(index).SnipContent;

            //MainSnipWindow.Text = GetSnippitCONTENTOnId(index);
        }

        //private List<CodeSnippit> FillListWithSnippits()
        //{
        //    List<CodeSnippit> snippitlistrepo = new List<CodeSnippit>();
        //    JsonWriter fuckingdoit = new JsonWriter();

        //    snippitlistrepo.Add(new CodeSnippit("ThisSnippit", "You", "Summary", "Content"));
        //    snippitlistrepo.Add(new CodeSnippit("ThisSnippit2", "You2", "Summary2", "Content2"));
        //    snippitlistrepo.Add(new CodeSnippit("ThisSnippit3", "You3", "Summary3", "Content3"));
        //    snippitlistrepo.Add(new CodeSnippit("ThisSnippit4", "You4", "Summary4", "Content4"));
        //    snippitlistrepo.Add(new CodeSnippit("ThisSnippit5", "You5", "Summary5", "Content5"));
        //    snippitlistrepo.Add(new CodeSnippit("ThisSnippit6", "You6", "Summary6", "Content6"));
        //    snippitlistrepo.Add(new CodeSnippit("ThisSnippit7", "You7", "Summary7", "Content7"));
        //    snippitlistrepo.Add(new CodeSnippit("ThisSnippit8", "You8", "Summary8", "Content8"));
        //    snippitlistrepo.Add(new CodeSnippit("ThisSnippit9", "You9", "Summary9", "Content9"));
        //    snippitlistrepo.Add(new CodeSnippit("ThisSnippit10", "You10", "Summary10", "Content10"));
        //    snippitlistrepo.Add(new CodeSnippit("ThisSnippit11", "You11", "Summary11", "Content11"));

        //    fuckingdoit.ToJson(snippitlistrepo);

        //    return snippitlistrepo;
        //}

        //private string GetSnippitCONTENTOnId(int id)
        //{
        //    string snippit = "";
        //    foreach (var item in SnippitList)
        //    {
        //        if (item.SnipID == id)
        //        {
        //            snippit = item.SnipContent;
        //            break;
        //        }                
        //    }
        //    return snippit;
        //}

        private void MenuItemNew_Click(object sender, RoutedEventArgs e)
        {
            AddNewSnippit newWindow = new AddNewSnippit();
            newWindow.Owner = this;
            newWindow.SaveButtonClicked += UpdateListBox;
            newWindow.Show();
        }

        private void UpdateListBox(object sender, EventArgs e)
        {
            ListBoxOverView.Items.Clear();
            FillListBoxItems();
        }


    }
}