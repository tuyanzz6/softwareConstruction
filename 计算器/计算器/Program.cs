
using System;

class calculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("第一个数字：");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("请输入运算符 ：");
        string oper = Console.ReadLine();
        Console.WriteLine("第二个数字：");
        double num2 = Convert.ToDouble(Console.ReadLine());
        double result = 0;
        switch (oper)
        {
            case "+":
                result = num1 + num2;
                break;
            case "-":
                result = num1 - num2;
                break;
            case "*":
                result = num1 * num2;
                break;
            case "/":
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("除数不可为0");
                    return;
                }
                break;
            default:
                Console.WriteLine("无效的运算符");
                return;
        }
        Console.WriteLine($"结果：{result}");
    }
}
