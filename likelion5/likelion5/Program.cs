using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace likelion5
{
    class Program
    {
        static void Main(string[] args)
        {
            //int integerNum = 10; //정수
            //float flatNum = 3.14f; //단정밀도 실수
            //double doubleNum = 3.1415926535; //배정밀도 실수

            //Console.WriteLine(integerNum); 
            //Console.WriteLine(flatNum); 
            //Console.WriteLine(doubleNum);

            //정수 데이터형식의 int, long
            //int intValue = -100; //4byte
            //long longValue = 1234567890L; //8byte

            //Console.WriteLine(intValue); //-100out
            //Console.WriteLine(longValue); //123456789out

            //부호, 음/양수를 표현
            //sbyte signedByte = -50; //1byte
            //short signedShort = -32000; //2byte
            //int signedInt = -20000000; //4byte
            //bit 0&1 {bit(n) = 8} = 1byte

            //Console.WriteLine(signedByte);
            //Console.WriteLine(signedShort);
            //Console.WriteLine(signedInt);

            //byte unsignedByte = 255; //1byte
            //ushort unsignedShort = 65000; //2byte
            //uint unsignedInt = 400000000; //4byte. 음 용량을 양수로 2배확장

            //Console.WriteLine(unsignedByte);
            //Console.WriteLine(unsignedShort);
            //Console.WriteLine(unsignedInt);

            //float singlePrecision = 3.14f; //4byte
            //double doublePrecision = 3.1415926535; //8byte
            //decimal highPrecision = 3.14159265358979323846m; //16byte

            //Console.WriteLine(singlePrecision);
            //Console.WriteLine(doublePrecision);
            //Console.WriteLine(highPrecision);

            //int integerValue = 100;
            //long longValue = 100L;
            //float floatValue = 3.14f;
            //double doubleValue = 3.14;
            //decimal decimalValue = 3.14m;

            //Console.WriteLine(integerValue);
            //Console.WriteLine(longValue);
            //Console.WriteLine(floatValue);
            //Console.WriteLine(doubleValue);
            //Console.WriteLine(decimalValue);

            //문자character, 과거 1byte였으나 현재는 2byte
            //char letter = 'A';
            //char symbor = '#';
            //char number = '9';

            //Console.WriteLine(letter);
            //Console.WriteLine(symbor);
            //Console.WriteLine(number);

            //문자열, 문장과 같음
            //string greeting = "Hello World!";
            //string name = "Alice";

            //Console.WriteLine(greeting);
            //Console.WriteLine(name);
            //Console.WriteLine(greeting +" "+ name);
            //Console.WriteLine("Hello World Alice~");


            //True1&False0 참, 거짓 논리연산
            //bool isRunning = true;
            //bool isFinished = false;

            //Console.WriteLine(isRunning);
            //Console.WriteLine(isFinished);

            //고유값 지정const
            //const double Pi = 3.14159;
            //const int MaxScore = 100;

            //Console.WriteLine(Pi);
            //Console.WriteLine(MaxScore);

            ////.NET
            //System.Int32 number = 123;
            //System.String text = "Hello";
            //System.Boolean flag = true;

            //Console.WriteLine(number);
            //Console.WriteLine(text);
            //Console.WriteLine(flag);

            //래퍼wrapper, 형식을 변환, 정수를 문자열로 바꾸는 식
            int number = 123;
            string numberAsString = number.ToString();

            bool flag = true;
            string flagAsString = flag.ToString(); //true_out

        }
    }
}
