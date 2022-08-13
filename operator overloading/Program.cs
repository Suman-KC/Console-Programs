using System;
class Complex
{
    private int x;
    private int y;
    public Complex()
    {
    }
    public Complex(int i, int j)
    {
        x = i;
        y = j;
    }
    public void ShowXY()
    {
        Console.WriteLine("{0} {1}", x, y);
    }
    public static Complex operator +(Complex c)
    {
        Complex temp = new Complex();
        temp.x = +c.x;
        temp.y = +c.y;
        return temp;
    }
}
class MyClient
{
    public static void Main()
    {
        Complex c1 = new Complex(10, 20);
        c1.ShowXY(); // displays 10 & 20  
        Complex c2 = new Complex(30,40);
        c2.ShowXY(); // displays 0 & 0  
        c2 = +c1;// copy c1 to c2
        c2.ShowXY(); // diapls -10 & -20  
    }
}