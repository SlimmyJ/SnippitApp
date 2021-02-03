using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SnippitApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<string> Testlist;
        public List<CodeSnippit> SnippitList;
        public CodeSnippit displaySnippit;

        public MainWindow()
        {
            InitializeComponent();
            SnippitList = FillListWithSnippits();
            FillListBoxItems();
        }

        public void FillListBoxItems()
        {
            foreach (var item in SnippitList)
            {
                ListBoxOverView.Items.Add(item.ToString());
            }
        }

        private void ListBoxOverView_Selected(object sender, RoutedEventArgs e)
        {
            //string curItem = ListBoxOverView.SelectedItem.ToString();

            //btnTest.Content = curItem;
        }

        private void ListBoxOverView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string curItem = ListBoxOverView.SelectedItem.ToString();
        }

        private List<CodeSnippit> FillListWithSnippits()
        {
            List<CodeSnippit> snippitlistrepo = new List<CodeSnippit>();
            JsonWriter fuckingdoit = new JsonWriter();

            snippitlistrepo.Add(new CodeSnippit("ThisSnippit", "You", "Summary", "Content"));
            snippitlistrepo.Add(new CodeSnippit("ThisSnippit2", "You2", "Summary2", "Content2"));
            snippitlistrepo.Add(new CodeSnippit("ThisSnippit3", "You3", "Summary3", "Content3"));
            snippitlistrepo.Add(new CodeSnippit("ThisSnippit4", "You4", "Summary4", "Content4"));
            snippitlistrepo.Add(new CodeSnippit("ThisSnippit5", "You5", "Summary5", "Content5"));
            snippitlistrepo.Add(new CodeSnippit("ThisSnippit6", "You6", "Summary6", "Content6"));
            snippitlistrepo.Add(new CodeSnippit("ThisSnippit7", "You7", "Summary7", "Content7"));
            snippitlistrepo.Add(new CodeSnippit("ThisSnippit8", "You8", "Summary8", "Content8"));
            snippitlistrepo.Add(new CodeSnippit("ThisSnippit9", "You9", "Summary9", "Content9"));
            snippitlistrepo.Add(new CodeSnippit("ThisSnippit10", "You10", "Summary10", "Content10"));
            snippitlistrepo.Add(new CodeSnippit("ThisSnippit11", "You11", "Summary11", "Content11"));

            fuckingdoit.ToJson(snippitlistrepo);

            return snippitlistrepo;
        }
    }
}