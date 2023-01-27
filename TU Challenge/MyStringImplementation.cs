using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyStringImplementation
    {
        public static bool IsNullEmptyOrWhiteSpace(string a)
        {
            if (a == null || a.Length < 1)
            {
                return true;
            }
            else
            {
                foreach (char c in a)
                {
                    if (c != ' ') return false;
                }
                return true;
            }
        }

        public static string MixString(string a, string b)
        {
            if (a == null || a.Length <= 0)
            {
                throw new ArgumentException(nameof(a));
            }
            else if (b == null || b.Length <= 0)
            {
                throw new ArgumentException(nameof(b));
            }

            string? c = "";

            for (int i = 0; i < a.Length + b.Length; i++)
            {
                if (i < a.Length)
                {
                    c += a[i];
                }

                if (i < b.Length)
                {
                    c += b[i];
                }
            }

            return c;
        }

        public static string ToLowerCase(string a)
        {
            string? str = "";

            for (int i = 0; i < a.Length; i++)
            {
                char c = a[i];

                if (c != ' ' && c < 97 && c > 64)
                {
                    c += (char)32;
                }
                else if (c == 'É')
                {
                    c = 'é';
                }

                str += c;
            }

            return str;
        }

        public static string Voyelles(string a)
        {
            a = ToLowerCase(a);
            string? str = "";
            char[] voyelles = new char[] {'a', 'e', 'i', 'o', 'u', 'y'};

            foreach (char c in a)
            {
                if (voyelles.Contains(c) && !str.Contains(c))
                {
                    str += c;
                }
            }

            return str;
        }

        public static string Reverse(string a)
        {
            string? str = "";

            for (int i = a.Length - 1; i >= 0; i--)
            {
                str += a[i];
            }

            return str;
        }

        public static string BazardString(string a)
        {
            string? str = "";
            string? strB = "";

            for (int i = 0; i < a.Length; i++)
            {
                if ((i % 2) == 0)
                {
                    str += a[i];
                }
                else
                {
                    strB += a[i];
                }
            }

            str += strB;

            return str;
        }

        public static string UnBazardString(string a)
        {
            string? str = "";

            for (int i = 0; i < a.Length / 2; i++)
            {
                str += a[i];
                str += a[i + a.Length / 2];
            }

            return str;
        }
    }
}
