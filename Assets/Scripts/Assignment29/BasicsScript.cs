using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
namespace Assignment29
{
    public class NewBehaviourScript : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            var number = 1;
            var word = "Hello";
            var isFunny = true;
            string result = (number % 2 == 0) ? "Even" : "Odd";
            Debug.Log("The number " + number + " is: " + result);
            Debug.Log("Current date: " + DateTime.Now.ToShortDateString());
            Debug.Log("Current time: " + DateTime.Now.ToLongTimeString());
            Debug.Log("Current day: " + DateTime.Now.DayOfWeek);
        }
    }
}