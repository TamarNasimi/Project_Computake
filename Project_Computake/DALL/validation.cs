﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProjectComputers.DALL
{
    public static class validation
    {
        //בדיקת תעודת זהות 
        public static bool LegalId(string s)
        {
            int x;
            if (!int.TryParse(s, out x))
                return false;
            if (s.Length < 5 || s.Length > 9)
                return false;
            for (int i = s.Length; i < 9; i++)
                s = "0" + s;
            int sum = 0;
            for (int i = 0; i < 9; i++)
            {
                int k = ((i % 2) + 1) * (Convert.ToInt32(s[i]) - '0');
                if (k > 9)
                    k -= 9;
                sum += k;

            }
            return sum % 10 == 0;
        }

        //אותיות בלבד

        public static bool IsHebrew(string word)
        {
            string pattern = @"\b[א-ת-\s ]+$";
            Regex reg = new Regex(pattern);
            return reg.IsMatch(word);

        }
        //טלפון
        public static bool IsTelephone(string tel)
        {
            string pattern = @"\b0[ 2 4 7 8 3 77]-[2-9]\d{6}$";
            Regex reg = new Regex(pattern);
            return reg.IsMatch(tel);
        }

        //פלאפון
        public static bool IsCellPhone(string tel)
        {
            string pattern = @"\b05[0 2 4 6 7 8 3]-[2-9]\d{6}$";
            Regex reg = new Regex(pattern);
            return reg.IsMatch(tel);
        }


        //חישוב גיל לפי תאריך לידה
        public static int GetAge(DateTime d)
        {
            DateTime t = DateTime.Today;
            int age = t.Year - d.Year;
            if (t < d.AddYears(age)) age--;
            return age;
        }

        //בדיקה שהטקסט בפורמט של 
        public static bool CheackMail(string t)
        {
            //דוא"ל
            if (t.Length == 0)
                return true;
            else //בדיקה שהטקסט מכיל את הסימנים '.' ו-'@'.
                if ((t.IndexOf("@") == -1) || (t.IndexOf(".") == -1))
                return false;
            else //אם הכתובת נכונה


                return true;

        }
        //   מספרים בלבד
        public static bool IsNumber(string num)
        {
            string pattern = @"\b[1-9-\s]+$";
            Regex reg = new Regex(pattern);
            return reg.IsMatch(num);
        }

        public static bool checkVisa(string numCard)
        {
            int c, result = 0;
            if (numCard == "")
                return false;
            if ((numCard.IndexOf("0") == 0 || numCard.IndexOf("0") == numCard.Length - 1))
                return false;
            string check = "one";
            for (int i = numCard.Length - 1; i >= 0; i--)
            {
                if (check == "one")
                {
                    c = Convert.ToInt32(numCard[i].ToString()) * 1;
                    check = "two";
                }
                else
                {
                    c = Convert.ToInt32(numCard[i].ToString()) * 2;
                    check = "one";
                }
                if (c >= 10)
                {
                    result += c % 10 + c / 10;
                }
                else
                    result = result + c;
            }
            if (result % 10 == 0)
                return true;
            return false;
        }
    }
}
