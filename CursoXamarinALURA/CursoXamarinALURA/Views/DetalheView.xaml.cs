using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CursoXamarinALURA.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetalheView : ContentPage
    {
        public Veiculo Veiculo { get; set; }
        private const int FREIO_ABS = 800;
        private const int AR_CONDICIONADO = 1000;
        private const int MP3_PLAYER = 500;

        public string TextoFreioABS
        {
            get
            {
                return string.Format("Freio ABS - R$ {0}",FREIO_ABS);
            }
        }       
        public string TextoArCondicionado
        {
            get
            {
                return string.Format("ArCondicionado - R$ {0}",AR_CONDICIONADO);
            }
        }      
        public string TextoMP3Player
        {
            get
            {
                return string.Format("MP3 Plater - R$ {0}",MP3_PLAYER);
            }
        }

        public DetalheView(Veiculo veiculo)
        {
            InitializeComponent();
            this.Title = veiculo.Nome;
            this.Veiculo = veiculo;

            this.BindingContext = this;
        }

        private void buttonProximo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AgendamentoView(Veiculo));
        }
    }
}