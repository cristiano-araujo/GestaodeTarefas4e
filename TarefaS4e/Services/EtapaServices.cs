using GestaodeTarefas4e.DAO;
using GestaoTarefas4e.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TarefaS4e.Models;

namespace GestaodeTarefas4e.DAO
{
    public class EtapaDAO
    {
        public void Insert(Etapa etapa)
        {
            try
            {
                string sql = $"INSERT INTO Etapa (Id, Descricao, DataInicio, DataConclusao, Recebimento, Andamento, Concluida) VALUES ('{etapa.Id}', '{etapa.Descricao}','{etapa.DataInicio}', '{etapa.DataConclusao}', '{etapa.Recebimento}', '{etapa.Andamento}', '{etapa.Concluido}')";
                Conexao conexao = new Conexao();
                conexao.ExecuteReader(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Update(Etapa etapa)
        {
            try
            {
                string sql = $"UPDATE Etapa SET Id = '{etapa.Id}', Descricao = '{etapa.Descricao}', DataInicio = '{etapa.DataInicio}'. DataConclusao = '{etapa.DataConclusao}', Recebimento = '{etapa.Recebimento}', Andamento = '{etapa.Andamento}', Concluida = '{etapa.Concluido}' WHERE Id = '{etapa.Id}'";
                Conexao conexao = new Conexao();
                conexao.ExecuteReader(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Rear(int id)
        {
            try
            {
                string sql = $"SELECT * FROM Etapa WHERE Id = '{id}'";
                Conexao conexao = new Conexao();
                conexao.ExecuteReader(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(int id)
        {
            try
            {
                string sql = $"DELETE FROM Etapa WHERE Id = '{id}'";
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