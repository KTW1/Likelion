using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Week3_1st
{
    /*
    */
    //public class Player //기본.
    //{
    //    public string Name { get; set; }
    //    public int Score { get; set; }
    //}
    ////상속하는 클래스
    //public class Warrior : Player
    //{
    //    public int Strength { get; set; }
    //}
    //public class MyClass
    //{
    //    public string Message { get; set; }

    //}
    ////인터페이스를 구현하는 클래스
    ////public class Enemy : IAttackable, IMovable
    ////{
    ////    public void Attack() { }
    ////    public void Move() { }
    ////}
    ////추상클래스? abstract 차이점? 
    //public abstract class Animal
    //{
    //    public abstract void MakeSound();
    //}
    class Program
    {
        class Cup<T>
        {
            public T Content { get; set; }
        }
        public interface Enumerator
        {
            bool MoveNext();
            object Current { get; }
            void Reset();
        }
        static void Main(string[] args)
        {

            Dictionary<string, int> pair = new Dictionary<string, int>();
            pair["A"] = 10;
            pair["B"] = 30;
            pair["C"] = 20;
            foreach (var Array in pair)
            {
                Console.WriteLine($"key {Array.Key}, Value {Array.Value}");
            }

            //배열문 출력을 길게 늘여놓은 꼴인데, 굳이 쓸까 싶긴하다. 이해만 하고 넘어가는 정도
            //ArrayList list = new ArrayList { "A","B" ,"C" };
            //Enumerator enumerator = (Enumerator)list.GetEnumerator();
            //while (enumerator.MoveNext()) //다음 요소가 있는지 확인
            //{
            //    Console.WriteLine(enumerator.Current);//현재 요소 출력
            //}

            ////Collection.Generic환경에서는 일반적 stack선언이 안됐는데, Stack<T>를 통해 선언이 가능하다.
            //Stack<int> nums = new Stack<int>();
            //List<string> sent = new List<string>();
            
            //Cup<String> Sent = new Cup<string> { Content = "Coffee and Tea" };
            //Cup<int> Num = new Cup<int> { Content = 3 };

            ////이론은 훌륭하지만, 실제 활용도는 글쎄?
            ////Collection 환경에서는 동작을 한다. 형식지정이 안되었기 때문일 것인데, 그럼 var로 하면 되나?
            //Hashtable Hash = new Hashtable();
            //Hash["Name1"] = 20;
            //Hash["Name2"] = 30;
            //Hash["Name3"] = 25;
            //foreach (DictionaryEntry entry in Hash)
            //{
            //    Console.WriteLine($"Key {entry.Key}. Value {entry.Value} ");
            //}
            ////특정 키의 값 가져오기
            //Console.WriteLine($"\n Alice의 나이 : {Hash["Alice"]}");
            ////요소제거
            //Hash.Remove("Bob");

            //스택, 큐 이런 자료구조에 관한 부문은 효율적 프로그래밍 작업에서, 자주 쓰이진 않는다.
            //Stack data = new Stack();
            //data.Push(1);
            //data.Push(2);
            //data.Push(3);
            //while (data.Count > 0)
            //{
            //    Console.WriteLine(data.Pop());
            //}
            //Queue data2 = new Queue();
            //data2.Enqueue(1);
            //data2.Enqueue(2);
            //data2.Enqueue(3);
            //while (data2.Count > 0)
            //{
            //    Console.WriteLine(data2.Dequeue());
            //}

            //ArrayList는 형식을 다양하게 저장할 수 있다. 이게 상당히 유용해 보인다.
            //ArrayList AL = new ArrayList();
            //AL.Add(1);
            //AL.Add('A');
            //AL.Add("Hello");
            //foreach(var Var in AL)
            //{
            //    Console.WriteLine(Var);
            //}

            //배열이 있는데, 가변배열인 List. 고정적 배열/고속, 가변배열/상대적 저속 선택하면 된다.
            //List<string> names = new List<string> { "A", "B", "C" };
            //names.Add("E");
            //names.Remove("B");
            //foreach(var neo in names)
            //{
            //    Console.WriteLine(neo);
            //}
            //List<int> nums = new List<int>();
            //nums.Add(1);
            //nums.Add(2);
            //nums.Add(3);
            //nums.Insert(1, 199); //이거 리스트로 쓸 수 있겠다.
            //Console.WriteLine(nums.Count);

            //throw로 예외발생을 만들 수 있다. 테스트용
            //Finally 예외여부 상관없이 실행. //Exception 클래스가 기본.
            //예외처리. try catch를 쓴다. 오류가 생겨도 계속 실행한다. 서버같은 부문에 자주 쓰인다. 네트워크
            //while (true)
            //{
            //    try
            //    {
            //        int age = 0;
            //        if(age < 0){
            //            throw new ArgumentException("Error occurred");
            //        }
            //        //int[] nums = { 1, 2, 3 };
            //        //Console.WriteLine(nums[4]);
            //    }
            //    catch (IndexOutOfRangeException ex) //catch(Exception ex)
            //    {
            //        Console.WriteLine($"Error {ex.Message}");
            //    }
            //    //finally
            //    //{
            //    //    Console.WriteLine("Always execute");
            //    //}
            //}

            //문자열관련 stringbuilder가 효율적인 경우? 여러번 수정할 때. 속도가 빠르다.
            //StringBuilder sb = new StringBuilder("Hello");
            //sb.Append(",");
            //sb.Append("World");
            //Console.WriteLine(sb.ToString());

            //string text = "C# is awesome!";
            //Console.WriteLine($"{text.Contains("awesome")}"); //true
            //Console.WriteLine($"{text.StartsWith("C#")}"); //true
            //Console.WriteLine($"{text.IndexOf("is")}"); //인덱스 순서? 이게 무슨말인지?
            //Console.WriteLine($" {text.Replace("awesome", "great")}");

            //string name = "Alice";
            //Console.WriteLine($"{name.Length}");
            //Console.WriteLine($"{name.ToUpper()}");
            //Console.WriteLine($"{name.Substring(1)}"); //lice. 앞글자부터 제외하고 출력한다.

            //object의 변수는 42라는 값의 메모리 주소를 저장. 
            //var형식을 잊고있었다. int/string 범용성이 뛰어난데, 
            //is 연산자 형식 비교? 객체object의 형식을 확인한다. 형식? int인지 string인지 따위
            //object obj = 123;
            //Console.Write(obj is string); //true
            //Console.Write(obj is int); //false

            //obj = (int)obj;
            //Console.Write(obj is int); //true?

            ////as로 형식변환? 안전하게 하고싶을 때.
            //string str = obj as string;
            //Console.WriteLine(str is string); //true?

            //박싱box.value값을 참조ref화 한다. 언박싱unbox
            //int value = 3;
            //object box = value; //이게 참조화하는 구조.
            //int unbox = (int)box; //이게 다시 밸류화하는 것. 실제 값을 주느냐, 변수-변수 관계로 묶느냐 차이다.

            //클래스, 배열, 델리게이트, 인터페이스 등이 참조 형식. 하나를 수정 > 다른 하나에도 영향
            //스택은 CPU와 가까운 메모리 공간에 위치하기 때문에 접근 속도가 빠릅니다.
            //힙은 상대적으로 먼 곳에 위치하기 때문에 접근 속도가 느립니다
            //값value 형식은 스택stack, 참조ref 형식은 힙heap에 저장. 차이는? 
            //{
            //    int valueType =10;
            //    object referenceType = valueType;
            //    valueType =20;
            //    Console.WriteLine($"ValueType: {valueType}"); // 20
            //    Console.WriteLine($"ReferenceType: {referenceType}"); // 10
            //}

            //부모클래스 상속클래스
            //클래스 시그니처. 선언부 public private protected +수정자 abstract aseled static partial

            //자연어로 적힌 문장? 속에 있는 전화번호/이메일같은 형태를 정규식이라 하는 걸 판별한다.
            //Q1. 이메일이나 번호 자체를 추출하려면?
            //string input = "이렇게 문장으로 적혀 있을 경우123-456-7890";
            //string pattern = @"\d{3}-\d{3}-\d{4}";
            //bool isMatch = Regex.IsMatch(input, pattern);
            //Console.WriteLine($"Is valid phone number: {isMatch}");

            //프로그램 실행시간을 구할 수 있는데, 활용도는 잘 모르겠다. 
            //{
            //    Stopwatch A =Stopwatch.StartNew();
            //    // 실행 코드
            //    for (int i =0; i <100; i++) { Thread.Sleep(1); }
            //    A.Stop();
            //    Console.WriteLine($"Execution Time: {A.ElapsedMilliseconds} ms");
            //}

            //Random random = new Random();
            //int randomNumber = random.Next(1, 101);
            //Console.WriteLine($"Random Number: {randomNumber}");

            //C계열은 엇비슷하니까 하나의 주축언어를 갖고, 확장하는 식.
            //string path =  Environment.GetEnvironmentVariable("PATH");
            //Console.WriteLine($"PATH {path}");

            //프로그램/콘솔창 종료하는 메서드. if종료조건, 종료하는 식으로 사용했다.
            //.WriteLine("Exiting the program...");
            //Environment.Exit(0);
        }
    }
}
