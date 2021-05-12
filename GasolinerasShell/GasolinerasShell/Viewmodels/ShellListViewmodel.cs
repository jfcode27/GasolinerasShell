using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using GasolinerasShell.Models;
using GasolinerasShell.Views;
using GasolinerasShell.Data;

namespace GasolinerasShell.Viewmodels
{
    public class ShellListViewmodel : BaseViewmodel
    {
        static ShellListViewmodel instance;

        Command newStationCommand;
        public Command NewStationCommand => newStationCommand ?? (newStationCommand = new Command(NewStationAction));

        List<ShellModel> stations;
        public List<ShellModel> Stations
        {
            get => stations;
            set => SetProperty(ref stations, value);
        }

        ShellModel stationSelected;
        public ShellModel StationSelected
        {
            get => stationSelected;
            set
            {
                if (SetProperty(ref stationSelected, value))
                {
                    SelectStationAction();
                }
            }
        }

        public ShellListViewmodel()
        {
            instance = this;

            LoadTasks();
        }

        public static ShellListViewmodel GetInstance()
        {
            if (instance == null) instance = new ShellListViewmodel();
            return instance;
        }

        public async void LoadTasks()
        {
            Stations = await App.SQLiteDatabase.GetAllStationsAsync();
        }

        private void NewStationAction(object obj)
        {
            throw new NotImplementedException();
        }


        private void SelectStationAction()
        {
            Application.Current.MainPage.Navigation.PushAsync(new ShellDetailView(StationSelected));
        }
    }
}
