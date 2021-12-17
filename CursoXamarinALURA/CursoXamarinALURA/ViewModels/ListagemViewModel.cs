﻿using CursoXamarinALURA.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CursoXamarinALURA.ViewModels
{
    public class ListagemViewModel
    {
        public List<Veiculo> Veiculos { get; set; }

        Veiculo veiculoSelecionado;
        public Veiculo VeiculoSelecionado 
        {
            get
            {
                return veiculoSelecionado;
            }
            set
            {
                veiculoSelecionado = value;
                if(value != null)
                    MessagingCenter.Send(veiculoSelecionado, "VeiculoSelecionado"); 
            }
        }
        public ListagemViewModel()
        {
            this.Veiculos = new ListagemVeiculos().Veiculos;
        }

    }
}
