using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        enum Operators //  Operators라는 열거형을 선언
        {
            None,
            Add,
            Subtract,
            Multiply,
            Divide,
            Result
        }

        Operators currentOperator = Operators.None;// 열거형 변수로 currentOperator를 사용.
                                                   // 열거형 변수에 값을 넣을 때는 Operators.None, Operators.Add 등과 같이 열거형 내부에 있는 이름을 호출해 사용.
                                                   // 초기에는 연산자가 선택되지 않은 상태를 표현하기 위해 Operators.None으로 값을 초기화.
                                                   // (현재 '연산자'를 저장할 변수)
        Boolean operatorChangeFlag = false; // ('연산자가 변경'되었는지 여부를 저장할 변수)
                                            // operatorChangeFlag 변수는 연산자가 눌렸음을 알 수 있는 변수로,
                                            // 연산자가 눌리거나 변경되면 true 값을 갖습니다.
                                            // 즉, 연산자 버튼이 눌리면 기존에 입력한 숫자를 저장하고, 새로 숫자를 입력받기 위한 변수.
        int firstOperand = 0; // (첫 번째 '피연산자'를 저장할 변수)
                              // 피연산자

        int secondOperand = 0; // (두 번째 '피연산자'를 저장할 변수)
                               // 피연산자


        // +, -, *, / 연산
        private void ButtonResult_Click(object sender, EventArgs e) // 결과(=) 버튼을 클릭했을 때
        {
            secondOperand = Int32.Parse(display.Text); // display.Text에 있는 값을  Int32.Parse 메소드를 통해 정수형으로 변환 후 secondOperand 변수에 저장
                                                       // (두 번째 피연산자 저장)

            if (currentOperator == Operators.Add) // currentOperator 변수에 저장된 값이 Operators.Add 값과 같다면
                                                  // (덧셈(+) 버튼이 눌렸다면)
            {
                firstOperand += secondOperand; // firstOperand 변수에 secondOperand 값을 더한 후 firstOperand 변수에 저장
                                               // (첫 번째 피연산자와 두 번째 피연산자를 더해 첫 번째 피연산자에 저장하고,)
                display.Text = firstOperand.ToString(); // firstOperand 변수에 있는 값을 display.Text에 출력
                                                        // (그 값을 문자열로 변환해 레이블에 출력합니다.)
            }


            else if (currentOperator == Operators.Subtract)
            {
                firstOperand -= secondOperand;
                display.Text = firstOperand.ToString();
            }
            else if (currentOperator == Operators.Multiply) 
            {
                firstOperand *= secondOperand;
                display.Text = firstOperand.ToString();
            }
            else if (currentOperator == Operators.Divide)
            {
                if (secondOperand == 0) // 만약 secondOperand 변수에 0이 저장되어 있다면
                {
                    display.Text = "0으로 나눌 수 없습니다."; // "0으로 나눌 수 없습니다." 를 출력
                }

                else
                {
                    firstOperand /= secondOperand;
                    display.Text = firstOperand.ToString();
                }
            }
        }


        // 첫 번째 피연산자(숫자) 저장, 어떤 연산자가 눌렸는지 저장, 기존에 레이블에 출력된 문자를 지우고 다시 숫자를 출력하기 위한 변수 설정
        private void ButtonAdd_Click(object sender, EventArgs e) // 덧셈 버튼을 클릭했을 때
        {
            firstOperand = Int32.Parse(display.Text); // display.Text에 있는 값을  Int32.Parse 메소드를 통해 정수형으로 변환 후 firstOperand 변수에 저장
            currentOperator = Operators.Add; // currentOperator 에 덧셈(+) 버튼이 눌렸음을 알려주기 위해, currentOperator 변수에 Operators.Add 값을 저장
            operatorChangeFlag = true; // operatorChangeFlag 변수를 true로 변경
                                       // operatorChangeFlag 변수는 연산자가 눌릴때마다 true 값으로 설정해야, 버튼을 누를때 출력된 값을 지우고 다시 숫자를 출력하기 때문에 필요
        }

        private void ButtonSubtract_Click(object sender, EventArgs e)
        {
            firstOperand = Int32.Parse(display.Text);
            currentOperator = Operators.Subtract;
            operatorChangeFlag = true;
        }

        private void ButtonMultiply_Click(object sender, EventArgs e)
        {
            firstOperand = Int32.Parse(display.Text);
            currentOperator = Operators.Multiply;
            operatorChangeFlag = true;
        }

        private void ButtonDivide_Click(object sender, EventArgs e)
        {
            firstOperand = Int32.Parse(display.Text);
            currentOperator = Operators.Divide;
            operatorChangeFlag = true;
        }


        private void ButtonAllClear_Click(object sender, EventArgs e) // AC(All Clear) 버튼을 클릭했을 때
        {
            firstOperand = 0; // firstOperand 변수에 0을 저장
                              // ( 숫자 초기화 )
            secondOperand = 0; // secondOperand 변수에 0을 저장
                               // ( 숫자 초기화 )
            currentOperator = Operators.None; // currentOperator 변수에 Operators.None 값을 저장
                                              // ( 연산자 초기화 )
            display.Text = "0"; // display.Text에 0을 출력
        }

        private void ButtonPoint_Click(object sender, EventArgs e)
        {

        }


        // 숫자 버튼 클릭 이벤트
        private void ButtonZero_Click(object sender, EventArgs e)
        {
            if(operatorChangeFlag == true) // operatorChangeFlag 변수는 연산자가 눌렸음을 알 수 있는 변수로,
                                           // 연산자가 눌리거나 변경되면 true 값을 갖습니다.
                                           // (연산자가 변경되었다면 = 연산자가 눌러졌다면)
            {
                display.Text = ""; // display.Text에 있는 값을 초기화
                                   // (기존에 레이블에 출력된 문자를 지우고,) 
                operatorChangeFlag = false; // operatorChangeFlag 변수를 false로 변경
                                            // (다시 지우는 것을 방지하기 위해 operatorChangeFlag 값을 false로 변경합니다.)
            }

            string strNumber = display.Text += "0"; // "00"
            int intNumber = Int32.Parse(strNumber); // 0
            display.Text = intNumber.ToString(); // "0"
        }

        private void ButtonOne_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true) // operatorChangeFlag 변수는 연산자가 눌렸음을 알 수 있는 변수로,
                                            // 연산자가 눌리거나 변경되면 true 값을 갖습니다.
                                            // (연산자가 변경되었다면 = 연산자가 눌러졌다면)
            {
                display.Text = ""; // display.Text에 있는 값을 초기화
                                   // (기존에 레이블에 출력된 문자를 지우고,) 

                operatorChangeFlag = false; // operatorChangeFlag 변수를 false로 변경
                                            // (다시 지우는 것을 방지하기 위해 operatorChangeFlag 값을 false로 변경합니다.)
            }


            string strNumber = display.Text += "1"; // "01"
            int intNumber = Int32.Parse(strNumber); // 1

            display.Text = intNumber.ToString(); // "1"
        }

        private void ButtonTwo_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }

            string strNumber = display.Text += "2";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void ButtonThree_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }

            string strNumber = display.Text += "3";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void ButtonFour_Click(object sender, EventArgs e)
        {
            if(operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }

            string strNumber = display.Text += "4";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void ButtonFive_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }

            string strNumber = display.Text += "5";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void ButtonSix_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }

            string strNumber = display.Text += "6";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void ButtonSeven_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "7";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void ButtonEight_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "8";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void ButtonNine_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "9";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }
    }
}
