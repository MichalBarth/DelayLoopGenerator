using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CycleCounter.ViewModels
{
    class MainViewModel : INotifyPropertyChanged
    {
        private int _cykly;
        private int _cas;
        private readonly string[] textyENG = { "1. Decide wether to input:", "Cycles:", "time/cycle rate:", "time/sec:", "CycleRate", "Click the GO Button", "GO button", "Save source code", "Copy/Paste:" };
        public RelayCommand ToCZ { get; set; }
        public int Cykly { get => _cykly; set { _cykly = value; NotifyPropertyChanged(); } }
        public int Cas { get => _cas; set { _cas = value; NotifyPropertyChanged(); } }
        public ParametrizedRelayCommand Play { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
