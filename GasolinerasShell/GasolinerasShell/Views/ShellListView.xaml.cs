using GasolinerasShell.Viewmodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GasolinerasShell.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShellListView : ContentPage
    {
        public ShellListView()
        {
            InitializeComponent();
            BindingContext = new ShellListViewmodel();
        }

       
    }
}