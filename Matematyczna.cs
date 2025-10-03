namespace ConsoleApp1;

public class Matematyczna
{
    public int[] BoobleSort(int[] tab)
    {
        int n = tab.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (tab[j] > tab[j + 1])
                {
                    // swap temp and arr[i]
                    int temp = tab[j];
                    tab[j] = tab[j + 1];
                    tab[j + 1] = temp;
                }
            }
        }
        return tab;
    }
    static public int NWD(int a, int b)
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
