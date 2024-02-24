using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TarefaS4e.Models
{
    public class Etapa
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string DataInicio { get; set; }
        public bool Recebimento { get; set; } = true;
        public bool Andamento { get; set; }
        public bool Concluido { get; set; }
        public string DataConclusao { get; set; }
    }
}