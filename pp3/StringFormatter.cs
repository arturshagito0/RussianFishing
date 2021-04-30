using System;
using System.Text;

namespace pp3
{
    public static class StringFormatter
    {
        public enum FORMAT_KIND
        {
            CURR,
            WEIGHT
        }

        

        public static string decimalFormat(string str, FORMAT_KIND kind)
        {
            char[] reversed_chars = str.ToCharArray();
            Array.Reverse(reversed_chars);
            StringBuilder strb = new StringBuilder();

            int count = 0;


            foreach (var item in reversed_chars)
            {
                if (count % 3 == 0 && count < reversed_chars.Length && count != 0)
                {
                    strb.Append(" ");
                    strb.Append(reversed_chars[count]);

                }

                else
                {
                    strb.Append(reversed_chars[count]);
                }

                count++;
            }

            char[] aux = strb.ToString().ToCharArray();
            Array.Reverse(aux);

            string suffix = "";

            switch (kind)
            {
                case FORMAT_KIND.WEIGHT:
                    {
                        suffix = " кг.";
                        break;
                    }


                case FORMAT_KIND.CURR:
                    {
                        suffix = " руб.";
                        break;
                    }

                default:
                    {
                        suffix = "";
                        break;
                    }

            }

            string final_string = new String(aux) + suffix;
            return final_string;

        }

    }
}
