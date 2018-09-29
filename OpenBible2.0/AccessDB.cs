using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenBible2._0
{
    class AccessDB
    {
        public bool _DEBUG_MODE = false;
        private OleDbConnection conexao;
        private static string conStr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=OpenBible2.0.mdb";

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ConnectionState status()
        {
            return conexao.State;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public OleDbConnection getConexao()
        {
            conexao = new OleDbConnection(conStr);

            if (conexao.State == ConnectionState.Closed)
            {
                try
                {
                    conexao.Open();
                }
                catch (OleDbException oEx)
                {
                    if (_DEBUG_MODE)
                    {
                        MessageBox.Show(oEx.Message.ToString(), "Atenção:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Application.Exit();
                }
            }

            return conexao;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public bool query(string sql)
        {
            OleDbCommand cmd = new OleDbCommand(sql, this.getConexao());

            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public DataTable getDados(string sql)
        {
            OleDbDataAdapter myDa = new OleDbDataAdapter(sql, this.getConexao());
            DataTable myDt = new DataTable();

            try
            {
                myDa.Fill(myDt);
            }
            catch (Exception e)
            {
                if (_DEBUG_MODE)
                {
                    MessageBox.Show(e.Message, new Form1().Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            return myDt;
        }
    }
}
