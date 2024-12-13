using static System.Runtime.InteropServices.JavaScript.JSType;

namespace String_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //void Num(int number, int[] number_nums, int index)
            //{
            //    if (number == 0)                             // рекурсия чтобы разбить число на разряды
            //    {
            //        return;
            //    }
            //    Num(number / 10, number_nums, index - 1);
            //    int digit = number % 10;
            //    number_nums[index] = digit;
            //}

            //Console.WriteLine("Ввведите ваше число от 1 до 10000000: ");
            //int number = Convert.ToInt32(Console.ReadLine()); // считываем ввод пользователя
            //int length = number.ToString().Length;            // преобразовал введенное число в строку и определил длину

            //int[] number_nums = new int[length];             // тут я создал массив размера как число, чтобы в него сохранить разряды числа

            //Console.WriteLine("Длина числа = " + length);                       // длина числа

            //Console.WriteLine("Ваше число = " + number);

            //string[] edin = { "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять", };
            //string[] des = { "одинадцать", "двенадцать", "тринадцать", "четырнадцать", "пятнадцать", "шестнадцать", "семнадцать", "восемнадцать", "девятнадцать" };
            //string[] sot = { "двадцать", "тридцать", "сорок", "пятьдесят", "шестьдесят", "семьдесят", "восемьдесят", "девяносто" };
            //string[] tis = { "сто", "двести", "триста", "четыреста", "пятьсот", "шестьсот", "семьсот", "восемьсот", "девятьсот" };
            //string[] assorti = { "одна", "две", "тысяча", "тысячи", "тысяч", "миллион" };

            //// это массивы из которых мы будем доставать нужные слова



            //Num(number, number_nums, length - 1);

            //Console.WriteLine("Разряды числа:");
            //foreach (int digit in number_nums)               // форичем вывожу разряды числа на экран из массива
            //{
            //    Console.WriteLine(digit);
            //}

            //string result = "";                              // сюда будем записывать слова нашего числа

            //for (int i = 0; i < length; i++)
            //{
            //    int digit = number_nums[i];
            //    int position = length - i;

            //    if (position == 7)
            //    {
            //        result += edin[digit - 1] + " " + assorti[5] + " ";     // ну и тут какая-то логика, которую сложно читать и понимать, над ней ещё работать и работать
            //    }
            //    else if (position == 6)
            //    {
            //        result += tis[digit - 1] + " ";
            //    }
            //    else if (position == 5)
            //    {
            //        if (digit == 1)
            //        {
            //            result += des[number_nums[i + 1] - 1] + " " + assorti[4] + " ";
            //            i++;
            //        }
            //        else if (digit > 1)
            //        {
            //            result += sot[digit - 2] + " ";
            //        }
            //    }
            //    else if (position == 4)
            //    {
            //        if (digit > 0)
            //        {
            //            result += edin[digit - 1] + " " + assorti[2] + " ";
            //        }
            //    }
            //    else if (position == 3)
            //    {
            //        result += tis[digit - 1] + " ";
            //    }
            //    else if (position == 2)
            //    {
            //        if (digit == 1)
            //        {
            //            result += des[number_nums[i + 1] - 1] + " ";
            //            break;
            //        }
            //        else if (digit > 1)
            //        {
            //            result += sot[digit - 2] + " ";
            //        }
            //    }
            //    else if (position == 1)
            //    {
            //        result += edin[digit - 1] + " ";
            //    }
            //}
            //Console.WriteLine(result);


            //int[,] array = new int[5, 6];                       // это уже задача с двумерным массивом
            //int value = 1;

            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        array[i, j] = value;
            //        value++;
            //    }
            //}

            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        Console.Write(array[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}




            string input = Console.ReadLine();
           
            IsPalindrome(input);

            static void IsPalindrome(string str)                              // это метод для определения палиндрома
            {
                int left = 0;
                int right = str.Length - 1;
                bool isPalindrome = true;

                while (left < right)
                {
                    if (char.ToLower(str[left]) != char.ToLower(str[right]))
                    {
                        isPalindrome = false;
                        break;                                              
                    }
                    left++;
                    right--;
                }

                if (isPalindrome)
                {
                    Console.WriteLine("Палиндром");
                }
                else
                {
                    Console.WriteLine("Не палиндром");
                }
            }

        }
    }
}
