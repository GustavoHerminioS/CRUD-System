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

    public List<Produtos> Read()
        {
            List<Produtos> produtos = new List<Produtos>();

            string sql = "SELECT * FROM Produtos";
            var cn = new SqlConnection(ConexaoBanco.Connection);
            var cmd = new SqlCommand(sql, cn);

            cn.Open();
            
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Produtos produto = new Produtos();

                    produto.Id = (int)reader["Id"];
                    produto.Nome = reader["Nome"].ToString();
                    produto.Preco = Convert.ToDouble(reader["Preco"]);
                    produto.Estoque = (int)reader["Estoque"];

                    produtos.Add(produto);
                }
            }
            return produtos;
        }
    }
}
