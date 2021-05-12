using GasolinerasShell.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GasolinerasShell.Viewmodels
{
    public class ShellDetailViewModel : BaseViewmodel
    {
        public ShellDetailViewModel()
        {
            StationSelected = new ShellModel();
        }

        public ShellDetailViewModel(ShellModel selected)
        {
            StationSelected = selected;
        }


        ShellModel stationSelected;
        public ShellModel StationSelected
        {
            get => stationSelected;
            set => SetProperty(ref stationSelected, value);
        }


    }
}
