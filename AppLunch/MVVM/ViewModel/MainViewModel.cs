using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppLunch.Core;
using AppLunch.MVVM.View;

namespace AppLunch.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {

        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand DiscoveryViewCommand { get; set; }



        public HomeViewModel HomeVM { get; set; }
        public DiscoveryView DiscoveryView { get; set; }

        public object _currentView;


        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropretyChanged();
            }
        }




        public MainViewModel() 
        { 
            HomeVM = new HomeViewModel();
            DiscoveryView = new DiscoveryView();

            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM;
            });

            DiscoveryViewCommand = new RelayCommand(o =>
            {
                CurrentView = DiscoveryView;
            });
        }

    }
}
