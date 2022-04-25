using System;
using System.Text;

public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        StringBuilder stringBuilder = new StringBuilder();
        bool isUpperFlag = false;


        foreach (char ch in text)
        {
            if (char.IsDigit(ch) || char.IsPunctuation(ch) || char.IsWhiteSpace(ch))
            {
                stringBuilder.Append(ch);
                continue;
            }

            if (char.IsUpper(ch))
            {
                isUpperFlag = true;
            }

            int index = Array.IndexOf(alphabet, char.ToLower(ch));

            int tweakedIndex = index + shiftKey;

            if (tweakedIndex >= 26)
            {
                tweakedIndex = tweakedIndex - 26;
            }

            if (isUpperFlag)
            {
                stringBuilder.Append(char.ToUpper(alphabet[tweakedIndex]));
                isUpperFlag = false;
            }
            else 
            {
                stringBuilder.Append(alphabet[tweakedIndex]);
            }
        }

        return stringBuilder.ToString();
    }
}