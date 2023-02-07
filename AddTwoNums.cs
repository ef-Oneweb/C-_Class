namespace ClassCSharp
{
    public class AddTwoNums
    {
        public void Add2Nums()
        {
            int num1;
            int num2;
            int total;

            Console.WriteLine("Enter first number :");
            num1 = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Enter second number :");
            num2 = Convert.ToInt32(Console.ReadLine());         
            total = num2 + num1;         
            Console.WriteLine("Total is : "+ total);
            Console.ReadKey();
        }


        public void AddSNums()
        {
            int num1;
            int num2;
            int total;

            Console.WriteLine("Enter first number :");
            num1 = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Enter second number :");
            num2 = Convert.ToInt32(Console.ReadLine());         
            total = num2 - num1;         
            Console.WriteLine("Total is : "+ total);
            Console.ReadKey();
        }
    
    }
}
