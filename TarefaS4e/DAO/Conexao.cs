using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace GestaoTarefas4e.DAO
{
    public class Conexao
    {
        public DataView Excute(string sql)
        {
            string conexao = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            SqlConnection connection = new SqlConnection(conexao);
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            try
            {
                connection.Open();
                dataAdapter.Fill(dataSet);
                return dataSet.Tables[0].DefaultView;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        public SqlDataReader ExecuteReader(string sql)
        {
            string conexao = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            SqlConnection connection = new SqlConnection(conexao);
            SqlCommand command = new SqlCommand(sql, connection);
            try
            {
                connection.Open();
                return command.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}