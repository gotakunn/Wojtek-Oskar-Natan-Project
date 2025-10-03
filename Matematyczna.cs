namespace ConsoleApp1;

public class Matematyczna
{
    static int NWD(int a, int b)
    {
        a = Math.Abs(a);
        b = Math.Abs(b);
        if (a == 0) return b;
        if (b == 0) return a;

        while (b != 0)
        {
            int temp = a % b;
            a = b;
            b = temp;
        }
        return a;
    }
}
