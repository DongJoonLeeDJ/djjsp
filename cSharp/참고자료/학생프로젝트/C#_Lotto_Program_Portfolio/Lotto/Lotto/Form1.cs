using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Json;
using System.Windows.Forms;

namespace Lotto
{
    partial class Form1 : Form
    {
        Random r = new Random();

        string[] words = {"인생에 필요한 것은 용기와 상상력,/그리고 약간의 돈이다.", "로또 외엔 방법 없다.", "돈이란 바닷물과 같다./마시면 마실수록 말라진다.",
            "돈 빌려주기 좋아하는 사람은/그냥 주는 사람이다.", "돈이란 누구에게도/무한한 것은 아니다.", "돈 없이 연애 결혼하면,/즐거운 밤과 슬픈 낮을 갖게된다.",
            "돈은 누군지도 묻지 않고,/그 소유자에게 권리를 준다.", "돈은 양으로 따질 뿐,/질로 따지는 것이 아니다.", "돈을 빌려준 사람은 돈을 빌린/사람보다 훨씬 기억력이 좋다.", "돈을 빌리는 것은/노예가 되는 것이다.",
            "인류는 두 인종을 이루어져 있다./빌리는 자와 빌려주는 자들로.", "지갑이 가벼우면/마음이 무겁다."};
        string[] names = { "찰리 채플린", "대한민국 누군가", "쇼펜하우어", "조지 하버트", "손자병법", "영국 속담", "라스킨", "짐멜", "프랭클린", "에머슨", "C.램", "괴테" };

        public Form1()
        {
            InitializeComponent();
        }

        private void RandomButton_Click(object sender, EventArgs e)
        {
            try
            {
                int round = int.Parse(resultRound.Text);
                if(round >= 958)
                {
                    int[] preNums = getNums(957);
                    int[] randNums = sortArr(randNum(preNums));

                    getResult(randNums);

                    getText();
                }
                else
                {
                    int[] nowNums = getNums(round);

                    int[] preNums = getNums(round - 1);

                    int[] randNums = bubbleSort(randNum(preNums));

                    getResult(nowNums, randNums);

                    getText();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("입력 형식을 확인해 주세요.", "입력 오류");
            }

        }

        public Color numColor(int num)
        {
            if (num >= 1 && num <= 10)
            {
                return Color.Goldenrod;
            }
            else if (num >= 11 && num <= 20)
            {
                return Color.CornflowerBlue;
            }
            else if (num >= 21 && num <= 30)
            {
                return Color.IndianRed;
            }
            else if (num >= 31 && num <= 40)
            {
                return Color.DarkGray;
            }
            else
            {
                return Color.MediumSeaGreen;
            }

        }

        public int[] randNum(int[] preNums)
        {
            int[] nums = new int[6];
            while (true)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    nums[i] = r.Next(1, 46);
                    for (int j = 0; j < i; j++)
                    {
                        if (nums[i] == nums[j])
                        {
                            i--;
                            break;
                        }
                    }
                }
                bool checker = getCheck(preNums, nums);
                if (checker == true)
                {
                    checker = getContinue(nums);
                    if (checker == true)
                    {
                        checker = getHoljjack(nums);
                        if (checker == true)
                        {
                            checker = getHignNum(nums);
                            if (checker == true)
                                break;
                        }
                    }
                }
            }
            return nums;
        }

        public void getResult(int[] roundNums, int[] nums)
        {
            num1.Text = nums[0].ToString();
            num1.BackColor = numColor(nums[0]);
            num2.Text = nums[1].ToString();
            num2.BackColor = numColor(nums[1]);
            num3.Text = nums[2].ToString();
            num3.BackColor = numColor(nums[2]);
            num4.Text = nums[3].ToString();
            num4.BackColor = numColor(nums[3]);
            num5.Text = nums[4].ToString();
            num5.BackColor = numColor(nums[4]);
            num6.Text = nums[5].ToString();
            num6.BackColor = numColor(nums[5]);

            roundNum1.Text = roundNums[0].ToString();
            roundNum1.BackColor = numColor(roundNums[0]);
            roundNum2.Text = roundNums[1].ToString();
            roundNum2.BackColor = numColor(roundNums[1]);
            roundNum3.Text = roundNums[2].ToString();
            roundNum3.BackColor = numColor(roundNums[2]);
            roundNum4.Text = roundNums[3].ToString();
            roundNum4.BackColor = numColor(roundNums[3]);
            roundNum5.Text = roundNums[4].ToString();
            roundNum5.BackColor = numColor(roundNums[4]);
            roundNum6.Text = roundNums[5].ToString();
            roundNum6.BackColor = numColor(roundNums[5]);
            roundBonus.Text = roundNums[6].ToString();
            roundBonus.BackColor = numColor(roundNums[6]);

            int count = 0;
            for (int i = 0; i < roundNums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (roundNums[i] == nums[j])
                        count++;
                }
            }

            if (count >= 6)
                resultText.Text = "1등!!";
            else if (count == 5)
            {
                bool checker = false;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] == roundNums[6])
                    {
                        checker = true;
                        break;
                    }
                }
                if (checker == true)
                    resultRound.Text = "2등!!";
                else
                    resultRound.Text = "3등!!";
            }
            else if (count == 4)
                resultText.Text = "4등!!";
            else if (count == 3)
                resultText.Text = "5등!!";
            else
                resultText.Text = "꽝!!";
            MessageBox.Show("중복된 값 : " + count, "중복");
        }
        
        public void getResult(int[] nums)
        {
            num1.Text = nums[0].ToString();
            num1.BackColor = numColor(nums[0]);
            num2.Text = nums[1].ToString();
            num2.BackColor = numColor(nums[1]);
            num3.Text = nums[2].ToString();
            num3.BackColor = numColor(nums[2]);
            num4.Text = nums[3].ToString();
            num4.BackColor = numColor(nums[3]);
            num5.Text = nums[4].ToString();
            num5.BackColor = numColor(nums[4]);
            num6.Text = nums[5].ToString();
            num6.BackColor = numColor(nums[5]);
        }

        // 명언 랜덤
        public void getText()
        {
            int word = r.Next(0, words.Length);
            if (word == 1)
            {
                title1.Text = string.Format("\"{0}\"", words[1]);
                title2.Text = "";
            }
            else
            {
                string[] titles = words[word].Split('/');
                title1.Text = string.Format("\"{0}", titles[0]);
                title2.Text = string.Format("{0}\"", titles[1]);
            }
            name.Text = string.Format("- {0} -", names[word]);
        }

        // 전 회차 중복 체크
        public bool getCheck(int[] preNums, int[] nums)
        {
            bool checker = true;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (preNums[i] == nums[j])
                    {
                        checker = false;
                        break;
                    }
                }
            }
            return checker;
        }

        // 연속된 번호 체크
        public bool getContinue(int[] nums)
        {
            // 정렬방식1. Array.Sort
            Array.Sort(nums);
            int count = 0;
            for (int i = 0; i < nums.Length-1; i++)
            {
                if (nums[i] == nums[i + 1] - 1)
                    count++;
            }
            if (count >= 2)
                return false;
            else
                return true;
        }

        // 홀짝 비율 체크
        public bool getHoljjack(int[] nums)
        {
            bool checker = false;
            int holcount = 0;
            int jjackcount = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                    jjackcount++;
                else
                    holcount++;
            }
            if (holcount >= 2 || jjackcount >= 2)
                checker = true;
            return checker;
        }

        // 많이 당첨된 번호 상위 6개 체크
        public bool getHignNum(int[] nums)
        {
            bool checker = false;
            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i] == 43 || nums[i] == 27 || nums[i] == 34 || nums[i] == 17 || nums[i] == 4 || nums[i] == 13)
                    checker = true;
            }
            return checker;
        }

        // 로또 API 가져오기
        private string GetHttpLottoString(string strUri)
        {
            string strResponseText = string.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(strUri);
            request.Method = "GET";

            request.Timeout = 20 * 1000;

            using (HttpWebResponse hwr = (HttpWebResponse)request.GetResponse())
            {
                if (hwr.StatusCode == HttpStatusCode.OK)
                {
                    Stream respStream = hwr.GetResponseStream();
                    using (StreamReader sr = new StreamReader(respStream))
                    {
                        strResponseText = sr.ReadToEnd();
                    }
                }
                else
                {
                    strResponseText = "";
                }
            }
            return strResponseText;
        }

        // 회차별 당첨결과 가져오기
        public int[] getNums(int round)
        {
            string strReturnValue = GetHttpLottoString("https://www.dhlottery.co.kr/common.do?method=getLottoNumber&drwNo=" + round);
            if (strReturnValue == "")
            {
                MessageBox.Show("불러오기 실패", "오류");
            }

            JsonTextParser jtr = new JsonTextParser();
            JsonObject jo = jtr.Parse(strReturnValue);

            JsonObjectCollection jac = (JsonObjectCollection)jo;

            int[] nums = {
                    Convert.ToInt32(jac["drwtNo1"].GetValue()),
                    Convert.ToInt32(jac["drwtNo2"].GetValue()),
                    Convert.ToInt32(jac["drwtNo3"].GetValue()),
                    Convert.ToInt32(jac["drwtNo4"].GetValue()),
                    Convert.ToInt32(jac["drwtNo5"].GetValue()),
                    Convert.ToInt32(jac["drwtNo6"].GetValue()),
                    Convert.ToInt32(jac["bnusNo"].GetValue())
                };
            LottoInfo.Text = "누적상금 : " + jac["totSellamnt"].GetValue().ToString() + "원   " +
                "1등 당첨금 : " + jac["firstWinamnt"].GetValue().ToString() + "원   " +
                "1등 당첨 인원 : " + jac["firstPrzwnerCo"].GetValue().ToString() + "명   " +
                "1등 당첨금 총액: " + jac["firstAccumamnt"].GetValue().ToString() + "원";
            return nums;
        }

        // 정렬방식2. 선택 정렬
        public int[] sortArr(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        int copy = nums[i];
                        nums[i] = nums[j];
                        nums[j] = copy;
                    }
                }
            }
            return nums;
        }
        
        // 정렬방식3. 버블 정렬
        public int[] bubbleSort(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length-1; j++)
                {
                    if (nums[j] > nums[j+1])
                    {
                        int copy = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = copy;
                    }
                }
            }
            return nums;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void resultRound_Click(object sender, EventArgs e)
        {
            resultRound.Text = "";
        }

        private void resultRound_Leave(object sender, EventArgs e)
        {
            resultRound.Text = "~957까지";
        }
    }
}
