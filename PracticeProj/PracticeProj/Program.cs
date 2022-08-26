using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeProj
{
    public  class Program
    {
        private static Program ob = null;
        private  Program()
        {

        }
        //d
        //dd
        private void dd()
        {
            Console.WriteLine("uu");
            var k = 0;
            dynamic l;
        }
        //Main
        static void Main(string[] args)
        {

            StExp st = new StExp();
            StExp1.Add();
            //StExp1 st1 = new StExp1();


            //if(ob == null)
            //{
                ob = new Program();
            ob.dd();
            //}
            P1 o = new P1();
            o.v1();
            o.v2();
            //o.v3();
            Generics<int> g = new Generics<int>();
            g.gen(200);
            Generics<string> g1 = new Generics<string>();
            g1.gen("str");

            //MainClass cls = new MainClass();
            //cls.test();


            A Obj1 = new Test();
            Obj1.Hello();
            B Obj2 = new Test();
            Obj2.Hello();

            //ReplaceClass repl = new ReplaceClass();
            //string  ret = repl.ReplaceCharacter();
            //Console.WriteLine(ret);
            ReplaceClass2 rep = new ReplaceClass2();
            CountCharacters cnt = new CountCharacters();
            cnt.CountChars();
            Console.ReadKey();
            Console.WriteLine("Hello World!");
        }
    }

    public class Program2 
    {
       
    }

    public class P1
    {
        public void v1()
        {
            Console.WriteLine("v1");
        }
        public void v2()
        {
            Console.WriteLine("v2");
        }
    }

    public static class P2
    {
        public static void v1(this P1 p)
        {
            Console.WriteLine("v3");
        }
    }

    public class StExp
    {
        static StExp()
        {
            Console.WriteLine("static StExp");
        }
    }

    public class StExp1
    {
        private StExp1()
        {
            Console.WriteLine("static StExp");
        }

        public  static void Add()
        {
            Console.WriteLine("Hello StExp1");
        }
    }


    public class Generics<T>
    {
        public void gen(T data)
        {
            Console.WriteLine(data);
        }
    }


    public interface interface1
    {
        void test();
    }
    public interface interface2
    {
        void test();
    }

    //public class MainClass : interface1,interface2
    //{

    //     public void interface1.test()
    //    {
    //        Console.WriteLine("interface1");
    //    }
    //    public void interface2.test()
    //    {
    //        Console.WriteLine("interface2");
    //    }


    //}

    interface A
    {
        void Hello();
    }
    interface B
    {
        void Hello();
    }
    class Test : A, B
    {
         void B.Hello()
        {
            Console.WriteLine("Hello to all-B");
        }

        void A.Hello()
        {
            Console.WriteLine("Hello to all-A");
        }
    }
    public class interfacetest
    {
       
    }


    public class ReplaceClass
    {

        public ReplaceClass()
        {
            Console.WriteLine("ReplaceClass Cons");
        }

        public string ReplaceCharacter() {
            string returnWord = string.Empty;

            Console.WriteLine("enter string");
            string str = Console.ReadLine();

            Console.WriteLine("enter string to replace");

            char replaceword = Convert.ToChar( Console.ReadLine());
            Console.WriteLine("enter string to replace word");
            char replaceTo = Convert.ToChar(Console.ReadLine());


            for (int i = 0; i<str.Length; i++) {

                if (str[i] == replaceword)
                {
                    returnWord = returnWord + replaceTo;
                }
                else
                    returnWord = returnWord + str[i];


            }

            return returnWord;

        }




    }

    public class ReplaceClass2 : ReplaceClass
    {
        public ReplaceClass2()
        {
            Console.WriteLine("ReplaceClass2 Cons");
        }
    }

    public class CountCharacters
    {

        public void CountChars()
        {
            string str = "Venkatasai";
            Dictionary<char, int> dic = new Dictionary<char, int>();

            foreach(var character in str)
            {
                if (!dic.ContainsKey(character))
                {
                    dic.Add(character, 1);
                }
                else
                    dic[character]++;
                
            }
            foreach (var charcter in dic)
            {
                Console.WriteLine("{0}-{1}", charcter.Key, charcter.Value);
            }


        }


    }





}
