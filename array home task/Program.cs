namespace array_home_task
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region task 1
            int[] numbers = { 5, 454, 23, 56, 89, 63 };


            int third = 0;

            for (int index = 0; index < numbers.Length / 2; index++)
            {
                third = numbers[index];
                numbers[index] = numbers[numbers.Length - index - 1];
                numbers[numbers.Length - index - 1] = third;
            }
            for (int indx = 0; indx < numbers.Length; indx++)
            {
                Console.WriteLine(numbers[indx]);

            }
            #endregion
            #region task 2
            int[] array = { 5,5,5,5,5,5,5,5 };
            int[] array2 = { 5, 26, 23, 56, 89, 63, 63 };
            int i = 0;
            int i2 = 0;
            bool dplicate = true;


            
                for (i = 0; i < array.Length; i++)
                {
                    bool isFound = false;

                    for (i2 = 0; i2 < array2.Length; i2++)
                    {
                        if (array2[i2] == array[i])
                        {
                            isFound = true;
                            break;
                        }
                    }
                    if (!isFound)
                    {
                        dplicate = false;
                        break;
                    }

                }
            

            Console.WriteLine(dplicate);


            #endregion
            #region task 3
            int[] num = { 5,5, 26, 23, 56, 89, 63 };


            bool dplc = false;

            for (int i3 = 0; i3 < num.Length - 1; i3++)
            {
                if (num[i3] == num[i3 + 1])
                {
                    Console.WriteLine($"dublikati var {num[i3]}");
                    dplc = true;
                }


            }

            if (!dplc)
            {
                Console.WriteLine("dublikati yoxdur");
            }

        }




        #endregion 






    }
}

