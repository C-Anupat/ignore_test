using dumbbell_app.MVVM.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dumbbell_app.MVVM.model
{
    class MainViewModel : ObservableObject
    {
        public RelayCommand TrainingMenuCommand { get; set; }

        public RelayCommand TableViewCommand { get; set; }

        private object _currentView;
        public TrainingMenuViewModel TrainingMenuVM { get; set; }
        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }
        public MainViewModel()
        {
            // Declare object for assign to current view
            TrainingMenuVM = new TrainingMenuViewModel();
            
            CurrentView = TrainingMenuVM;

            // Display training menu when push button
            TrainingMenuCommand = new RelayCommand(o =>
            {
                CurrentView = TrainingMenuVM;
            });
        }
    }
}
