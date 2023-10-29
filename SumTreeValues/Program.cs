using System.Security.Cryptography.X509Certificates;

namespace SumTreeValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание: Дан массив и число. Найдите три числа в массиве сумма которых равна искомому числу. 


            //Массив 
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //Сумма
            int sum = 12;

            List<int>res = findTreeValue(array, sum);
            

            // Выводим варианты на экран
            int count1 = 0; //эти 2 счётчика нужны для более красивого выводи на экран
            int count2 = 0;

            foreach (var item in res)
            {
                Console.Write(item);
                count1++;
                if (count1 - count2 == 3)
                {
                    Console.WriteLine();
                    count1 = 0;
                }
            }
        }

        //Метод который вернёт все варианты получение суммы путём сложение 3-ёх 
        public static List<int> findTreeValue(int[] array, int sum)
        {
            List<int> result = new List<int>();
            int value1;
            int value2;
            int value3;   

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 1; j < array.Length; j++)
                {
                    for (int k = 2; k < array.Length; k++)
                    {
                        value1 = array[i];
                        value2 = array[j];
                        value3 = array[k];

                        if (i !=j)
                        {
                            if (j != k)
                            {
                                if (i != j)
                                {
                                    if (value1 + value2 + value3 == sum)
                                    {
                                        result.Add(value1);
                                        result.Add(value2);
                                        result.Add(value3);
                                    }
                                }    
                            }
                        }

                        
                    }
                }
            }
            return result;

        }
    }
}