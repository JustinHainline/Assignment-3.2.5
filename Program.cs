namespace Assignment_3._2._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = { 1, 2, 3, 4, 5 };

            Console.WriteLine("This is the Array: ");
            Console.Write("[ ");


            for(int i = 0; i < numArray.Length;  i++)
            {
                if(i == (numArray.Length - 1))
                {
                    Console.Write(numArray[i]);  
                }
                else
                {
                    Console.WriteLine(numArray[i] + ", ");
                }
            }
            Console.Write(" ]");
            Console.WriteLine();

            int index = GetIndex(numArray, 3);
            Console.WriteLine($"The index of 3 in the array is: {index}");

           

        }
        

        public static int GetIndex(int[] numArray, int num)
        {
            for (int i = 0; i < numArray.Length; i++)
            {
                if (numArray[i] == num) return i;
            }
            return -1;
        }
    }
}
