using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yoshi.Properties
{
    internal class conn
    {
        public class AcessoMysql
        {//metodo pra abrir a conexao com o banco de dados   (detalhe: sempre ta abrindo e fechando a con)
            public static MySqlConnection AbrirCon()
            {
                return new MySqlConnection("server = localhost; database = yoshi; uid = root; pwd = ; port = 3306");
            }
        }
    }
}
