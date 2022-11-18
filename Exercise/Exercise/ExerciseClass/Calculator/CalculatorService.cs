using Exercise.ExerciseClass.DataBase;
using Exercise.Froms.SubForm;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Media;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise.ExerciseClass.Calculator
{
    internal class CalculatorService
    {
        private String input;
        private String name;
        private int index;



        public CalculatorService(String input)
        {
            this.input = input;
        }

        public CalculatorService(String name, String input, int index)
        {
            this.name = name; //운동이름
            this.input = input; // 시간입력
            this.index = index; // 운동 / 음식 체크박스
        }


        public void sendMessage(string str)
        {
            MessageForm message = new MessageForm(str);
            message.StartPosition = FormStartPosition.CenterParent;
            SystemSounds.Beep.Play();
            message.ShowDialog();
        }


        public bool confirmNull()
        {
            if (input != "") { return true; }
            return false;
        }

        public bool confirmNumber()
        {
            Regex regexnumber = new Regex(@"[0-9]");
            Boolean ismatch = regexnumber.IsMatch(input);

            if (!ismatch)
            {
                return false;
            }
            return true;
        }

        public void save()
        {
            if (index == 0)
            {
                DataBaseConnect dbconn = new DataBaseConnect("select * from user_exercise");
                DataRow newRow = dbconn.Table.NewRow();
                //newRow["user_id"] = id;
                //newRow["id"] = id;
                newRow["exercise"] = name;
                newRow["time"] = input;
                newRow["date"] = DateTime.Now.ToString();

                dbconn.Table.Rows.Add(newRow);
                dbconn.DBAdapter.Update(dbconn.DS);
            }
            else if (index == 1)
            {
                DataBaseConnect dbconn = new DataBaseConnect("select * from user_food");
                DataRow newRow = dbconn.Table.NewRow();
                //newRow["user_id"] = id;
                //newRow["id"] = id;
                newRow["exercise"] = name;
                newRow["time"] = input;
                newRow["date"] = DateTime.Now.ToString();

                dbconn.Table.Rows.Add(newRow);
                dbconn.DBAdapter.Update(dbconn.DS);
            }
        }
    }
}
