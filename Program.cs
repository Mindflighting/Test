using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //test1
            //double num1, num2, num3;
            //num1 = Convert.ToDouble(Console.ReadLine());
            //num2 = Convert.ToDouble(Console.ReadLine());
            //num3 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("三个数字的乘积是："+ (num1*num2*num3));

            //test2
            //const double pi = 3.14;
            //Console.WriteLine("半径为3的圆面积是："+(pi*3*3) +"      圆周长是："+(pi*2*3));


            ////test3
            //int lvbaoshi = 120, xueping = 35;

            //Console.WriteLine("3个血瓶和2个绿宝石的价格是："+(lvbaoshi*2+xueping*3));
            //Console.WriteLine("打折后3个血瓶和2个绿宝石的价格是：" + ((lvbaoshi * 2 + xueping * 3)*0.88));

            //test4
            //int days = Convert.ToInt32(Console.ReadLine());
            //int week = days / 7;
            //int weekday = days % 7;
            //Console.WriteLine("输入的天数折合{0}周{1}天",week,weekday);

            //test5

            //int seconds = Convert.ToInt32(Console.ReadLine());
            //int second = seconds % 60;
            //int minute = ((seconds - second) / 60) % 60;
            //int hour = (((seconds - second) / 60) / 60) % 24;
            //int day = (((seconds - second) / 60) / 60) / 24;
            //Console.WriteLine("输入的秒数折合{0}天{1}时{2}分{3}秒",day,hour,minute,second);

            //Console.WriteLine("请输入用户名：");
            //string username = Console.ReadLine();
            //Console.WriteLine("请输入密码：");
            //string password = Console.ReadLine();

            //if (username == "wdm" & password == "111")
            //{
            //    Console.WriteLine("密码正确!");
            //}
            //else if (username != "wdm")
            //{
            //    Console.WriteLine("用户名错误");
            //}
            //else  {
            //    Console.WriteLine("密码错误");
            //}

            //test1 while circle
            //int i = 0;
            //while (i < 15) { Console.WriteLine("work");i++; };

            //test2 while circle
            //int i = 1, sum = 0;
            //while (i < 101)
            //{
            //    sum += i;
            //    i++;
            //};

            //Console.WriteLine("sum is {0}",sum);

            //test3 while circle

            //int i = 1, sum = 0;
            //while (i < 101)
            //{
            //    sum += i;
            //    i+=2;
            //};
            //Console.WriteLine("sum is {0}", sum);


            //test4 while circle
            //string input = Console.ReadLine();
            //while (input!="yes"&&input!="no")
            //{
            //    input = Console.ReadLine();
            //}

            //Console.WriteLine("over");

            //test5 while circle
            //Console.WriteLine("input students number:");
            //int stunum = Convert.ToInt32( Console.ReadLine());
            //int totalscore=0,i=0;
            //while (i < stunum) 
            //{
            //    Console.WriteLine("input score for student {0}",1+i);
            //    totalscore += Convert.ToInt32( Console.ReadLine());
            //    i++;
            //};
            //// double avescore = Convert.ToDouble(totalscore) / Convert.ToDouble( stunum);
            //double avescore = totalscore*1.000 /stunum;
            //Console.WriteLine("Total score is {0}",totalscore);
            //Console.WriteLine("Average score is {0}",avescore);

            //testt1 shuixianhuashu
            //for (int i = 100; i < 1000; i++)
            //{
            //    if ((i/100)*(i/100)*(i/100)+(i%100/10)*(i%100/10) * (i % 100 / 10)+(i%10)* (i % 10) * (i % 10) ==i) 
            //    {
            //        Console.WriteLine(i);
            //    }

            //};

            //testt2 99
            // Console.WriteLine("*\t1\t2\t3\t4\t5\t6\t7\t8\t9");
            //for (int i = 1; i < 10; i++) 
            //{
            //    //Console.Write(i);
            //    //Console.Write("\t");
            //    for (int j = 1; j <=i; j++)
            //    {
            //        //Console.Write(j);
            //        //Console.Write("\t");
            //        Console.Write("{0}*{1}={2}",j,i,j*i);
            //        Console.Write("\t");
            //    }
            //    Console.Write("\n");

            //}

            //test3 sum output
            //int input = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i <= input; i++)
            //{
            //    Console.WriteLine("{0}  +  {1}  =  {2}",i,input-i,input);
            //}

            //tets4 zhishu
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("*******************");
            for (int i = 2; i <=input; i++)
            {
                if (zhishu(i)) { Console.Write(i+"\t"); }

                //for (int j = 2; j <= Convert.ToInt32(Math.Sqrt(i)); j++)
                //{
                //    if (i % j == 0) { break; };
                   
                //}
               
            }
            
             bool zhishu(int num) 
            {
                for (int j = 2; j <= Convert.ToInt32(Math.Sqrt(num)); j++) { if(num%j==0){ return false; }  }
                return true;

            }




           Console.ReadKey();

        }
    }
}
