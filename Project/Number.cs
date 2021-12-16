using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Number
    {
        private string Value { get; set; }
        private string System { get; set; }

        public Number(string value, string system)
        {
            this.Value = value;
            this.System = system;
        }

        private string FromBinary(string toSystem)
        {

            if (toSystem == "Восьмеричную")
            {
                long d, k = 1, p = 1, octal = 0;
                long tmp = 0;

                for (long i = long.Parse(this.Value); i > 0; i = i / 10)
                {
                    d = i % 10;

                    if (k == 1)
                    {
                        p = p * 1;
                    }
                    else
                    {
                        p = p * 2;
                    }

                    tmp = tmp + (d * p);
                    k++;
                }
                k = 1;

                for (long i = tmp; i > 0; i = i / 8)
                {
                    octal = octal + (i % 8) * k;
                    k = k * 10;
                }

                return octal.ToString();
            }

            if (toSystem == "Десятичную")
            {
                return Convert.ToInt64(this.Value, 2).ToString();
            }

            if (toSystem == "Шестнадцатиричную")
            {
                StringBuilder result = new StringBuilder(this.Value.Length / 8 + 1);

                int mod4Len = this.Value.Length % 8;

                if (mod4Len != 0)
                {
                    this.Value = this.Value.PadLeft(((this.Value.Length / 8) + 1) * 8, '0');
                }

                for (int i = 0; i < this.Value.Length; i += 8)
                {
                    string eightBits = this.Value.Substring(i, 8);
                    result.AppendFormat("{0:X2}", Convert.ToByte(eightBits, 2));
                }

                while (result.ToString().StartsWith("0") && result.Length != 1)
                {
                    result.Remove(0, 1);
                }

                return result.ToString();
            }

            return this.Value;
        }

        private string FromOctal(string toSystem)
        {

            int result = 0;
            int based = 1;
            int temp = int.Parse(this.Value);

            while (temp > 0)
            {
                int lastDigit = temp % 10;
                temp /= 10;

                result += lastDigit * based;
                based *= 8;
            }

            if (toSystem == "Шестнадцатиричную")
            {
                return Convert.ToString(int.Parse(result.ToString()), 16).ToUpper();
            }

            if (toSystem == "Десятичную")
            {
                return result.ToString();
            }

            if (toSystem == "Двоичную")
            {
                return Convert.ToString(int.Parse(result.ToString()), 2);
            }

            return this.Value;
        }

        private string FromDecimal(string toSystem)
        {
            if (toSystem == "Двоичную")
            {
                return Convert.ToString(int.Parse(this.Value), 2);
            }

            if (toSystem == "Восьмеричную")
            {
                return Convert.ToString(int.Parse(this.Value), 8);
            }

            if (toSystem == "Шестнадцатиричную")
            {
                string result = Convert.ToString(int.Parse(this.Value), 16);

                return result.ToUpper();
            }

            return this.Value;
        }

        private string FromHexademical(string toSystem)
        {
            if (toSystem == "Двоичную")
            {
                string result = "";

                result += Convert.ToString(Convert.ToInt32(this.Value, 16), 2).PadLeft(4, '0');

                while (result.StartsWith("0") && result.Length != 1)
                {
                    result = result.Remove(0, 1);
                }

                return result;
            }

            if (toSystem == "Восьмеричную")
            {
                return Convert.ToString(Convert.ToInt32(this.Value, 16), 8);
            }

            if (toSystem == "Десятичную")
            {
                return Convert.ToString(Convert.ToInt32(this.Value, 16), 10);

            }

            return this.Value;
        }

        public string Translate(string toSystem)
        {

            switch (this.System)
            {
                case "Двоичной":

                    for (int i = 0; i < this.Value.Length; i++)
                    {

                        if (this.Value[i] != '0' && this.Value[i] != '1')
                        {
                            throw new ArgumentException();
                        }

                    }

                    return FromBinary(toSystem);

                case "Восьмеричной":

                    for (int i = 0; i < this.Value.Length; i++)
                    {
                        if (this.Value[i] < 47 || this.Value[i] > 55)
                        {
                            throw new ArgumentException();
                        }
                    }

                    return FromOctal(toSystem);

                case "Десятичной":

                    for (int i = 0; i < this.Value.Length; i++)
                    {
                        if (this.Value[i] < 47 || this.Value[i] > 57)
                        {
                            throw new ArgumentException();
                        }
                    }

                    return FromDecimal(toSystem);

                case "Шестнадцатиричной":

                    for (int i = 0; i < this.Value.Length; i++)
                    {
                        if ((this.Value[i] < 47 || this.Value[i] > 57) && (this.Value[i] < 64 || this.Value[i] > 70))
                        {
                            throw new ArgumentException();
                        }
                    }

                    return FromHexademical(toSystem);

                default:
                    throw new ArgumentException();
            }
        }
    }
}