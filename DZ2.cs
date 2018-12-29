using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.	Составить программу вывода на экран в одну строку трех любых чисел с двумя пробелами между ними.
            //Console.WriteLine("Введите три числа: ");
            //int firstnumber = int.Parse(Console.ReadLine());
            //int secondnumber = int.Parse(Console.ReadLine());
            //int thirdnumber = int.Parse(Console.ReadLine());
            //Console.WriteLine("Три числа с двумя пробелами между ними: " + firstnumber + "  " + secondnumber + "  " + thirdnumber);
            //Console.Read();
            //2.	Вывести на экран числа 5, 10 и 21 одно под другим.
            //int firstnumber = 5;
            //int secondnumber = 10;
            //int thirdnumber = 21;
            //Console.WriteLine("Числа одно под другим: ");
            //Console.WriteLine(firstnumber);
            //Console.WriteLine(secondnumber);
            //Console.WriteLine(thirdnumber);
            //Console.Read();
            //3.	Дано расстояние в сантиметрах. Найти число полных метров в нем.
            //Console.WriteLine("Введите расстояния в сантиметрах: ");
            //int distance = int.Parse(Console.ReadLine());
            //int metr = distance /100;
            //Console.Write("Полных метров в сантиметрах: " + metr);
            //Console.Read();
            //4.	С некоторого момента прошло 234 дня. Сколько полных недель прошло за этот период?
            //int day = 234;
            //int week = 7;
            //int fullweek = day / week;
            //Console.Write("Полных недель в 234 дней: " + fullweek);
            //Console.Read();
            //5.	Дано двузначное число. Найти:
            //a.число десятков в нем;
            //b.число единиц в нем;
            //c.сумму его цифр;
            //d.произведение его цифр
            //Console.WriteLine("Введите двузначное число: ");
            //int num = int.Parse(Console.ReadLine());
            //int desyatki = num / 10;
            //int edinic = num % 10;
            //int sum = desyatki + edinic;
            //int proizv = desyatki * edinic;
            //Console.WriteLine("Число десятков в вашем числе: " + desyatki);
            //Console.WriteLine("Число единиц в вашем числе: " + edinic);
            //Console.WriteLine("Сумма цифр в вашем числе: " + sum);
            //Console.WriteLine("Произведение цифр в вашем числе: " + proizv);
            //Console.Read();
            //6.	Вычислить значение логического выражения при следующих значениях логических величин А, В и С: А = Истина, В = Ложь, С = Ложь:
            //a.А или В;
            //b.А и В;
            //c.В или С.
            //bool A = true;
            //bool B = false;
            //bool C = false;
            //if (A || B)
            //{
            //    Console.WriteLine("A || B - True");
            //}
            //else
            //{
            //    Console.WriteLine("A || B - False");
            //}
            //if (A && B)
            //{
            //    Console.WriteLine("A && B - True");
            //}
            //else
            //{
            //    Console.WriteLine("A && B - False");
            //}
            //if (B || C)
            //{
            //    Console.WriteLine("B || C - True");
            //}
            //else
            //{
            //    Console.WriteLine("B || C - False");
            //}
            //Console.Read();
            //7.	Даны радиус круга и сторона квадрата. У какой фигуры площадь больше?
            //Console.WriteLine("Введите радиус круга: ");
            //var R = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введите сторону квадрата");
            //var a = int.Parse(Console.ReadLine());
            //var SKrug = Math.PI * (R * R);
            //var SKvadrat = a * a;
            //if (SKrug > SKvadrat)
            //{
            //    Console.WriteLine("Площадь круга больше площади квадрата");
            //}
            //else if(SKrug < SKvadrat)
            //{
            //    Console.WriteLine("Площадь квадрата больше площади круга");
            //}
            //else if(SKrug == SKvadrat)
            //{
            //    Console.WriteLine("Площади квадрата и круга равны");
            //}
            //Console.Read();
            //8.	 Даны объемы и массы двух тел из разных материалов. Материал какого из тел имеет большую плотность?
            //Console.WriteLine("Введите массу первого тела: ");
            //var m1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введите объём первого тела: ");
            //var V1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введите массу второго тела: ");
            //var m2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введите объём второго тела: ");
            //var V2 = int.Parse(Console.ReadLine());
            //var p1 = m1 / V1;
            //var p2 = m2 / V2;
            //if(p1 > p2)
            //{
            //    Console.WriteLine("Плотность первого тела больше");
            //}
            //else if(p1 < p2)
            //{
            //    Console.WriteLine("Плотность второго тела больше");
            //}
            //else if(p1 == p2)
            //{
            //    Console.WriteLine("Плотности равны");
            //}
            //Console.Read();
            //9.	 Известны сопротивления двух несоединенных друг с другом участков электрической 
            //цепи и напряжение на каждом из них. По какому участку протекает меньший ток?
            //Console.WriteLine("Введите напряжение первого участка электрической цепи: ");
            //var U1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введите сопротивление первого участка электрической цепи: ");
            //var R1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введите напряжение второго участка электрической цепи: ");
            //var U2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введите сопротивление второго участка электрической цепи: ");
            //var R2 = int.Parse(Console.ReadLine());
            //var I1 = U1 / R1;
            //var I2 = U2 / R2;
            //if (I1 > I2)
            //{
            //    Console.WriteLine("По второму участку протекает меньший ток");
            //}
            //else if(I1 < I2)
            //{
            //    Console.WriteLine("По первому участку протекает меньший ток");
            //}
            //else if(I1 == I2)
            //{
            //    Console.WriteLine("По обоим участкам протекает одинаковый ток");
            //}
            //Console.Read();
            //10.	 Напечатать "столбиком": 
            //a.все целые числа от 20 до 35;
            //b.квадраты всех целых чисел от 10 до b(значение b вводится с клавиатуры; b > 10);
            //c.третьи степени всех целых чисел от a до 50(значение a вводится с клавиатуры; a < 50);
            //d.все целые числа от a до b(значения a и b вводятся с клавиатуры; b > a).
            //for(int i = 20; i <= 35; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("Введите число, до которого от 10 считаются квадраты этих чисел: ");
            //var b = int.Parse(Console.ReadLine());
            //for(int i = 10; b >= i; i++)
            //{
            //    var kvChisel = i * i;
            //    Console.WriteLine(kvChisel);
            //}
            //Console.WriteLine("Введите число, от которого до 50 считаются третьи степени этих чисел: ");
            //var a = int.Parse(Console.ReadLine());
            //for(; a < 50; a++)
            //{
            //    var trStepenChisel = a * a * a;
            //    Console.WriteLine(trStepenChisel);
            //}
            //Console.WriteLine("Введите число, от которого до второго числа будут выводится целые числа: ");
            //var num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введите число, до которого будут выводится целые числа: ");
            //var num2 = int.Parse(Console.ReadLine());
            //for(;num2 >= num1; num1++)
            //{
            //    Console.WriteLine(num1);
            //}
            //Console.Read();
        }
    }
}
