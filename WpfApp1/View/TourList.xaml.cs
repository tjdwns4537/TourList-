
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Xml;
using TourAPI.ViewModel;
using WpfApp1.Classes;

namespace WpfApp1
{
    public partial class TourList : Page
    {
        /*
        string ADDRESS;
        string TITLE;
        string FIRSTIMAGE;
        string SECONDIMAGE;
        string imageurl = "";

        int flag1 = 0;
        int flag2 = 0;
        int flag3 = 0;

        List<TourLIstDATA> tourlist = null;

        public ObservableCollection<CheckState> CheckStateList = new ObservableCollection<CheckState>();

        public TourList()
        {
            InitializeComponent();

            tourlist = new List<TourLIstDATA>();

            DoChecked();

            xmlReader();

        }

        public void xmlReader()
        {
            tourapi api = new tourapi();

            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreComments = true;
            settings.IgnoreWhitespace = true;

            using (XmlReader reader = XmlReader.Create(@api.GetTourURLData(flag1, flag2, flag3),settings))
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
                                tourlist.Add(new TourLIstDATA() { addrData = ADDRESS, titleData = TITLE});
                                break;
                            case "firstimage":
                                FIRSTIMAGE = reader.ReadString();
                                break;
                            case "firstimage2":
                                SECONDIMAGE = reader.ReadString();
                                break;
                        }                        
                        //tourListView.ItemsSource = tourlist;
                    }
                }
            }
            flag1 = 0;
            flag2 = 0;
            flag3 = 0;
        }

        public void DoChecked()
        {
            foreach (var num in CheckStateList)
            {
                if (num.Name == "SEOUL" && num.State == true)
                {
                    flag1 = 12;
                    flag2 = 1;
                    flag3 = 1;
                } 
                else if (num.Name == "BUSAN" && num.State == true)
                {
                    flag1 = 12;
                    flag2 = 6;
                    flag3 = 16;
                }
            }
        }

        private void tourListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //Uri resourceUri1 = new Uri(@FIRSTIMAGE, UriKind.Absolute);
            //imgDynamic1.Source = new BitmapImage(resourceUri1);

            //Uri resourceUri2 = new Uri(@SECONDIMAGE, UriKind.Absolute);
            //imgDynamic2.Source = new BitmapImage(resourceUri2);
        }

        public string getImageUri()
        {
            if (TITLE == "동백공원")
            {
                imageurl = FIRSTIMAGE;
            }
            return imageurl;
        }
        */
    }
}
