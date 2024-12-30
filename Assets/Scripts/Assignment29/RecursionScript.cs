using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment29
{
    public class RecursionScript : MonoBehaviour
    {
        // Recursive method
        public int FibonacciRecursive(int n)
        {
            if (n < 0)
                return -1;
            // Base Condition
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;
            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }
        // Iterative method
        public int FibonacciIterative(int n)
        {
            if (n < 0)
            {
                return -1;
            }
            if (n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }
            int prev = 0;
            int curr = 1;
            int result = 0;
            while (n >= 2)
            {
                result = prev + curr;
                prev = curr;
                curr = result;
                n--;
            }
            return result;
        }
        void Start()
        {
            print(FibonacciRecursive(10));
            print(FibonacciRecursive(30));
            print(FibonacciIterative(10));
            print(FibonacciIterative(30));
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}