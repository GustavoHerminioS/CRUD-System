using CRUD.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD.BancoDeDados
{
    public class ProdutoBanco
    {
        public void Create(Produtos produtos)
        {
            string sql = "INSERT INTO Produtos (Nome, Preço, Estoque) VALUES (@Nome, @Preço, @Estoque)";
            var cn = new SqlConnection(ConexaoBanco.Connection);
            var cmd = new SqlCommand (sql, cn);

            cmd.Parameters.AddWithValue("@Nome", produtos.Nome);
            cmd.Parameters.AddWithValue("@Preço", produtos.Preco);
            cmd.Parameters.AddWithValue("@Estoque", produtos.Estoque);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
