using GestaoTarefas4e.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using TarefaS4e.Models;

namespace GestaoTarefaS4e.Services
{
    public class TarefaServices
    {

        public List<Tarefa> GetTarefas()
        {
            List<Tarefa> Tarefas = new List<Tarefa>();

            try
            {
                string sql = $"SELECT * FROM Tarefa";
                Conexao conexao = new Conexao();
                DataView dataView = conexao.Excute(sql);

                foreach (DataRowView row in dataView)
                {
                    Tarefa tarefa = new Tarefa
                    {
                        Titulo = row["Titulo"].ToString(),
                        Descricao = row["Descricao"].ToString(),
                        DataInicio = (row["DataInicio"].ToString())
                    };
                    Tarefas.Add(tarefa);
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Tarefas;
        }

    }

}