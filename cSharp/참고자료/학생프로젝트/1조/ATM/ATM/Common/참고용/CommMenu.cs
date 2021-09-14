using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM.Common
{
    class CommMenu
    {
        public const int OLD_MODEL = 0;
        public const int NEW_MODEL = 1;
        public static void ErrMsg(string path , string msg)
        {
            string str = string.Format("[{0}]:{1}", path, msg);
            Console.WriteLine(str);
        }
        //delegate 사용자 정의 메세지
        public static void colorListViewHeader(ref ListView list, Color backColor,Color foreColor)
        {
            list.OwnerDraw = true;
            list.DrawColumnHeader += new DrawListViewColumnHeaderEventHandler((sender, e) => headerDraw(sender, e, backColor, foreColor));
            list.DrawItem += new DrawListViewItemEventHandler(bodyDraw);
        }
        private static void headerDraw(object sender, DrawListViewColumnHeaderEventArgs e,Color backColor, Color foreColor)
        {
            using (SolidBrush backBrush = new SolidBrush(backColor))
            {
                e.Graphics.FillRectangle(backBrush, e.Bounds);
            }
            using(SolidBrush foreBrush = new SolidBrush(foreColor))
            {
                e.Graphics.DrawString(e.Header.Text, e.Font, foreBrush, e.Bounds);
            }
        }
        private static void bodyDraw(object sender,DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }
    }
}
