using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getset
{

    class Marin
    {
        public string Name { get; private set; } = "마린";
        public int Mineral { get; set; }
    }
    class Person
    {
        //    private int count = 100;
        //    public string Name { get; set; } //자동 구현 프로퍼티
        //    public int Count
        //    {
        //        get { return count; } //읽기만 가능
        //    }

        //    public float Balance { get; private set; } //외부 변경 불가

        //    public void AddBal()
        //    {
        //        Balance += 100;
        //    }

        private string name; //내부 변수
        private int num;
        //값 설정하기 (Setter)
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        //public void SetName(string newName)
        //{
        //    name = newName;
        //}
        ////값 가져오기 (Getter)
        //public string GetName()
        //{
        //    return name;
        //}
    }
    class Program
    {
        static void Main(string[] args)
        {
            Marin m = new Marin();
            Console.WriteLine("name?" + m.Name + "mine?" + m.Mineral);
            //C#에서 get/set 방식의 함수와 프로퍼티 비교
            //C#에서는 객체의 값을 읽고(get), 설정(set)하는
            //방식으로 함수(get/set 메서드) 또는
            //**프로퍼티(Property)**를 사용할 수 있습니다.
            Person p = new Person();
            p.Name = "Name";
            Console.WriteLine("이름 : " + p.Name);
        }
    }
}