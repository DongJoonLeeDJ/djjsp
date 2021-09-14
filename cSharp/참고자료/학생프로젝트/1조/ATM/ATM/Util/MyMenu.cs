using ATM.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Util
{
    class Menu
    {
        #region 메뉴 상수 정의

        public const int MENU_MAIN_RAND = 1;
        public const int MENU_MAIN_DEL_ALL = 2;
        public const int MENU_MAIN_VIEW = 3;
        public const int MENU_MAIN_ADD = 4;
        public const int MENU_MAIN_DEL = 5;
        public const int MENU_MAIN_UPDATE = 6;
        public const int MENU_MAIN_EXIT = 7;
        public const int CAR_MENU = 1;
        public const int CUS_MENU = 2;
        public const int SEL_MENU = 3;

        public const int MENU_SUB_ADD_CAR = 1;
        public const int MENU_SUB_ADD_CUST = 2;
        public const int MENU_SUB_ADD_SELL = 3;
        public const int MENU_SUB_ADD_EXIT = 4;


        public const int MENU_SUB_DEL_CAR = 1;
        public const int MENU_SUB_DEL_CUST = 2;
        public const int MENU_SUB_DEL_SELL = 3;
        public const int MENU_SUB_DEL_EXIT = 4;

        public const int MENU_SUB_UPD_CAR = 1;
        public const int MENU_SUB_UPD_CUST = 2;
        public const int MENU_SUB_UPD_SELL = 3;
        public const int MENU_SUB_UPD_EXIT = 4;

        public const int MENU_SUB_VIEW_CAR = 1;
        public const int MENU_SUB_VIEW_CUST = 2;
        public const int MENU_SUB_VIEW_SELL = 3;
        public const int MENU_SUB_VIEW_EXIT = 4;
        #endregion

        //TODO 각각 메뉴 분리해야함
        public int MainMenu()
        {
            int menu=0;
            try
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("메인 메뉴 v1.0");
                Console.WriteLine("-----------------------");
                Console.WriteLine("1.랜덤데이터 생성");
                Console.WriteLine("2.모든 데이터 삭제");
                Console.WriteLine("3.데이터 보기");
                Console.WriteLine("4.데이터 추가");
                Console.WriteLine("5.데이터 삭제");
                Console.WriteLine("6.데이터 수정");
                Console.WriteLine("7.앱 종료");
                Console.WriteLine("-----------------------");
                Console.Write("메뉴 선택: ");

                menu= Convert.ToInt32(Console.ReadLine());
            }
            catch(FormatException e)
            {
                CommMenu.ErrMsg("mainMenu", e.Message);
            }
            return menu;


        }
        public int CarMainMenu()
        {

            int menu = 0;
            try
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("고객 차량 관리 앱 v1.0");
                Console.WriteLine("-----------------------");
                Console.WriteLine("1.랜덤데이터 생성");
                Console.WriteLine("2.모든 데이터 삭제");
                Console.WriteLine("3.데이터 보기");
                Console.WriteLine("4.데이터 추가");
                Console.WriteLine("5.데이터 삭제");
                Console.WriteLine("6.데이터 수정");
                Console.WriteLine("7.앱 종료");
                Console.WriteLine("-----------------------");
                Console.Write("메뉴 선택: ");

                menu = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException e)
            {
                CommMenu.ErrMsg("CarMainMenu", e.Message);
            }
            return menu;

        }
        public int CustMainMenu()
        {
            int menu = 0;
            try
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("고객 관리 앱 v1.0");
                Console.WriteLine("-----------------------");
                Console.WriteLine("1.랜덤데이터 생성");
                Console.WriteLine("2.모든 데이터 삭제");
                Console.WriteLine("3.데이터 보기");
                Console.WriteLine("4.데이터 추가");
                Console.WriteLine("5.데이터 삭제");
                Console.WriteLine("6.데이터 수정");
                Console.WriteLine("7.앱 종료");
                Console.WriteLine("-----------------------");
                Console.Write("메뉴 선택: ");

                menu = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException e)
            {
                CommMenu.ErrMsg("CustMainMenu", e.Message);

            }
            return menu;
        }

        public int SelMainMenu()
        {
            int menu = 0;
            try
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("판매자 관리 앱 v1.0");
                Console.WriteLine("-----------------------");
                Console.WriteLine("1.랜덤데이터 생성");
                Console.WriteLine("2.모든 데이터 삭제");
                Console.WriteLine("3.데이터 보기");
                Console.WriteLine("4.데이터 추가");
                Console.WriteLine("5.데이터 삭제");
                Console.WriteLine("6.데이터 수정");
                Console.WriteLine("7.앱 종료");
                Console.WriteLine("-----------------------");
                Console.Write("메뉴 선택: ");

                menu = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException e)
            {
                CommMenu.ErrMsg("SelMainMenu", e.Message);

            }
            return menu;
        }

        public int subAddMenu()
        {
            int menu = 0;
            try
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("데이터 추가 선택");
                Console.WriteLine("1.차량 정보 추가");
                Console.WriteLine("2.고객 정보 추가");
                Console.WriteLine("3.판매자 정보 추가");
                Console.WriteLine("4.종료");
                Console.WriteLine("-----------------------");
                Console.Write("메뉴 선택: ");

                menu = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException e)
            {
                CommMenu.ErrMsg("subAddMenu", e.Message);

            }
            return menu;
        }

        public int subDelMenu()
        {
            int menu = 0;
            try
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("데이터 삭제 선택");
                Console.WriteLine("1.차량 정보 삭제");
                Console.WriteLine("2.고객 정보 삭제");
                Console.WriteLine("3.판매자 정보 삭제");
                Console.WriteLine("4.종료");
                Console.WriteLine("-----------------------");
                Console.Write("메뉴 선택: ");

                menu = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException e)
            {
                CommMenu.ErrMsg("subDelMenu", e.Message);

            }
            return menu;
        }

        public int subUpdateMenu()
        {
            int menu = 0;
            try
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("데이터 수정 선택");
                Console.WriteLine("1.차량 정보 수정");
                Console.WriteLine("2.고객 정보 수정");
                Console.WriteLine("3.판매자 정보 수정");
                Console.WriteLine("4.종료");
                Console.WriteLine("-----------------------");
                Console.Write("메뉴 선택: ");

                menu = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException e)
            {
                CommMenu.ErrMsg("subUpdateMenu", e.Message);

            }
            return menu;

        }
        public int subViewMenu()
        {
            int menu = 0;
            try
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("출력 선택");
                Console.WriteLine("1.차량 정보");
                Console.WriteLine("2.고객 정보");
                Console.WriteLine("3.판매자 정보");
                Console.WriteLine("4.종료");
                Console.WriteLine("-----------------------");
                Console.Write("메뉴 선택: ");

                menu = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException e)
            {
                CommMenu.ErrMsg("subViewMenu", e.Message);

            }
            return menu;

        }
    }
   
}
