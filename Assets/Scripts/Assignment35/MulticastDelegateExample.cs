using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment35
{
    delegate void MathOperation(int number);
    public class MulticastDelegateExample : MonoBehaviour
    {
        MathOperation operation;
        void Start()
        {
            operation += DoubleNumber;
            operation += SquareNumber;
            operation += CubeNumber;
            operation.Invoke(5);
        }

        void DoubleNumber(int number) => Debug.Log("Double: " + number * 2);
        void SquareNumber(int number) => Debug.Log("Square: " + Mathf.Pow(number, 2));
        void CubeNumber(int number) => Debug.Log("Cube:" + Mathf.Pow(number, 3));
    }
}
