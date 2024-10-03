// See https://aka.ms/new-console-template for more information

{

    double length;
    double width;
    //
    Console.WriteLine("enter the length of the rectangle");
    length = Convert.ToDouble(Console.ReadLine());
    //
    Console.WriteLine("enter width of rectangle");
    width = Convert.ToDouble(Console.ReadLine());
    //
    double area = calculatingArea(length, width);
    //
    Console.WriteLine($"the earea of a area is {area}");
}
//
static double calculatingArea(double length, double width)
{
    return length * width;
}

