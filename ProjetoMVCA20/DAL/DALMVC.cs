﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Data;

namespace ProjetoMVCA20.DAL
{
    class DALMVC
    {
        private MySqlConnection conexao;
        private string string_conexao = "persist security info = false;" + "server=localhost;" + "database=ProjetoMVCA20;" + "user=root;" + "pwd=juliana032805;";


        public void Conectar()
        {
            try
            {
                conexao = new MySqlConnection(string_conexao);
                conexao.Open();
            }
            catch (MySqlException e)
            {
                throw new Exception("Problemas na conexão com o Banco de Dados. Erro: " + e.Message);
            }
        }

        public void ExecutarComando(string sql)
        {
            try
            {
                Conectar();
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                comando.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                throw new Exception("Não foi possivel executar a instrução no Banco. Erro: " + e.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        public DataTable ConsultarDadosTabela(string sql)
        {
            Conectar();
            DataTable dt = new DataTable();
            MySqlDataAdapter consulta = new MySqlDataAdapter(sql, conexao);
            consulta.Fill(dt);
            consulta.Dispose();
            conexao.Close();
            return dt;
        }

    }
}