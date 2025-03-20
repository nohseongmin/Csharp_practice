using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week02Proj01
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }



        private void btnOutput01_Click(object sender, EventArgs e)
        {
            bool isToggle = chkToggle.Checked;          //true or false


            //체크박스 값이 T일때 문자열 연결연산, F일때 산술연산
            if (isToggle)
            {
                string data1 = tbxInp1.Text;                //text는 값이기 때문에 변수에 대입 가능(tbxInp1은 타입이므로 불가)
                string data2 = tbxInp2.Text;
                string result = data1 + data2;              //문자열 연결 연산자로 적용
                lblResult.Text = result;
            }
            else
            {
                int data1 = int.Parse(tbxInp1.Text);    //spring을 int로 형변환 ( int.parse메소드 활용)
                int data2 = int.Parse(tbxInp2.Text);
                int result = data1 + data2;             //산술연산자로 적용
                lblResult.Text = result.ToString();     //파이썬에서의 __str__ (모든 변수에 적용가능)
            }
        }

        private void btnOutput02_Click(object sender, EventArgs e)
        {
            if (chkToggle.Checked == false)             //bool 타입 선언은 생략가능
            {
                int data1 = int.Parse(tbxInp1.Text);
                int data2 = int.Parse(tbxInp2.Text);
                int result = data1 + data2;
                lblResult.Text = "더하기 : " + result;  //문자열 이어붙이기(다른 타입이어도 됨(문자열로 통일해버림))
            }
            else
            {
                int data1 = int.Parse(tbxInp1.Text);
                int data2 = int.Parse(tbxInp2.Text);
                int result = data1 - data2;
                lblResult.Text = "빼기 : " + result;
            }
        }

        private void btnOutput03_Click(object sender, EventArgs e)
        {
            int data1 = int.Parse(tbxInp1.Text);
            int data2 = int.Parse(tbxInp2.Text);
            if (chkToggle.Checked == false) {
                int result = data1 + data2;
                lblResult.Text = string.Format("더하기:{0}", result);//파이썬처럼 소수점 처리가능
            }
            else {
                int result = data1 - data2;
                lblResult.Text = $"빼기: {result}";   //파이썬처럼 가능 (f"{}") ==문자열 보간법==
            }
        }
        private void btnOutput04_Click(object sender, EventArgs e)
        {
            double data1 = double.Parse(tbxInp1.Text);   //.parse는 double처럼 앵간한데 다있음
            double data2 = double.Parse(tbxInp2.Text);
            if (chkToggle.Checked == false)
            {
                double result = data1 + data2;
                lblResult.Text = string.Format("더하기:{0}", result);//파이썬처럼 소수점 처리가능
            }
            else
            {
                double result = data1 - data2;
                lblResult.Text = $"빼기: {result}";   //파이썬처럼 가능 (f"{}") ==문자열 보간법==
            }
        }

        private void btnOutput05_Click(object sender, EventArgs e)
        {
            lblResult.Text = tbxInp1.Text;
            lblResult.Text += Environment.NewLine; // \n을 추가, environment.NewLine는 환경에 상관없이 적용가능
            //lblResult.Text = Environment.NewLine;  // \n을 대입

            lblResult.Text += tbxInp1.Text.GetType(); //어디든 가능한 메소드
            //lblResult.Text = tbxInp1.Text.GetType(); gettype()은 type 타입 이어서 불가능
            lblResult.Text += Environment.NewLine;

            lblResult.Text += tbxInp1.Text[0];      //char(문자) 타입, 문자열에서 문자를 뽑은것
            //lblResult.Text = tbxInp1.Text[0];       //문자열에 문자 대입 불가
            lblResult.Text += Environment.NewLine;      
            lblResult.Text += tbxInp1.Text[0].GetType();

            lblResult.Text += Environment.NewLine;
            char test1 = tbxInp1.Text[0];           //c언어   char=1byte(ascii)
                                                    //c#    char=2byte(unicode)
            byte result1 = (byte)test1;             //c#에서 추가된 1byte 정수형
            short result2 = (short)test1;           //short도 2byte 지만 정수형이라 불가 (부호지원)
            ushort result3 = test1;                 //u(nsigned)short 라 가능           (부호 미지원)
            sbyte result4 = (sbyte)test1;           //기본 byte는 unsigned임                
                                                    //c# long은 8짜리
            lblResult.Text +=
                $"{test1}, {result1}, {result2}, {result3}";
            /*
            byte = (1) 부호미지원 정수
            sbyte = (1) 부호지원 정수
            short = (2) 부호지원 정수
            ushort = (2) 부호미지원 정수
            long = (8) 부호지원 정수
            ulong = (8) 부호미지원 정수
             */

        }

        private void btnOutput06_Click(object sender, EventArgs e)
        {
            //정수 -> 실수 : 가능
            //실수 -> 정수 : 처리필요
            //작은수 -> 큰수 : 가능
            //큰수 -> 작은수 : 처리필요
            int data1 = short.Parse(tbxInp1.Text);
            float data2 = (float) double.Parse(tbxInp2.Text); //형변환 통해 처리(둘다 실수인데 크기가다름)
            long data3 = long.Parse(tbxInp3.Text);
            int data4 = (int)data3;                                //형변환 통해 처리(둘다 정수인데 크기가다름)

            double result1 = data1 + data2 + data3 + data4;         //정수+실수 = 실수 ( 우변은 float)
            lblResult.Text = result1.ToString();

            lblResult.Text += "\r\n";                           //\n만쓰면 안해주는 환경이 있음
            lblResult.Text += "\n";

            // (int)1.9 + (int)1.6 = > 2
            long result2 = data1 + (long)data2 + data3 + data4;//해결 1) 실수형만 정수형으로  
            lblResult.Text += result2.ToString();


            lblResult.Text += "\r\n";                           
            lblResult.Text += "\n";

            //int(1.9+1.6) => 3
            long result3 = (long)(data1 + data2 + data3 + data4);       //해결 2) 전체를 정수형으로
            lblResult.Text += result3.ToString();

            //어떻게 처리하는지 따라 결과가 다름 ( 주의 )
            //string은 태생이 다르기때문에 (string)data 이딴거 안됨
        }

        private void btnOutput07_Click(object sender, EventArgs e)
        {
            //123이 같은지 result123(bool)값으로 뺌
            bool result1 = tbxInp1.Text == tbxInp2.Text;
            bool result2 = tbxInp2.Text == tbxInp3.Text;
            bool result3 = tbxInp1.Text == tbxInp3.Text;

            if (result1 && result2 && result3) {
                lblResult.Text = "모두일치";
            }
            else if (result1 || result2 || result3) {
                lblResult.Text = "두개일치";
            }
            else {
                lblResult.Text = "모두다름";
            }
            
        }

        private void btnOutput08_Click(object sender, EventArgs e)
        {
            var data1 = int.Parse(tbxInp1.Text);
            var data2 = int.Parse(tbxInp2.Text);

            string result; //지역변수 초기화는 자동이 아님(else 필수)
            if (data1 == data2)
            {
                result = "같음";
            }
            else if (data1 < data2)
            {
                result = "2가 큼";
            }
            else
            {
                result = "1이 큼";
            }
            lblResult.Text = result;
        }

        private void btnOutput09_Click(object sender, EventArgs e)
        {
          //  lblResult.Text = int.MinValue.ToString)_ + ""
        }

        private void btnOutput10_Click(object sender, EventArgs e)
        {
            //배열
            TextBox[] textBoxes; //배열 선언 ~ 레퍼런스 타입(포인터)
            textBoxes = new TextBox[5]; //배열생성 후 위치 할당

            textBoxes[0] = tbxInp1;
            textBoxes[1] = tbxInp2;
            textBoxes[2] = tbxInp3;
            textBoxes[3] = tbxInp4;
            textBoxes[4] = tbxInp5;

            //객체지향 언어 특) 자료형을 class(아님 struct)로 맨듬
            //class = (값 + 추가 메타데이터) + 기능
            int sum = 0;
            //배열.length로 길이 뽑기
            for (int i = 0; i < textBoxes.Length; i++)
            {
                //문자열 = string = 기본값이 null이므로 처음에 null인지 확인 안해도됨
                //strip()처럼 사용하는 Trim()
                //공백인 경우와 null인경우 처리
                if (textBoxes[i].Text != null && textBoxes[i].Text.Trim() != "") 
                {
                    sum += int.Parse(textBoxes[i].Text);
                }
            }
            lblResult.Text = "총합 : " + sum;
        }

        private void btnOutput11_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes;
            textBoxes = new TextBox[5];

            textBoxes[0] = tbxInp1;
            textBoxes[1] = tbxInp2;
            textBoxes[2] = tbxInp3;
            textBoxes[3] = tbxInp4;
            textBoxes[4] = tbxInp5;

            int sum = 0;
            //모든 값이 빈 경우 제하기 위함
            int count = 0;
            for (int i = 0; i < textBoxes.Length; i++)
            {
                if (textBoxes[i].Text != null && textBoxes[i].Text.Trim() != "")
                {
                    sum += int.Parse(textBoxes[i].Text);
                    count++;
                }
            }
            lblResult.Text = "평균 : " + (sum/count);
        }
    }
}
