using System;

namespace MyMath
{
    public static class MathFunctions
    {

        public static double Equation(int a, int b)
        {
            if (b - a == 0)
            {
                throw new ArgumentException("division by zero");
            }
            return (5 * a + b * b) / (b - a);
        }

        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static void Division(int a, int b, ref int division, ref int remainder)
        {
            if (b == 0)
            {
                throw new ArgumentException("division by zero");
            }
            division = a / b;
            remainder = a % b;
        }

        public static double LinearEquation(double a, double b, double c)
        {
            if (a == 0)
            {
                throw new ArgumentException("division by zero");
            }
            double x = (c - b) / a;
            return x;
        }

        public static void EquationOfStraightLine(double x1, double y1, double x2, double y2, out double a, out double b)
        {
            if ((x1 - x2) == 0)
            {
                throw new ArgumentException("division by zero");
            }
            a = (y1 - y2) / (x1 - x2);
            b = y2 - a * x2;
        }

        //2.1
        public static int Equation2(int a, int b)
        {

            if (a > b)
            {
                return a + b;
            }
            else if (a == b)
            {
                return a * b;
            }
            return a - b;
        }


        //2.2 
        public static int Quarters(int x, int y)
        {
            if (x > 0 && y > 0)
            {
                return 1;
            }
            else if (x > 0 && y < 0)
            {
                return 4;
            }
            else if (x < 0 && y > 0)
            {
                return 2;
            }
            return 3;
        }

        //2.3
        public static int[] OrderOfAscending(int x, int y, int z)
        {
            int[] array = new int[3];
            if (x < y && x < z)
            {
                array[0] = x;
            }
            else if (y < x && y < z)
            {
                array[0] = y;
            }
            else if (z < y && z < x)
            {
                array[0] = z;
            }

            if ((x < y && x > z) || (x > y && x < z))
            {
                array[1] = x;
            }
            else if ((y < x && y > z) || (y > x && y < z))
            {
                array[1] = y;
            }
            else if ((z < x && z > y) || (z > x && z < y))
            {
                array[1] = z;
            }

            if (x > y && x > z)
            {
                array[2] = x;
            }
            else if (y > x && y > z)
            {
                array[2] = y;
            }
            else if (z > x && z > y)
            {
                array[2] = z;
            }
            return array;
        }

        //2.4
        public static double[] QuadraticEquation(int a, int b, int c)
        {
            double[] array = new double[2];
            int d = b * b - 4 * a * c;
            if (d > 0)
            {
                array[0] = (-b + Math.Sqrt(d)) / (2 * a);
                array[1] = (-b - Math.Sqrt(d)) / (2 * a);
            }
            else if (d == 0)
            {
                array[0] = (-b) / (2 * a);
            }

            else if (d < 0 || a == 0)
            {
                throw new ArgumentException("d<0 or a==0");
            }
            return array;
        }

        //2.5
        public static string UppercaseThisNumber(int a)
        {
            if (a == 0 || a > 99)
            {
                throw new ArgumentException("a over 99");
            }
            int a2 = a % 10;
            int a1 = a / 10;
            string a1Alfavit = "";
            string a2Alfavit = "";
            switch (a1)
            {
                case 1:
                    break;

                case 2:
                    a1Alfavit = "Двадцать";
                    break;
                case 3:
                    a1Alfavit = "Тридцать";
                    break;
                case 4:
                    a1Alfavit = "Сорок";
                    break;
                case 5:
                    a1Alfavit = "Пятьдесят";
                    break;
                case 6:
                    a1Alfavit = "Шестдисят";
                    break;
                case 7:
                    a1Alfavit = "Семьдият";
                    break;
                case 8:
                    a1Alfavit = "Восимдесят";
                    break;
                case 9:
                    a1Alfavit = "Девяносто";
                    break;

            }
            switch (a2)
            {
                case 1:
                    a2Alfavit = "";
                    break;
                case 2:
                    a2Alfavit = "два";
                    break;
                case 3:
                    a2Alfavit = "три";
                    break;
                case 4:
                    a2Alfavit = "четыре";
                    break;
                case 5:
                    a2Alfavit = "пять";
                    break;
                case 6:
                    a2Alfavit = "шесть";
                    break;
                case 7:
                    a2Alfavit = "семь";
                    break;
                case 8:
                    a2Alfavit = "восемь";
                    break;
                case 9:
                    a2Alfavit = "девять";
                    break;

            }
            if (a1 == 1)
            {
                switch (a2)
                {
                    case 1:
                        a2Alfavit = "Одиннадцать";
                        break;
                    case 2:
                        a2Alfavit = "Двенадцать";
                        break;
                    case 3:
                        a2Alfavit = "Тринадцать";
                        break;
                    case 4:
                        a2Alfavit = "Четырнадцать";
                        break;
                    case 5:
                        a2Alfavit = "Пятнадцать";
                        break;
                    case 6:
                        a2Alfavit = "Шестнадцать";
                        break;
                    case 7:
                        a2Alfavit = "Семнадцать";
                        break;
                    case 8:
                        a2Alfavit = "Восемнадцать";
                        break;
                    case 9:
                        a2Alfavit = "Девятнадцать";
                        break;

                }
            }
            return a1Alfavit + a2Alfavit;
        }

        //3.2
        public static string raisingToPower(int a)
        {
            string result = "";
            for (int i = 1; i <= 1000; i++)
            {
                if (i % a == 0)
                {
                    result += i;
                    result += " ";
                }
            }
            return result;
        }

        //3.3
        public static int numberOfPosInTsquareLesSA(int a)
        {
            int count = 0;
            for (int i = 0; i < a; i++)
            {
                if (i * i < a)
                {
                    count += 1;
                }
            }
            return count;
        }

        //3.4
        public static int NCDa(int a)
        {
            for (int i = a - 1; i > 0; i--)
            {
                if (a % i == 0)
                {
                    return i;
                }
            }
            throw new ArgumentException("d<0 or a==0"); ;
        }

        //3.5
        public static int sumOfNumAtoBdivisibleBy7(int a, int b)
        {
            int max;
            int min;
            int sum = 0;
            if (a > b)
            {
                max = a;
                min = b;
            }
            else
            {
                min = a;
                max = b;
            }
            for (int i = min; i <= max; i++)
            {
                if (i % 7 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }

        //3.6
        public static int Factorial(int n)
        {
            int f1 = 1;
            while (n > 1)
            {
                f1 *= n;
                n -= 1;
            }
            return f1;
        }

        //3.7
        public static int NODEvclida(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a = a % b;
                }
                else
                {
                    b = b % a;
                }
            }
            return a + b;
        }

        //3.8
        public static int SqrtN(int n)
        {
            int temp = n / 2;
            int min = 1;
            int max = n;
            while (temp * temp * temp != n)
            {
                temp = (min + max) / 2;
                if (temp == min || temp == max)
                    throw new ArgumentException("infinite");

                if (temp * temp * temp > n)
                {
                    max = temp - 1;
                }
                else
                {
                    min = temp + 1;
                }
            }
            return temp;
        }

        //3.9
        public static int CountOddElements(int n)
        {
            int count = 0;
            int t = n % 10;
            while (n != 0)
            {
                int x = n % 2;
                if (x != 0)
                {
                    count += 1;
                }
                n = n / 10;
                t = n % 10;
            }
            if(count == 0)
            {
                throw new ArgumentException("В этом числе нет нечетных елементов");
            }
            return count;
        }

        //3.10
        public static int Mirroy(int n)
        {
            string m = "";
            int temp = n;
            while (temp != 0)
            {
                m += Convert.ToString(temp % 10);
                temp = temp / 10;
            }
            int n1 = Convert.ToInt32(m);
            return n1;
        }

        //3.11
        public static int RangeTheSumOfEvenDigitssumodd(int n)
        {
            int temp;
            for (int i = 1; i < n; i++)
            {
                int even = 0;
                int odd = 0;
                temp = i;
                while (temp != 0)
                {
                    int t = temp % 10;
                    if ((t) % 2 == 0)
                    {
                        even += t;
                    }
                    else
                    {
                        odd += t;
                    }
                    temp = temp / 10;
                }
                if (even > odd)
                {
                    return i;
                }
            }
            return -1;
        }

        //3.12
        public static bool RangeTheSumOfEvenDigitssumodd(int a, int b)
        {
            int count = 0;
            int tempB = b;
            while (a != 0)
            {
                int t1 = a % 10;
                while (tempB != 0)
                {
                    int t2 = tempB % 10;
                    if (t1 == t2)
                    {
                        count += 1;
                        break;
                    }
                    tempB = tempB / 10;
                }
                a = a / 10;
                tempB = b;
            }
            if (count > 0)
            {
                return true;
            }
            return false;
        }

        //4.1
        public static int MinOfArray(int[] array)
        {
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
            }
            return min;
        }

        //4.2
        public static int MaxOfArray(int[] array)
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            return max;
        }

        //4.3
        public static int MinIndexOfArray(int[] array)
        {
            
            int min = array[0];
            int minIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                    minIndex = i;
                }
            }
            return minIndex;
        }

        //4.4
        public static int MaxIndexOfArray(int[] array)
        {
            int max = array[0];
            int maxIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                    maxIndex = i;
                }
            }
            return maxIndex;
        }

        //4.5
        public static int SumOfOdd(int[] array)
        {
            int sumOfOdd = 0;
            for (int i = 1; i < array.Length; i += 2)
            {
                sumOfOdd += array[i];
            }
            return sumOfOdd;
        }

        //4.6
        public static int[] ReversArray(int[] array)
        { 
            int temp;
            int t;
            for (int i = 0; i < array.Length / 2; i++)
            {
                t = array.Length - i - 1;
                temp = array[i];
                array[i] = array[t];
                array[t] = temp;
            }
            return array;
        }

        //4.7
        public static int CountOfOddElementArray(int[] array)
        {
            
            int countOfOdd = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    countOfOdd += 1;
                }
            }
            return countOfOdd;
        }

        //4.8
        public static int[] ReversHalfOfArray(int[] array)
        {
            int b = array.Length / 2;
            if (array.Length % 2 != 0)
            {
                b++;
            }
            int temp;
            for (int a = 0; a < array.Length / 2; a++, b++)
            {
                temp = array[a];
                array[a] = array[b];
                array[b] = temp;
            }
            return array;
        }

        //4.9
        public static int[] SortBubleOfArray(int[] array)
        { 
            int temp;

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            return array;
        }

        //4.10
        public static int[] SortInsertOfArray(int[] array)
        {
            int temp;
            for (int i = 0; i < array.Length; i++)
            {
                int key = array[i];
                int j = i;
                while ((j > 0) && (array[j - 1] < key))
                {
                    temp = array[j - 1];
                    array[j - 1] = array[j];
                    array[j] = temp;
                    j--;
                }
                array[j] = key;
            }
            return array;
        }

        //5.1
        public static int MinofArrayArray(int n, int m)
        {
            int[,] array = new int[n, m];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = random.Next(0, 10);
                    Console.Write($"{array[i, j]} \t");
                }
                Console.WriteLine();
            }
            int min = array[0, 0];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (min > array[i, j])
                    {
                        min = array[i, j];
                    }
                }
            }
            return min;

        }
        //5.2
        public static int MaxofArrayArray(int n, int m)
        {
            int[,] array = new int[n, m];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = random.Next(0, 10);
                    Console.Write($"{array[i, j]} \t");
                }
                Console.WriteLine();
            }
            int max = array[0, 0];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (max < array[i, j])
                    {
                        max = array[i, j];
                    }
                }
            }
            return max;
        }

        //5.3
        public static int[] MinofIndexOfArrayArray(int n, int m)
        {
            int[,] array = new int[n, m];
            int[] minij = new int[2];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = random.Next(0, 10);
                    Console.Write($"{array[i, j]} \t");
                }
                Console.WriteLine();
            }
            int min = array[0, 0];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (min > array[i, j])
                    {
                        min = array[i, j];
                        minij[0] = i;
                        minij[1] = j;
                    }
                }
            }
            return minij;
        }

        //5.4
        public static int[] MaxofIndexOfArrayArray(int n, int m)
        {
            int[,] array = new int[n, m];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = random.Next(0, 10);
                    Console.Write($"{array[i, j]} \t");
                }
                Console.WriteLine();
            }
            int maxij = 0;
            int[] max = new int[2];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (maxij < array[i, j])
                    {
                        maxij = array[i, j];
                        max[0] = i;
                        max[1] = j;
                    }
                }
            }
            return max;
        }

        //5.5
        public static int CountOfBoarder(int n, int m)
        {
            int[,] array = new int[n, m];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = random.Next(0, 100);
                    Console.Write($"{array[i, j]} \t");
                }
                Console.WriteLine();
            }
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    int current = array[i, j];
                    int[] neigh = new int[4] { 0, 0, 0, 0 };
                    if (j - 1 >= 0)
                    {
                        neigh[0] = array[i, j - 1];
                    }
                    if (j + 1 < m)
                    {
                        neigh[1] = array[i, j + 1];
                    }
                    if (i - 1 >= 0)
                    {
                        neigh[2] = array[i - 1, j];
                    }
                    if (i + 1 < n)
                    {
                        neigh[3] = array[i + 1, j];
                    }
                    int countNeight = 0;
                    for (int k = 0; k < neigh.Length; k++)
                    {
                        if (current > neigh[k])
                        {
                            countNeight += 1;
                        }
                    }
                    if (countNeight == 4)
                    {
                        count += 1;
                    }

                }

            }
            return count;
        }

        //5.6
        public static int[,] FlipsArrayRelativediagonal(int n, int m)
        {
            int[,] array = new int[n, m];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = random.Next(0, 10);
                    Console.Write($"{array[i, j]} \t");
                }
                Console.WriteLine();
            }
            int temp;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < m; j++)
                {
                    temp = array[i, j];
                    array[i, j] = array[j, i];
                    array[j, i] = temp;
                }
            }
            return array;
        }
    }
}
