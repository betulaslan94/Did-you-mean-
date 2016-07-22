using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Did_you_mean
{
    class Class1
    {
    }
    static class ExtensionMethods
    {
        public static string Soundex(this string exp)
        {
            string deger = String.Empty;
            if (exp.Length > 1)
            {
                deger = exp.Substring(0, 1);
                exp = exp.Substring(1, exp.Length - 1);

                exp = exp.Replace("Ğ", "G");
                exp = exp.Replace("Ü", "U");
                exp = exp.Replace("Ş", "S");
                exp = exp.Replace("Ö", "O");
                exp = exp.Replace("İ", "I");
                exp = exp.Replace("Ç", "C");


                exp = exp.Replace("A", "");
                exp = exp.Replace("E", "");
                exp = exp.Replace("H", "");
                exp = exp.Replace("I", "");
                exp = exp.Replace("O", "");
                exp = exp.Replace("U", "");
                exp = exp.Replace("W", "");
                exp = exp.Replace("Y", "");

                string karakter = "";
                string o_karakter = "";

                for (int i = 0; i < exp.Length; i++)
                {
                    int code = new int();

                    karakter = exp[i].ToString();
                    if ("BFVP".Contains(karakter))
                    {
                        code = 1;
                    }
                    else if ("CGJKQSXZ".Contains(karakter))
                    {
                        code = 2;
                    }
                    else if ("DT".Contains(karakter))
                    {
                        code = 3;
                    }
                    else if ("L".Contains(karakter))
                    {
                        code = 4;
                    }
                    else if ("MN".Contains(karakter))
                    {
                        code = 5;
                    }
                    else if ("R".Contains(karakter))
                    {
                        code = 6;
                    }
                    if (karakter != o_karakter)
                    {
                        if (deger.Substring((deger.Length - 1), 1) != code.ToString())
                        {
                            deger += code.ToString();
                        }
                    }
                    if (deger.Length == 4)
                    {
                        break;
                    }
                    if (karakter != "")
                    {
                        o_karakter = karakter;
                    }
                }
                int uzunluk = deger.Length;
                for (int j = 0; j < (4 - uzunluk); j++)
                {
                    deger += "0";
                }
            }
            return deger;
        }
    }

}
