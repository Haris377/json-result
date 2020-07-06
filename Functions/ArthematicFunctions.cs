using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Functions
{
    public class ArthematicFunctions
    {
        public bool isNumber1(string item)
        {

            // var check = Regex.Match(item, @"^-?\d+$");
            // int i;
            // bool b = Int32.TryParse(item, out i);

            if (item.Any(char.IsDigit))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool isNumber2(string item)
        {
            //var check = Regex.Match(item, @"^-?\d+$");
            //int i;
            //bool b = Int32.TryParse(item, out i);

            if (item.Any(char.IsDigit))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool isPrime(int num)
        {
            int flag = 0;
            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    flag = 1;
                    return false;
                }
            }
            if (num == 1 || num == 2 || num == 3)
            {
                return true;
            }
            else
            {
                return true;
            }
        }

        public ArrayList CountDuplicateItem(int[] array)
        {
            ArrayList distinctlist = new ArrayList();
            for (int j = 0; j < array.Length; j++)
            {
                for (int i = j; i < array.Length; i++)
                {
                    if (!distinctlist.Contains(array))
                    {
                        distinctlist.Add(array[j]);

                    }
                }

            }
            return distinctlist;
        }

        public int[] AddNumber(int[] array, int number, int index)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i == index)
                {
                    array[i] = number;
                    break;
                }
            }
            return array;
        }

        public ArrayList sumPrimNum(int[] array)
        {
            ArrayList list = new ArrayList();
            for (int i = 0; i < array.Length; i++)
            {
                if (isPrime(array[i]))
                {
                    list.Add(array[i]);
                }
            }
            return list;
        }

        public int Fact(int num)
        {
            if (num > 1)
            {
                return num * Fact(num - 1);
            }
            else
            {
                return 1;
            }
        }

        public int Swap(int a, int b, out int result)
        {
            a = a + b;
            b = a - b;
            a = a - b;

            result = b;
            return a;
        }

        public string Table(int n)
        {
            var retVal = string.Empty;
            if (n != 0)
            {
                for (int a = 1; a <= 10; a++)
                {
                    retVal += $"{n} * {a} = {n * a} \n";
                }
            }
            else
            {
                Console.WriteLine("Enter a valid number");
            }
            return retVal;
        }

        public float Calculation(float num1, float num2, string cal)
        {
            float c = 0;
            switch (cal)
            {
                case "+":
                    c = num1 + num2;
                    break;
                case "-":
                    c = num1 - num2;
                    break;
                case "*":
                    c = num1 * num2;
                    break;
                case "/":
                    c = num1 / num2; break;
                default:
                    Console.WriteLine("operator not match please input i.e * , / , + , -");
                    break;
            }
            return c;
        }

        public string revString(string s)
        {
            string rev = "";
            //ArrayList list = new ArrayList();
            Console.WriteLine("String before reverse: {0} ", s);
            for (int i = s.Length - 1; i >= 0; i--)
            {
                rev = rev + s[i].ToString();
            }
            return rev;
        }

        public string Palindrom(string s)
        {
            string rev = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                rev = rev + s[i].ToString();
            }

            if (s == rev)
            {
                return rev;
            }
            else
            {
                return "Not Palindrom";
            }
        }

        public string CountSimilarWords(string s)
        {
            var retVal = string.Empty;
            char[] array = new char[s.Length];
            ArrayList distinctlist = new ArrayList();
            string d = "";
            for (int i = 0; i < s.Length; i++)
            {
                array[i] = s[i];
            }
            for (int i = 0; i < array.Length; i++)
            {
                int count = 0;
                for (int j = i; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        count++;
                    }
                }
                if (!distinctlist.Contains(array[i]))
                {
                    distinctlist.Add(array[i]);
                    retVal += $"count: {array[i]} = {count} \n";
                }
            }
            return retVal;
        }

        public void SortArray(int[] array)
        {
            int temp = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        public void RemoveDuplicate(int[] array)
        {
            ArrayList list = new ArrayList();
            for (int i = 0; i < array.Length; i++)
            {
                list.Add(array[i]);
            }
            for (int i = 0; i < array.Length; i++)
            {
                int count = 0;
                for (int j = i; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        list.RemoveAt(i);
                    }
                }
            }
        }

        public void Triangle()
        {
            for (int i = 0; i <= 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public static void TriangleUpSideDown()
        {
            for (int i = 5; i >= 0; i--)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }


    }

    public class Vehicle
    {
        public int ID;
        public string Name;
        public string Model;
        public string ownerName;
        public float price;
        public static int numberofcars;
        public const int Num = 678;
        public readonly int n;
    }


}