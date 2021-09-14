using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteLogFile
{
    class WriteLog
    {
        public static void writeFileLog(string m)
        {
            DirectoryInfo di = new DirectoryInfo("History");
            if (di.Exists == false) //exe파일과 같은 경로에 History 폴더가 없을 때 호출
                di.Create();

            using (StreamWriter w = new StreamWriter("History\\Log.txt", true) )
            {
                string msg = DateTime.Now.ToString("[yyyy/MM/dd hh:mm:ss.fff]") + m;
                w.WriteLine(msg);
            }
        }
    }
}
