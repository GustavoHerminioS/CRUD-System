using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD.Models
{
    public sealed class Produtos
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Estoque { get; set; }
    }
}
