using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectCodeLibrary
{
    public class CorrectCodeClass
    {
        /// <summary>
        /// Проверка кода
        /// </summary>
        /// <param name="candidate">Метод принимает в качестве параметра строку. </param>
        /// <returns>Метод возвращает true, если входная строка соответствует следующим условиям:
        /// строка имеет правильную длину;
        /// десятый символ строки(контрольное значение) содержит правильную цифру.
        /// При нарушении данных условий, метод возвращает false.</returns>
        /// 
        public static bool IsCorrectCode(string candidate)
        {
            if (String.IsNullOrWhiteSpace(candidate) || candidate.Length != 10)
            {
                return false;
            }

            for (int i = 0; i < candidate.Length; i++)
            {
                if (!Char.IsDigit(candidate[i]))
                {
                    return false;
                }
            }
            candidate = candidate.Replace(" ", "");
            candidate = candidate.Replace(",", "");
            candidate = candidate.Replace("/", "");
            candidate = candidate.Replace(".", "");

            int sum = 0;
            int a = 0;

            for (int i = 0; i < 9; i++)
            {
                int e = int.Parse(Convert.ToString(candidate[i]));
                sum = sum + e;
            }

            if (!int.TryParse(candidate.Substring(9, 1), out int ss))
            {
                throw new Exception("");
            }

            if (sum % 10 == 0)
            {
                sum = 0;
                if (sum == Convert.ToInt32(candidate[candidate.Length - 1].ToString()))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            if (sum % 3 == 0)
            {
                sum = 1;
                if (sum == Convert.ToInt32(candidate[candidate.Length - 1].ToString()))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            else
            {
                sum = 9;
                if (sum == Convert.ToInt32(candidate[candidate.Length - 1].ToString()))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }

    }
}
