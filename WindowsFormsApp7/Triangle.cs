using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    class Triangle
    {
        double number, number2, number3, p ;                          //сторона квадрата
        int operationCode;                      //1-диагональ 2-периметр 3-площадь
        string result;
      

        public double Number { get => number; set => number = value; }
        public double Number2 { get => number2; set => number2 = value; }
        public double Number3 { get => number3; set => number3 = value; }
        public int OperationCode { get => operationCode; set => operationCode = value; }
        public string Result { get => result; }
      

        public void Triangleg()
        {
                p = ((number + number2 + number3) / 2);
           
                result = Math.Sqrt(p * (p - number) * (p - number2) * (p - number3)).ToString();               //Нахождение площади
               
        }
    }
}