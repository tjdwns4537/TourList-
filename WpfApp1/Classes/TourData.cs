using System;
using System.Collections.Generic;
using System.ComponentModel;
/*
namespace TourApp.Classes
{
    
    public class Header
    {
        public string resultCode;
        public string ResultCode
        {
            get { return resultCode; }
            set { resultCode = value; OnPropertyChanged("ResultCode"); }
        }

        public string resultMsg;
        public string ResultMsg
        {
            get { return resultMsg; }
            set { resultMsg = value; OnPropertyChanged("ResultMsg"); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }
    }
    public class Item
    {
        public int code;
        public int Code
        {
            get { return code; }
            set { code = value; OnPropertyChanged("Code"); }
        }

        public string name;
        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged("Name"); }
        }

        public int rnum { get; set; }
        public int Rnum
        {
            get { return rnum; }
            set { rnum = value; OnPropertyChanged("Rnum"); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }
    }
    public class Items
    {
        public IList<Item> item;
        public IList<Item> Item
        {
            get { return item; }
            set { item = value; OnPropertyChanged("Item"); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }
    }
    public class Body : INotifyPropertyChanged
    {
        public Items items;
        public Items Items
        {
            get { return items; }
            set { items = value; OnPropertyChanged("Items"); }
        }
        public int numOfRows;
        public int NumOfRows
        {
            get { return numOfRows; }
            set { numOfRows = value; OnPropertyChanged("NumOfRows"); }
        }
        public int pageNo;
        public int PageNo
        {
            get { return pageNo; }
            set { pageNo = value; OnPropertyChanged("PageNo"); }
        }
        public int totalCount;
        public int TotalCount
        {
            get { return totalCount; }
            set { totalCount = value; OnPropertyChanged("TotalCount"); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }
    }
    public class Response : INotifyPropertyChanged
    {
        public Header header;
        public Header Header
        {
            get { return header; }
            set { header = value; OnPropertyChanged("Header"); }
        }

        public Body body;
        public Body Body
        {
            get { return body; }
            set { body = value; OnPropertyChanged("Body"); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }
    }

    public class Example : INotifyPropertyChanged
    {
        public Response response;
        public Response Response
        {
            get { return response; }
            set { response = value; OnPropertyChanged("Response"); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }
    }
    public class TourData : INotifyPropertyChanged
    {
        private Response response;
        public Response Response
        {
            get { return response; }
            set { response = value; OnPropertyChanged("Response"); }
        }

        public string name;
        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged("Name"); }
        }

       //public Response response { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }
    }
}
    */
/*
        Reponse 값이 세팅이 되면 값이 바뀔 것이고
        바뀐함수를 호출해주는 것
        정확히 얘기하면 이벤트 델리게이트를 호출해주는 것

        다른 부분에도 해줘야함
*/