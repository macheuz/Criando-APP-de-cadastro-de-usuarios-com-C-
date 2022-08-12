using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace banco_de_dados
{
    class Banco
    {
        //criando variavel de conexao ao banco de dados
        private static SQLiteConnection conexao;

        //funcoes genericas
        public static DataTable dql(string sql) //Data Query Language
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                //para cada metodo vamos criar uma conexao propria
                var vcon = ConexaoBanco();
                //criando rotina
                var cmd = vcon.CreateCommand();
                //criando comando sql para pegar todos os usuarios
                cmd.CommandText = sql;
                //fazendo a consulta no banco passando o comando sql e a conexao no banco
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                //preenchendo o datatable com as informacoes
                da.Fill(dt);
                vcon.Close();
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void dml(string q, string msgOk = null, string msgERRO = null) //data Manipulation Language (Insert, Delete, Update)
        {
            //data adapter que fara nossa consulta no banco
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                //criando rotina
                var cmd = vcon.CreateCommand();
                //criando comando sql para pegar todos os usuarios
                cmd.CommandText = q;
                //fazendo a consulta no banco passando o comando sql e a conexao no banco
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();
                if(msgOk != null)
                {
                    MessageBox.Show(msgOk);
                }

            }
            catch (Exception ex)
            {
                if(msgERRO != null)
                {
                    MessageBox.Show(msgERRO + "\n" + ex.Message);
                }
                throw ex;
            }
        }

        //criando metodo para realizar a conexao com o banco
        //é estatico pois utilizaremos a partir de qualquer lugar do programa
        private static SQLiteConnection ConexaoBanco()
        {  
            //criando uma nova conexao ao banco de dados
            conexao = new SQLiteConnection(@"Data Source = C:\Users\macha\Desktop\Projetos Windows Form\Aula 60\Banco de dados\banco de dados\banco\banco_academia.db");
            // abrindo a conexao com o banco
            conexao.Open();
            return conexao;
        }
        //Esse metodo vai retornar um objeto do tipo datatable com todos os usuarios do sistema
        public static DataTable ObterTodosusuarios()
        {
            //data adapter que fara nossa consulta no banco
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                //criando rotina
                var cmd = vcon.CreateCommand();
             //criando comando sql para pegar todos os usuarios
             cmd.CommandText = "SELECT * FROM TB_USUARIOS";
             //fazendo a consulta no banco passando o comando sql e a conexao no banco
             da = new SQLiteDataAdapter(cmd.CommandText, vcon);
             //preenchendo o datatable com as informacoes
             da.Fill(dt);
             vcon.Close();
             return dt;
                
            }catch (Exception ex)
            {
                throw ex;
            }
        }
        //Criando método genérico para consulta
       

        //Funcoes do form F_gestao usuarios

        public static DataTable ObterUsuariosIdNome()     {
            //data adapter que fara nossa consulta no banco
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                //criando rotina
                var cmd = vcon.CreateCommand();
                //criando comando sql para pegar todos os usuarios
                cmd.CommandText = "SELECT N_IDUSUARIO as 'ID Usuario', T_NOMEUSUARIO as 'Nome Usuario' FROM TB_USUARIOS";
                //fazendo a consulta no banco passando o comando sql e a conexao no banco
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                //preenchendo o datatable com as informacoes
                da.Fill(dt);
                vcon.Close();
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public static DataTable ObterDadosUsuario(string id)
        {
            //data adapter que fara nossa consulta no banco
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                //criando rotina
                var cmd = vcon.CreateCommand();
                //criando comando sql para pegar todos os usuarios
                cmd.CommandText = "SELECT * FROM TB_USUARIOS where N_IDUSUARIO ="+id;
                //fazendo a consulta no banco passando o comando sql e a conexao no banco
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                //preenchendo o datatable com as informacoes
                da.Fill(dt);
                vcon.Close();
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void AtualizarUsuario(Usuario u)
        {
            //data adapter que fara nossa consulta no banco
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                //criando rotina
                var cmd = vcon.CreateCommand();
                //criando comando sql para pegar todos os usuarios
                cmd.CommandText = "UPDATE tb_usuarios SET T_NOMEUSUARIO = '"+u.nome+"', T_USERNAME='"+u.username+"', T_SENHAUSUARIO= '"+u.senha+"', T_STATUSUSUARIO = '"+u.status+"', N_NIVELUSUARIO ="+u.nivel+" WHERE N_IDUSUARIO ="+u.id;
                //fazendo a consulta no banco passando o comando sql e a conexao no banco
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void DeletarUsuario(string id)
        {
            //data adapter que fara nossa consulta no banco
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                //criando rotina
                var cmd = vcon.CreateCommand();
                //criando comando sql para pegar todos os usuarios
                cmd.CommandText = "DELETE FROM tb_usuarios WHERE N_IDUSUARIO =" + id;
                //fazendo a consulta no banco passando o comando sql e a conexao no banco
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        //fim das funcoes do form F_gestao Usuarios

        /// funçoes do form f_novousuario

        public static void NovoUsuario(Usuario u)
        {
            if (existeUsername(u))
            {
                MessageBox.Show("Username ja existe");
                return;
            }
            try
            {
                var vcon = ConexaoBanco();
                //adicionando novo usuario ao banco
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "INSERT INTO tb_usuarios (T_NOMEUSUARIO, T_USERNAME, T_SENHAUSUARIO, T_STATUSUSUARIO, N_NIVELUSUARIO) VALUES (@nome, @username, @senha, @status, @nivel )";
                //adicionando os valores dos parametros
                cmd.Parameters.AddWithValue("@nome", u.nome);
                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@senha", u.senha);
                cmd.Parameters.AddWithValue("@status", u.status);
                cmd.Parameters.AddWithValue("@nivel", u.nivel);
                //executando a query
                cmd.ExecuteNonQuery();
                MessageBox.Show("Novo usuario inserido");
                vcon.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gravar novo usuario");
            }
        }
        
        /// fim das funcoes
        /// rotinas gerais
        /// verificando se ja existe usuario
        public static bool existeUsername(Usuario u)
        {
            bool res;
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            var vcon = ConexaoBanco();
            var cmd = vcon.CreateCommand();
            cmd.CommandText ="SELECT T_USERNAME FROM tb_usuarios WHERE T_USERNAME ='"+u.username+"'";
            //passando a query e a conexao para o banco
            da = new SQLiteDataAdapter(cmd.CommandText, vcon);
            //preenchendo o data table com as informacoes do data adapter
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                res = true;
            }
            else
            {
                res=false;
            }
            vcon.Close();
            return res;
        } 
        
        ///fim das rotinas gerais 

    }
}
