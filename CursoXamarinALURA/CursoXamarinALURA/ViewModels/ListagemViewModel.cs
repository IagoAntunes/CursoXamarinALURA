﻿using CursoXamarinALURA.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoXamarinALURA.ViewModels
{
    public class ListagemViewModel
    {
        public List<Veiculo> Veiculos { get; set; }

        public ListagemViewModel()
        {
            this.Veiculos = new ListagemVeiculos().Veiculos;
        }



    }
}
