using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment35
{
    public class BuiltInDelegatesExample : MonoBehaviour
    {
        void Start()
        {
            Action<string> logMessage = (string s) => Debug.Log(s);
            logMessage("Hello from Action delegate");
            Func<int, int> square = (int num) => (int)MathF.Pow(num, 2);
            Debug.Log("Square: " + square(5));
            Predicate<int> isEven = n => n % 2 == 0;
            Debug.Log("Is 4 even? " + isEven(4));
        }
    }
}
