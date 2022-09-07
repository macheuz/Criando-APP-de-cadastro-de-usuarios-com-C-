using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banco_de_dados
{
     class Globais
    {
        public static string versao = "1.0";
        public static Boolean logado = false;
        public static int nivel = 0;
        //variavel para pegar o caminho de onde esta o executavel da aplicacao
        //public static string caminho = System.Environment.CurrentDirectory;
        public static string caminho = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
        public static string nomeBanco = "banco_academia.db";
        //pegando o caminho do banco
        public static string caminhoBanco = caminho + @"\banco\";
        public static string caminhoFotos = caminho + @"\Foto\";
    }
}
