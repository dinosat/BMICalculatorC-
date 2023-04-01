class BMI
{
    private double weight;
    private double height;

public BMI(double weight, double height)
{
    this.weight = weight;
    this.height = height;
}

public double Calculate()
{
    return weight/ (height * height);
}

public void PrintResult()
{
    double bmi = Calculate();
    Console.WriteLine($"Your BMI is {bmi:F2}");

if(bmi < 18.5)
{
    Console.WriteLine("You are Underweight.");
}
else if(bmi < 25)
{
    Console.WriteLine("You are Normalweight.");

}
  else if (bmi < 30)
        {
            Console.WriteLine("You are overweight.");
        }
        else
        {
            Console.WriteLine("You are obese.");
        }

}

}