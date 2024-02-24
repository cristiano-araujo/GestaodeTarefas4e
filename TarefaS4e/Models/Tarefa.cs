using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TarefaS4e.Models
{
    public class Tarefa
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public string Descricao { get; set; }

        public string DataInicio { get; set; }

        public string DataConclusao { get; set; } 
    }
}