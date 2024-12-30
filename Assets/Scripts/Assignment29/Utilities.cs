using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
namespace Assignment29
{
    public static class Utilities
    {
        public static int Add(params int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }
        public static string RepeatString(this string repeatedString, int numberOfTimes)
        {
            string result = "";
            for (int i = 0; i < numberOfTimes; i++)
            {
                result += repeatedString;
            }
            return result;
        }
    }
}