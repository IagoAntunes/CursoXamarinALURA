using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CursoXamarinALURA
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            listViewVeiculos.ItemsSource = new string[]
            {
                "Azira V6",
                "Fiesta 2.0",
                "HB20 S"
            };



        }
    }
}