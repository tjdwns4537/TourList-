using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Navigation;
using TourApp.Classes;
using TourApp.View;
using TourApp.ViewModel;

namespace TourApp.Command
{
    public class DoCommand : ICommand
    {
        StartWindow startwindow = new StartWindow();

        //public TourData tourData = new TourData();
        public TourVM tourVM { get; set; }

        public DoCommand(TourVM vm)
        {
            tourVM = vm;
        }

        public event EventHandler CanExecuteChanged;
        
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            string directinon = (string)parameter;
            StartWindow start;
            if (directinon == "Start")
            {
                Console.WriteLine("스타트클릭");
                start = tourVM.xmlReader(1);
                start.Show();
                ((MainWindow)Application.Current.MainWindow).Close();
            }
        }
    }
}
