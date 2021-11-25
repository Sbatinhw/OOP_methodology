using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGgameLibrary
{
    public class Log
    {
        private List<string> logList = new List<string>();

        public void AddLog(string message)
        {
            logList.Add($"[{DateTime.Now}] {message}");
        }

        public string[] SendLog()
        {
            List<string> result = logList;
            logList = new List<string>();
            return result.ToArray();
        }
    }
}
