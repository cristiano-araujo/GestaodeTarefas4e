using GestaodeTarefas4e.DAO;
using GestaoTarefas4e.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TarefaS4e.Models;

namespace GestaodeTarefas4e.DAO
{
    public class TarefaDAO
    {
        public void Insert(Tarefa tarefa)
        {

            try
            {
                string sql = $"INSERT INTO Tarefa (Titulo, Descricao, DataInicio) VALUES ('{tarefa.Titulo}','{tarefa.Descricao}', '{tarefa.DataInicio}')";
                Conexao conexao = new Conexao();
                conexao.ExecuteReader(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Update(Tarefa tarefa)
        {
            try
            {
                string sql = $"UPDATE Tarefa SET Titulo = '{tarefa.Titulo}', Descricao = '{tarefa.Descricao}', DataInicio = '{tarefa.DataInicio}' WHERE Titulo = '{tarefa.Titulo}'";
                Conexao conexao = new Conexao();
                conexao.ExecuteReader(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Read(string Titulo)
        {
            try
            {
                string sql = $"SELECT * FROM Tarefa WHERE Titulo = '{Titulo}'";
                Conexao conexao = new Conexao();
                conexao.ExecuteReader(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(string Nome)
        {
            try
            {
                string sql = $"DELETE FROM Tarefa WHERE Nome = '{Nome}'";
                Conexao conexao = new Conexao();
                conexao.ExecuteReader(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}