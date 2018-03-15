using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Timers;

namespace MVVMLearning.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        System.Timers.Timer timer;

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; RaisPropertyChanged(() => Name); }
        }

        private string _time;

        public string Time
        {
            get { return _time; }
            set { _time = value;  RaisPropertyChanged(() => Time); }
        }


        public MainPageViewModel()
        {
            _name = "Pankaj Singh";

            timer = new System.Timers.Timer(); timer.Interval = 1000; timer.Elapsed += elapsed; timer.Enabled = true;

        }

        private void elapsed(object sender, ElapsedEventArgs e)
        {
            DateTime t = e.SignalTime;
            _time = t.ToLongTimeString();
            RaisPropertyChanged(() => Time);
        }
    }
}
