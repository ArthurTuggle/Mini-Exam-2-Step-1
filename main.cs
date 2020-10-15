using System;
class Program

{
static double CylinderVolume(double radius,double height){

return 3.14*radius*2*height;
}
static void Main(string[] args)
{
double r,h;

Console.Write("Enter the radius:");
r = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the height:");
h = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("The Volume of Cylinder = " + CylinderVolume(r,h));
}
}