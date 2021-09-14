using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice1
{
    static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //if(DialogResult.Yes == MessageBox.Show("당신은 윈도우 사용자입니까?", "Window or Mac", MessageBoxButtons.YesNo))
            //{
            //    Application.Run(new WindowsForm());
            //}
            //else
            //{
            //    Application.Run(new MacForm());
            //}
            Application.Run(new OsChoiceForm());
        }
    }
}
