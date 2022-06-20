using System;
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
using System.Windows.Controls;
using System.Windows.Shapes;
using TourApp.ViewModel;
using System.Windows.Media.Imaging;

namespace TourApp.View
{
    /// <summary>
    /// StartWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class StartWindow : Window
    {
        public StartWindow()
        {
            InitializeComponent();
        }
        
        private void List_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            TourVM vam = new TourVM();
            Image image = new Image();
            List<string> ImageReturn = TourVM.ImageReturn();
            int cnt = Main_tourListView.SelectedIndex;

            imgDynamic1.Source = new BitmapImage(new Uri(ImageReturn[cnt], UriKind.RelativeOrAbsolute));
        }

    }
}
