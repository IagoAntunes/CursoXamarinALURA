using System;
using System.Collections.Generic;
using System.Text;

namespace CursoXamarinALURA.Models
{
    public class Agendamento
    {
        public Agendamento agendamento { get; set; }
        public Veiculo Veiculo { get; set; }
        public string Nome { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        DateTime dataAgendamento = DateTime.Today;
        public DateTime DataAgendamento
        {
            get
            {
                return dataAgendamento;
            }
            set
            {
                dataAgendamento = value;
            }
        }
        public TimeSpan HoraAgendamento { get; set; }


    }
}
