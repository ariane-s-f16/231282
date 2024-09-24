using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _231282
{
    public class banco
    {

        public static MySqlConnection Conexao;
        public static MySqlCommand Comando;
        public static MySqlDataAdapter Adaptador;
        public static DataTable databela;

        public static void abrirconexao() 
        {

            try 
            {
                Conexao = new MySqlConnection("server=localhost; port=3307; uid=root; pwd=etecjau");

                Conexao.Open();
            }
            catch (Exception e) 
            {
                MessageBox.Show(e.Message, "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }
        public static void fecharconexao ()
        {
            try
            {
                Conexao.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message,"erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void abrirbanco() 
        {
            try
            {
                abrirconexao();
                Comando = new MySqlCommand("CREATE DATABASE IF NOT EXISTS vendas; USE vendas", Conexao);
                Comando.ExecuteNonQuery();

                Comando= new MySqlCommand("CREATE TABLE IF NOT EXISTS CIDADES" +"(id integer auto_increment primary key,"+ " nome varchar (35)," + "uf char (82))", Conexao);
                Comando.ExecuteNonQuery() ;


                fecharconexao();
            }
            catch(Exception e) 
            {
                MessageBox.Show(e.Message, "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
            

        }



    }
}
