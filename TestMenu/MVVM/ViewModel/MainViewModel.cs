using System;
using System.Collections.Generic;
using System.Text;
using TestMenu.core;

namespace TestMenu.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public RelayCommand VentasViewCommand { get; set; }
        public RelayCommand ModernViewCommand { get; set; }
        public VentasViewModel ventasVM { get; set; }
        public ModernViewModel modernVM { get; set; }

        private object _currectView;

        public object CurrentView
        {
            get { return _currectView; }
            set 
            { 
                _currectView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            ventasVM = new VentasViewModel();
            modernVM = new ModernViewModel();
            
            //cargar la pagina inicial
            CurrentView = ventasVM;


            VentasViewCommand = new RelayCommand((o) => 
            {
                CurrentView = ventasVM;
            }
            );


            ModernViewCommand = new RelayCommand((o) =>
            {
                CurrentView = modernVM;
            }
            );
        }
    }
}
