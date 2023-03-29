namespace ConsoleApp22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 5, 6, 7, 8 };
            InsertArray(ref  numbers,12,13);
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }
           
        }
        public static void InsertArray(ref int[] arr, params int[] nums) 
        {
            
            int[] numbers2= new int[arr.Length+nums.Length];
            for (int i=0 ; i < arr.Length; i++)
            {
                numbers2[i] = arr[i];
                numbers2[i+nums.Length]=i;
               
            }
            for (int i = 0; i < nums.Length; i++)
            {
                numbers2[arr.Length + i] = nums[i];
            }

            arr = numbers2;
        }
    }
}