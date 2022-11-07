using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;

namespace Exercise.ExerciseClass.DataBase
{
    internal class DataBaseConnect
    {
        public DataBaseConnect(string commandString)
        {
            this.commandString = commandString;

            try
            {
                DBAdapter = new OracleDataAdapter(this.commandString, connectionString);
                myCommandBuilder = new OracleCommandBuilder(DBAdapter);

                DS = new DataSet();
                DBAdapter.Fill(DS);

                Table = DS.Tables[0];
            }
            catch (DataException DE)
            {
                Console.WriteLine(DE.Message);
            }

        }

        private string connectionString = Properties.Resources.connectionString;
        private string commandString;

        // 추가, 수정, 삭제시에 필요한 명령문을
        // 자동으로 작성해주는 객체입니다.
        public OracleCommandBuilder myCommandBuilder;

        // Data Provider인 DBAdapter 입니다.
        public OracleDataAdapter DBAdapter;

        // ataTable 객체입니다.
        public DataTable Table;

        // DataSet 객체입니다.
        public DataSet DS;
    }
}
