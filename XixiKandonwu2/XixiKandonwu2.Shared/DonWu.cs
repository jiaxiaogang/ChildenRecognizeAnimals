using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace XixiKandonwu2
{
    public class DonWu : INotifyPropertyChanged
    {
        private string _jiao;
        private string _jiaoName;

        public string JiaoName
        {
            get { return _jiaoName; }
            set { _jiaoName = value; }
        }
        public string Jiao
        {
            get { return _jiao; }
            set { _jiao = value; }
        }
        private void FirePropertyChanged(string prop)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
        private string name;
        private string imgPath;

        public string ImgPath
        {
            get { return imgPath; }
            set
            {
                imgPath = value;
                FirePropertyChanged("ImgPath");
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                FirePropertyChanged("Name");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
