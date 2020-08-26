using System;
using System.Runtime.CompilerServices;



namespace travel_expense
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请从b、c、d中选择目的地：");
            string destination = Convert.ToString(Console.ReadLine());
            String a = "a";
            string b = "b";
            string c = "c";
            string d = "d";
            int distance;
            if (destination == b)
            {
                distance = 1;
            }
            else
            {
                if (destination == c)
                {
                    distance = 16;
                }
                else
                {
                    if (destination == d)
                    {
                        Console.WriteLine("现有两条道路，若走高速公路，请选e，其它选f");
                        String i = Convert.ToString(Console.ReadLine());
                        String e = "e";
                        String f = "f";
                        if (i == e)
                        {
                            distance = 67;
                        }
                        else
                        {
                            if (i == f)
                            {
                                distance = 86;
                            }
                            else
                            {
                                Console.WriteLine("输入错误");
                                distance = 0;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("输入错误");
                        distance = 0;
                    }
                }
            }
            Console.WriteLine("到目的地的距离为" + distance+ "km");
            Console.WriteLine("请选择出入方式：");
            Console.WriteLine("方式a：公交***方式b：开车***方式c：出租");
            Console.WriteLine("请选择：");
            String w = Convert.ToString(Console.ReadLine());
            int money;
            if (w == a)
            {
                Console.WriteLine("已选择公交");
                if (distance > 20)
                {
                    Console.WriteLine("距离过远，超出公交范围");
                    money = 0;
                }
                else
                {
                    money = 1;
                }
            }
            else
            {
                if (w == b)
                {
                    Console.WriteLine("已选择开车");
                    if (distance == 67)
                    {
                        money = 20 + distance * 5;
                    }
                    else
                    {
                        money = distance * 5;
                    }
                }
                else
                {
                    if (w == c)
                    {
                        Console.WriteLine("已选择出租");
                        if (distance >= 3)
                        {
                            money = 10 + (distance - 3) * 5;
                        }
                        else
                        {
                            money = 10;
                        }
                    }
                    else
                    {
                        money = 0;
                    }
                }
            }
            Console.WriteLine("共花费" + money + "元");
        }
    }
}
