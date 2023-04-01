class Program
{
    static void Main()
    {
Console.Write("Enter your weight in kilograms: ");
double weight = double.Parse(Console.ReadLine());
Console.Write("Enter your height in meters: ");
double height = double.Parse(Console.ReadLine());

 BMI bmi = new BMI(weight, height);
    bmi.PrintResult();
    }

   
}