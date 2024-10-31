using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplicationTable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i <= 10; i++)
        {
            Debug.Log(5 + " x " + i + " = " + Multiply(i, 5));
        }

    }
    int Multiply(int number1, int number2)
    {
        int product = number1 * number2;
        return product;
    }

}
