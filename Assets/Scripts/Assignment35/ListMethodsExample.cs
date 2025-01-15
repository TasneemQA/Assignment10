using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment35
{
    public class ListMethodsExample : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            List<int> numbers = new List<int> { 3, 1, 4, 1, 5, 9 };
            List<int> numbers2 = new List<int> { 3, 1, 4, 1, 5, 9, 2, 6 };

            numbers.Sort((x, y) => y.CompareTo(x));
            print(string.Join(", ", numbers));

            List<int> filteredNumbers = numbers2.FindAll((n) => n % 2 == 0);
            print(string.Join(", ", filteredNumbers));
        }
    }
}
