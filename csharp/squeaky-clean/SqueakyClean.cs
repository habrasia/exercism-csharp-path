using System;
using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        StringBuilder cleanedIdentifier = new StringBuilder();

        bool letterToUpper = false;


        for (int i = 0; i < identifier.Length; i++)
        {
            char ch = identifier[i];

            if (ch == ' ')
            {
                cleanedIdentifier.Append('_');
                continue;
            }
            else if (char.IsControl(ch))
            {
                cleanedIdentifier.Append("CTRL");
                continue;
            }
            else if (ch == '-')
            {
                letterToUpper = true;
                continue;
            }
            else if (ch >= 'α' && ch <= 'ω')
            {
                continue;
            }
            else
            {
                if (char.IsLetter(ch))
                {
                    if (letterToUpper)
                    {
                        ch = Char.ToUpper(ch);
                        cleanedIdentifier.Append(ch);
                        letterToUpper = false;
                    }
                    else
                    {
                        cleanedIdentifier.Append(ch);
                    }
                }
            }
        }
        return cleanedIdentifier.ToString();
    }
}
