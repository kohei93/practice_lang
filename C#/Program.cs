using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sample601
{
    class Person
    {
        //  名前（フィールド）
        public string name = "";
        //  年齢（フィールド）
        public int age = 0;
        //  情報の表示（メソッド）
        public void ShowAgeAndName()
        {
            Console.WriteLine("名前：{0} 年齢：{1}", name, age);
        }
        //  情報の設定
        public void SetAgeAndName(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }

    class Program{
        static void Main(string[] args){
            Person p1,p2;
            // Person p3=new Person();
            p1=new Person();
            p2=new Person();
            p1.name="山田太郎";
            p1.age=19;
            p2.SetAgeAndName("佐藤花子",23);
            p1.ShowAgeAndName();
            p2.ShowAgeAndName();

        }
    }
}

