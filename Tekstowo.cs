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

    public string SzyfrCezara(string tekst, int przesuniecie)
    {
        char[] zaszyfrowanyTekst = new char[tekst.Length];

        for (int i = 0; i < tekst.Length; i++)
        {
            char znak = tekst[i];

            if (char.IsLetter(znak))
            {
                char baza = char.IsUpper(znak) ? 'A' : 'a';
                znak = (char)((((znak + przesuniecie) - baza) % 26) + baza);
            }

            zaszyfrowanyTekst[i] = znak;
        }

        return new string(zaszyfrowanyTekst);
    }
}