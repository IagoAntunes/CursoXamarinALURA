using CursoXamarinALURA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CursoXamarinALURA.Views
{
 
    public partial class ListagemView : ContentPage
    {
        public ListagemView()
        {
            InitializeComponent();

        }
   

        protected override void OnAppearing()
        {
            base.OnAppearing();
            MessagingCenter.Subscribe<Veiculo>(this,"Veiculo Selecionado", (msg) => 
            {
                Navigation.PushAsync(new DetalheView(msg));


            });
        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            MessagingCenter.Unsubscribe<Veiculo>(this, "Veiculo Selecionado");
        }


    }
}
