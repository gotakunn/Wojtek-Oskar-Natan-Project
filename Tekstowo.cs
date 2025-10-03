namespace ConsoleApp1;

public class Tekstowo
{
    public bool CzyPalindrom(string tekst)
    {
        int lewy = 0;
        int prawy = tekst.Length - 1;

        while (lewy < prawy)
        {
            if (tekst[lewy] != tekst[prawy])
            {
                return false;
            }
            lewy++;
            prawy--;
        }

        return true;
    }
}