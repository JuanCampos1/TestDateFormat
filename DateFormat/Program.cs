﻿using System;

namespace TestDateFormat
{
    public class Program
    {
        public static String ChangeFormat(String year)
        {
            return year.Substring(6) + "-" + year.Substring(3, 2) + "-" + year.Substring(0, 2);
        }

        public static String ChangeFormat2(String year)
        {
            return year.Substring(3, 2) + "-" + year.Substring(0, 2) + "-" + year.Substring(6);
        }

        public static void Main(string[] args)
        {
            string testDate = "10/11/1977";
            Console.WriteLine("{0} se convierte a: {1} ", testDate, ChangeFormat(testDate));
        }
    }
}