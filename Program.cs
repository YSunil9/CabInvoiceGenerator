namespace CabIvoiceGenerate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to Cab Invoice Generator!");
            InvoiceGenerator obj = new InvoiceGenerator();
            double fare1 = obj.CalculateFare(12, 40);
            Console.WriteLine("Total Fare for your Journey is :" + fare1);
        }
    }
}