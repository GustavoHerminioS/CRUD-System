using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD.BancoDeDados
{
    public static class ConexaoBanco
    {
        public static string Connection
        {
            get
            {
                return @"Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CRUD;Integrated Security=True;Encrypt=True";
            }
        }
    }
}
