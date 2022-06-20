using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using System.Xml;
using TourAPI.ViewModel;
using WpfApp1.Classes;

namespace WpfApp1.View
{
    public partial class CheckPage : Page
    {
        CheckStateData checkstatedata = new CheckStateData();

        public ObservableCollection<CheckState> CheckStateCollection
        {
            get
            {
                return checkstatedata.CheckStateList;
            }
        }

        tourapi api = new tourapi();
        public CheckPage()
        {
            InitializeComponent();
            //this.DataContext = this;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Uri uri = new Uri("/View/TourList.xaml", UriKind.Relative);
            //NavigationService.Navigate(uri);
        }

        /*
        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (SEOUL_CHECKBOX.IsChecked == true)
            {
                Console.Write("출력: "+checkstatedata.CheckStateList);
                checkstatedata.CheckStateChange("SEOUL",true);
            } 
        }
        */
    }
}
