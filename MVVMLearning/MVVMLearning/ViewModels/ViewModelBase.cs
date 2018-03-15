using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MVVMLearning.ViewModels
{
    public class ViewModelBase : ExtendedBindableObject
    {
        public INavigation Navigation { get; set; }

        private bool _isBusy;
        public bool IsBusy
        {
            get { return _isBusy; }
            set
            {
                _isBusy = value;
                RaisPropertyChanged(() => IsBusy);
            }
        }

    }
}
