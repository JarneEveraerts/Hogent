using System.Text;

namespace Palindroom.Domain
{
    public class Palindroom
    {
        public static Boolean IsPalindroom(string text)
        {
            // Precondities: wat moet geldig zijn vooraf - "defensief programmeren"
            if (string.IsNullOrEmpty(text))
            {
                throw new ArgumentException("Ongeldige tekst");
            }
            if (text.Length < 2)
            {
                throw new ArgumentException("Tekst moet meer dan 1 karakter bevatten");
            }

            StringBuilder sb = new();
            for (var i = text.Length - 1; i >= 0; i--)
            {
                sb.Append(text[i]);
            }
            var omgekeerd = sb.ToString();

            // Postcondities: wat moet geldig zijn achteraf

            return string.Equals(text, omgekeerd, StringComparison.OrdinalIgnoreCase);
        }
    }
}