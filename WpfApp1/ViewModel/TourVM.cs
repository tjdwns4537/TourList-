using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Xml;
using TourApp.Classes;
using TourApp.Command;
using TourApp.View;



namespace TourApp.ViewModel
{
    public class TourVM
    {
        StartWindow startwindow = new StartWindow();
        Frame frame;
        TourApi api = new TourApi();
        List<TourLIstDATA> tourlist = new List<TourLIstDATA>();
        string ADDRESS;
        string TITLE;
        string FIRSTIMAGE;
        string SECONDIMAGE;
        public static List<String> imageStore = new List<string>();

        public DoCommand doCommand { get; set; }

        public TourVM()
        {
            doCommand = new DoCommand(this);
            frame = (Frame)Application.Current.MainWindow.FindName("PageFrame");
        }
        public StartWindow xmlReader(int areaCode)
        {
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreComments = true;
            settings.IgnoreWhitespace = true;
            ListView listview = new ListView();
            Image image = new Image();
            using (XmlReader reader = XmlReader.Create(@api.GetTourData_xml(areaCode), settings))
            {
                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        switch (reader.Name.ToString())
                        {
                            case "addr1":
                                ADDRESS = reader.ReadString();
                                break;
                            case "title":
                                TITLE = reader.ReadString();
                                tourlist.Add(new TourLIstDATA() { addrData = ADDRESS, titleData = TITLE, firstimageData = FIRSTIMAGE, secondimageData = SECONDIMAGE });
                                imageStore.Add(FIRSTIMAGE);
                                break;
                            case "firstimage":
                                FIRSTIMAGE = reader.ReadString();
                                break;
                            case "firstimage2":
                                SECONDIMAGE = reader.ReadString();
                                break;
                        }
                        startwindow.Main_tourListView.ItemsSource = tourlist;

                    }
                }
            }
            return startwindow;
        }

        public static List<string> ImageReturn()
        {
            return imageStore;
        }
    }
}

//startwindow.Show();
//return tourlist;
/*
 *                         // 리스트를 어떻게 뽑아낼지를 생각해보자
//((StartWindow)System.Windows.Application.Current.StartWindow).Main_tourListView.ItemsSource = tourlist;

//Console.WriteLine(typeof(((MainWindow) System.Windows.Application.Current.MainWindow));
//StartWindow bb = StartWindow.Main_tourListView.ItemsSource = tourlist;
foreach( Window window in Application.Current.Windows)
{
    Console.WriteLine(window.Title);
}
                        //startwindow_page.Main_tourListView.ItemSource = tourlist;
//Swindow = StartWindow.Main_tourListView
//public static List<TourLIstDATA>  Lwindow  = StartWindow.Main_tourListView;
//startwindow.Main_tourListView.ItemsSource = tourlist;
//((MainWindow)Application.Current.MainWindow).Main_tourListView.ItemsSource = tourlist;
//((StartWindow)System.Windows.Application.Current.MainWindow).Main_tourListView.ItemsSource = tourlist;
*/

/*
public int currentPage { get; set; }
List<string> PageNames;
        Page startwindow_page = new Page();

public TourData tourDataShow { get; set; }
public ObservableCollection<string> Cities { get; set; }
private string selectedCity;
public string SelectedCity
{
    get { return selectedCity; }
    set { selectedCity = value; GetWheather(); }
}
public void NavigateTo(string a)
{
    Uri uri = new Uri(a, UriKind.Relative);
    frame.NavigationService.Navigate(uri);
}
public void GetWheather()
{
    if (SelectedCity != null)
    {
        Console.WriteLine("!!!!!!!!!!!!!!!!!"+TourApi.GetTourData(SelectedCity).Name);
        var tour = TourApi.GetTourData(SelectedCity);
        tourDataShow.Name = tour.Name;
    }
    // xml 로 복원할것
}

 */